using System;
using System.Text;

namespace OddOrEven
{
    class Exercise_05
    {
        static void Main(string[] args)
        {
            print("Dela Peña, Joshua Ver S. \n2BSEMC-GD-1");
            int i;
            print ("\n\nInput Number: ");
            i = ins();

            if (i % 2 == 0)
            {
                print("Even");
            }
            else 
            {
                print("Odd");
            } 
               
        }

        static int ins()
        {
            return Convert.ToInt32(Console.ReadLine());
        }


        static void print(string x)
        {
            Console.WriteLine(x);
        }
    }

}