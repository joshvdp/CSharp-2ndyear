using System;
using System.Text;

namespace Game_Programming_Activities
{
    class Exercise_03
    {
        static void Main(string[] args)
        {
            print("Dela Peña, Joshua Ver S. \n2BSEMC-GD-1");
            
            int a;
            int b; 
            int res;

            print ("\n\nInput a: ");
            a = Convert.ToInt32(Console.ReadLine());

            print ("\nInput b: ");
            b = Convert.ToInt32(Console.ReadLine());
            res = (a + b)*(a + b);

            print("\nResult = " + res);

        }
        static void print(String x)
        {
            Console.Write(x);
        }
    }

}