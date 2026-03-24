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
            var v = 5; //implicit type value while creating we need to assign the value now the v changed into int type automatically
            dynamic d;
            d = 'a'; //one of the implicit type but we can declare AND Initiated at different , not prefered to use , the type remains as a dynamic 
            Console.WriteLine(" the var is {0} and dynamic is {1}", v, d);
            int[] arr ={1 ,2,3,4,5,6};
            parameterdarray(arr);
            parameterdarray();
            parameterdarray(1,2,3,4,5,6);
            int[] arr2 = new int[3];
            arr2[0] = 0;
            arr2[1] = 1;
            arr2[2] = 2;
            parameterdarray(arr2);
            Console.ReadLine();

        }
        static void parameterdarray(params int[] elements)
        {
            foreach (int i in elements)
            {
                Console.WriteLine(i);
            }
        }
    }
}
