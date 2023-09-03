using System;
using System.Text;

namespace AreaOfTriangle
{
    class Exercise_07
    {
        static void Main(string[] args)
        {
            print("Dela Peña, Joshua Ver S. \n2BSEMC-GD-1");
            double b;
            double h;

            print("\n\nInput Base in meter(s): ");
            b = ins();
            print ("\nInput Height in meter(s): ");
            h = ins();
            triangleArea(h,b);
        }

        static void triangleArea(double b, double h)
        {
            double area = 0.5 * (b * h);

            Console.WriteLine(
                "\nFormula...\n" + "Area = 1/2 * (Base)(Height)\n" + "Area = 1/2 * ({0})({1})\n" 
                +"Area = 1/2 * {2}\n" + "Area = {3}m", b, h, b*h, 0.5 * (b*h));
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