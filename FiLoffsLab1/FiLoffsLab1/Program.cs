using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiLoffsFormula1
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task5();
            task7();
            task13();
            task16();
        }

        public static void task1()
        {
            double a, b, c, result;
            //RandomVar(a,b,c);
            Random x = new Random();
            a = Convert.ToDouble(x.Next(100));
            b = Convert.ToDouble(x.Next(100));
            c = Convert.ToDouble(x.Next(100));

            result = (b + Math.Sqrt(b * b + 4 * a * c)) / 2 * a - Math.Pow(a, 3) * c + Math.Pow(b, -2);
            Console.WriteLine("task 1");
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            Console.WriteLine("result = " + result);
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task2()
        {
            double a, b, c, d, result;
            //RandomVar(a,b,c);
            Random x = new Random();
            a = Convert.ToDouble(x.Next(100));
            b = Convert.ToDouble(x.Next(100));
            c = Convert.ToDouble(x.Next(100));
            d = Convert.ToDouble(x.Next(100));

            result = (a / c * b / d) - ((a * b - c) / c / d);
            Console.WriteLine("task 2");
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c + ", d = " + d);
            Console.WriteLine("result = " + result);
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task3()
        {
            double x, y, result;
            //RandomVar(a,b,c);
            Random r = new Random();
            x = Convert.ToDouble(r.Next(360));
            y = Convert.ToDouble(r.Next(360));

            result = Math.Tan((Math.Sin(x) + Math.Cos(y)) / ((Math.Sin(x) - Math.Cos(y))) * x * y);
            Console.WriteLine("task 3");
            Console.WriteLine("x = " + x + ", y = " + y);
            Console.WriteLine("result = " + result);
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task5()
        {
            double x, y, e, result;
            //RandomVar(a,b,c);
            Random r = new Random();
            x = Convert.ToDouble(r.Next(100));
            y = Convert.ToDouble(r.Next(100));
            e = Convert.ToDouble(r.Next(100));

            result = (3 + Math.Pow(e, y - 1)) / (1 + x * x * Math.Abs(y - Math.Tan(x)));
            Console.WriteLine("task 5");
            Console.WriteLine("x = " + x + ", y = " + y + ", e = " + e);
            Console.WriteLine("result = " + result);
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task7()
        {
            double x, y, result;
            //RandomVar(a,b,c);
            Random r = new Random();
            x = Convert.ToDouble(r.Next(100));
            y = Convert.ToDouble(r.Next(100));

            result = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - y / (x + x * x / 4))));
            Console.WriteLine("task 7");
            Console.WriteLine("x = " + x + ", y = " + y);
            Console.WriteLine("result = " + result);
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task13()
        {
            double x, y, result;
            //RandomVar(a,b,c);
            Random r = new Random();
            x = Convert.ToDouble(r.Next(100));
            y = Convert.ToDouble(r.Next(100));

            result = Math.Cos(x) / (Math.PI - 2 * x) + 16 * x * Math.Cos(x * y) - 2;
            Console.WriteLine("task 13");
            Console.WriteLine("x = " + x + ", y = " + y);
            Console.WriteLine("result = " + result);
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task16()
        {
            double x, result;
            //RandomVar(a,b,c);
            Random r = new Random();
            x = Convert.ToDouble(r.Next(100));

            result = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - 7 * x / (Math.Pow(x, 3) - 15 * x);
            Console.WriteLine("task 16");
            Console.WriteLine("x = " + x);
            Console.WriteLine("result = " + result);
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }


    }
}
