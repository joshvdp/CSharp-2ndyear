using System;
using System.Text;

namespace AreaOfCircle
{
    class Exercise_04
    {
        static void Main(string[] args)
        {
            print("Dela Peña, Joshua Ver S.\n2BSEMC-GD-1");

            double rad;
            print ("\n\nInsert Radius: ");
            rad = ins();
            print("\n");
            initialize (rad);
            
            Console.Read();
        }

        static void initialize (double rad)
        {
            Console.WriteLine(
                "Solution...\n" +
                "area = πr2\n" +
                "area = π * ({0} * {0})\n" +
                "area = π{1}\n" +
                "area = {2}"
                , rad, rad * rad, Math.PI * (rad * rad));
        }


        static double ins()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static void print(string x)
        {
            Console.Write(x);
        }
    }

}