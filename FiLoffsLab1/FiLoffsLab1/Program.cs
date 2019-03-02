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
            int a, b, c;
            double result;
            a = -1;
            b = 4;
            c = 4;
            Console.WriteLine("task 1");
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);

            if (a!=0)
            {
                result = (b + Math.Sqrt(b * b + 4 * a * c)) / 2 * a - Math.Pow(a, 3) * c + Math.Pow(b, -2);
                Console.WriteLine("result = " + result);
            }
            else
            {
                Console.WriteLine("no solutions");                
            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();

        }

        public static void task2()
        {
            double a, b, c, d, result;
            a = 4;
            b = 3;
            c = 2;
            d = 8;
            Console.WriteLine("task 2");
            //c = 0;
            //d = 0;
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c + ", d = " + d);

            if (c==0 || d==0)
            {                
                Console.WriteLine("no solutions");
            }
            else
            {
                result = (a / c * b / d) - ((a * b - c) / c / d);
                Console.WriteLine("result = " + result);
            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task3()
        {
            double x, y, result;
            Random r = new Random();
            x = Convert.ToDouble(r.Next(360));
            y = Convert.ToDouble(r.Next(360));
            Console.WriteLine("task 3");
            //x = 90;
            //y = 0;
            Console.WriteLine("x = " + x + ", y = " + y);

            if ((Math.Sin(x) - Math.Cos(y))==0 || Math.Tan(x * y)==0)
            {                
                Console.WriteLine("no solutions");
            }
            else
            {
                result = (Math.Sin(x) + Math.Cos(y)) / (Math.Sin(x) - Math.Cos(y)) * Math.Tan(x * y);                
                Console.WriteLine("result = " + result);
            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task5()
        {
            double x, y, e, result;
            Random r = new Random();
            x = Convert.ToDouble(r.Next(100));
            y = Convert.ToDouble(r.Next(100));
            e = Convert.ToDouble(r.Next(100));
            Console.WriteLine("task 5");

            result = (3 + Math.Pow(e, y - 1)) / (1 + x * x * Math.Abs(y - Math.Tan(x)));            
            Console.WriteLine("x = " + x + ", y = " + y + ", e = " + e);
            Console.WriteLine("result = " + result);

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task7()
        {
            double x, y, result;
            Random r = new Random();
            x = Convert.ToDouble(r.Next(100));
            y = Convert.ToDouble(r.Next(100));
            Console.WriteLine("task 7");
            Console.WriteLine("x = " + x + ", y = " + y);

            if ((x + x * x / 4)==0 || (y - Math.Sqrt(Math.Abs(x)))==0 || (x - y / (x + x * x / 4))==0)
            {
                Console.WriteLine("no solutions");
            }
            else
            {                
                result = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - y / (x + x * x / 4)))) / 0.4342944819;
                Console.WriteLine("result = " + result);
            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task13()
        {
            int x, y;
            double result;

            //Random r = new Random();
            //x = r.Next(360);
            //y = r.Next(360);
            Console.WriteLine("task 13");
            x = 90;
            y = 1;

            Console.WriteLine("x = " + x + ", y = " + y);

            if (2*x == Math.PI || Math.Cos(x) == 0)
            {
                Console.WriteLine("no solutions");
            }
            else
            {
                result = Math.Cos(x) / (Math.PI - 2 * x) + 16 * x * Math.Cos(x * y) - 2;
                Console.WriteLine("result = " + result);                
            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }

        public static void task16()
        {
            double x, result;
            Random r = new Random();
            x = Convert.ToDouble(r.Next(100));
            Console.WriteLine("task 16");

            Console.WriteLine("x = " + x);

            if ((Math.Pow(x, 3) - 15 * x) == 0)
            {
                Console.WriteLine("no solutions");
            }
            else
            {
                result = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - 7 * x / (Math.Pow(x, 3) - 15 * x);
                Console.WriteLine("result = " + result);
            }            

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();
        }


    }
}
