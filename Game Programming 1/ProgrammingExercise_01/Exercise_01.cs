using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Programming_Activities
{
    class Exercise_01
    {
        static int houseno;
        static int pin;
        static string name;
        static string city;
        static string street;
        static void Main(string[] args)
        {
            print("DELA PEÑA, JOSHUA VER S. \n2BSEMC-GD1 \nPROGRAMMING EXERCISES 1");
            input();
        }
        static void input()
        {
            print("\n\nInput your Mailing Details Below: ");

            print("\nName: ");
            name = scan();

            print("\nCity: ");
            city = scan();

            print("\nStreet");
            street = scan();

            print("\nPIN: ");
            pin = scanInt();

            print("\nHousing No.: ");
            houseno = scanInt();

            output();
        }
        static void output()
        {
            print("\n----------Your Mailing Details------------\n");

            print("\nName: " + name);

            print("\nCity: " + city);

            print("\nStreet: " + street);

            print("\nPIN: " + pin);

            print("\nHousing No.: " + houseno);

        }
        static void print(String x)
        {
            Console.WriteLine(x);
        }
        static string scan()
        {
            return Console.ReadLine();
        }
        static int scanInt()
        {
            return Int32.Parse(Console.ReadLine());
        }
    }
}

