using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int n = 125;
            Console.WriteLine(n);
            float f = n;
            Console.WriteLine(f);
            n = (int)f;
            Console.WriteLine(n);
            n = Convert.ToInt32(f);
            Console.WriteLine(n);*/
            print();
            Program program = new Program();
            program.display();
            Console.Read();
        }
        static void print()
        {
            Console.WriteLine(" HELLO VP");
        }
         public void display()
        {
            Console.WriteLine("Non static method in same class");
        }
    }
}
