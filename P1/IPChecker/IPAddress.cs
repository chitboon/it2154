using System;
using System.Net;

namespace IPChecker
{
    public class IPAddress
    {
        private Int64 addr_i64 = 0;
        public IPAddress(string addr)
        {
            this.addr_i64 = IPAddressToInt64(addr);
        }

        public Int64 GetAddr() { return this.addr_i64; }

        public static long IPAddressToInt64(string ip)
        {
            return (long)(uint)System.Net.IPAddress.NetworkToHostOrder(BitConverter.ToInt32(System.Net.IPAddress.Parse(ip).GetAddressBytes(), 0));

        }

        public static string IPAddressFromInt64(long ip)
        {
            return System.Net.IPAddress.Parse(ip.ToString()).ToString();
        }
    }
}