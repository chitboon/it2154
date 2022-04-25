using System;
using System.Collections.Generic;
using System.Linq;

namespace IPChecker {
    public class IPRule {
        public virtual bool Contains(IPAddress address) {
            return false;
        }
    }

    public class IPRange  : IPRule{
        private IPAddress lowerBound;
        private IPAddress upperBound;

        public IPRange(string s) { 
            if (s.Contains("-")) {
                string[] addrs = s.Split('-');
                if (addrs.Length > 1) {
                    var lb = addrs[0];
                    var ub = addrs[1];
                    this.lowerBound = new IPAddress(lb);
                    this.upperBound = new IPAddress(ub);
                }
            }
        }

        public override bool Contains(IPAddress address) {
            return (this.lowerBound.GetAddr() <= address.GetAddr()) && (address.GetAddr() <= this.upperBound.GetAddr());
        }
    }

    public class IPList : IPRule{
        private List<IPAddress> addresses;
        public IPList(string s) {
            if (s.Contains(",")) {
                List<string> addrs = s.Split(',').Select(s=>s.Trim()).ToList();
                this.addresses = addrs.Select(a => new IPAddress(a)).ToList();
            }
        }
        public override bool Contains(IPAddress address) {
            foreach (var a in this.addresses) {
                if (a.GetAddr() == address.GetAddr()) {
                    return true;
                }
            }
            return false;
        }
    }
}