using System;
using System.Collections.Generic;
using System.IO;

namespace IPChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: IPChecker <rulefile> <ip_file> <output_file>");
            }
            else
            {
                string rule_file = args[0];
                string ip_file = args[1];
                string output_file = args[2];

                var rules = new List<IPRule>();

                using (StreamReader sr = File.OpenText(rule_file))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.Contains("-")) {
                            IPRange range = new IPRange(s);
                            rules.Add(range);
                        } else {
                            IPList list = new IPList(s);
                            rules.Add(list);
                        }
                    }
                }

                using (StreamReader sr = File.OpenText(ip_file)) {
                    using (StreamWriter sw = File.CreateText(output_file)) {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            IPAddress ip = new IPAddress(s);
                            int counter = 0;
                            bool found = false;
                            foreach (var rule in rules) {
                                if (rule.Contains(ip)) {
                                    found = true;
                                    break;
                                }
                                counter = counter + 1;
                            }
                            if (found) {
                                sw.WriteLine($"{s},{counter}");
                            } else {
                                sw.WriteLine($"{s},{-1}");
                            }
                        } 
                    }
                }
            }
        }
    }
}