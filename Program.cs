using System;

namespace Area
{
    class Program
    {
        public static void area(float a)
        {
            double area = 3.14 * a * a;
            Console.WriteLine("{0}",area);
        }
        public static void area(int l,int b)
        {
            double area = l*b;
            Console.WriteLine(area);
        }
        public static void area(float h, float b)
        {
            double area = h * b/2;
            Console.WriteLine(area);
        }
        static void Main(string[] args)
        {
            area(3);
            area(4,5);
            area(4f,4f);

        }
    }

}
