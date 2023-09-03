using System;
using System.Text;

namespace Game_Programming_Activities
{
    class Exercise_06
    {
        static void Main(string[] args)
        {
            print("Dela Peña, Joshua Ver S. \n2BSEMC-GD-1");

            int n;
            print ("\n\nEnter a number: ");
            n = returnInt();
            displaySqrt(n);
        }
        static void displaySqrt(int n)
        {
            Console.WriteLine("The power of {0} is {1} ", n, Math.Sqrt(n));
        }
        static int returnInt()
        { 
            return Convert.ToInt32(Console.ReadLine());
        }
        static void print(string x)
        {
            Console.Write(x);
        }
    }
}