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
            /*print();
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
            Console.WriteLine("Non static method in same class");*/
            int n = 10;
            callbyvalue(n);
            Console.WriteLine("the n value after call by value:" + n);
            int m = 10;
            callbyref( ref m);
            Console.WriteLine("the m value after call by reference:" +m);
            Console.ReadLine();

        }
        static void callbyvalue(int k)
        {
         k=5000;
        }
        static void callbyref(ref int  k)
        {
            k = 5000;
        }
    }
}
