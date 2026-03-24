using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ? n = null;
            int ternary =(n==null)? 0:n.Value;
            int nullco = n ?? 0;
            Console.WriteLine("nonnullable by ternary {0} and by null coelscing  {1}", ternary,nullco);
        }
    }
}
