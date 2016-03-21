using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_pi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Machine: {0}, OS: {1}, Processors: {2}", Environment.GetEnvironmentVariable("COMPUTERNAME"), Environment.GetEnvironmentVariable("OS"), Environment.ProcessorCount);
            Console.Read();
        }
    }
}
