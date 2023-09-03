using System;

namespace Game_Programming_Activities
{
    class Exercise_02
    {
        static string name;
        static string univName;
        static int studNo;
        static int age;
        static int classOf;
        static string[] txt = { "DELA PEÑA, JOSHUA VER S. \n2BSEMC-GD-1","\n\nEnter Details Below: ", "\n-----------Student Information------------\n" };
        static string[] draw = { "\n\nName: ", "\nStudent No.: ", "\nAge: ", "\nClass: ", "\nUniversity Name: " };
        static void Main(string[] args)
        {
            print(txt[0]);
            print(txt[1]);
            input();
        }
        static void input()
        {
            print(draw[0]);
            name = scan();

            print(draw[1]);
            studNo = scanInt();

            print(draw[2]);
            age = scanInt();

            print(draw[3]);
            classOf = scanInt();

            print(draw[4]);
            univName = scan();

            output();
        }
        static void output()
        {
            print(txt[2]);

            print("\nName: " + name);

            print("\nStudent No.: " + studNo);

            print("\nAge: " + age);

            print("\nClass of: " + classOf);

            print("\nName of University: " + univName);
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
