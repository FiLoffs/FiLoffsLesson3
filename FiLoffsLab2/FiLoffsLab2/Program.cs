using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiLoffsLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            task2();
        }

        //public static void task1()
        //{
        //    Console.WriteLine("Вычисление частного");
        //    int a, b;
        //    double result;

        //    Console.WriteLine("Введите в одной строке делимое и делитель, затем нажмите <Enter>");
        //    //int[] chastnoe = Convert.ToInt32[] (Console.ReadLine());
        //    Console.WriteLine("a = " + a + ", b = " + b);

        //    if (b == 0)
        //    {
        //        Console.WriteLine("Вы ошиблись. Делитель не должен быть равен нулю.");
        //    }
        //    else
        //    {
        //        result = a / b;
        //        Console.WriteLine("result = " + result);
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("================");
        //    Console.WriteLine();

        //}

        public static void task2()
        {
            Console.WriteLine("Вычисление площади кольца");
            //s = PI * r в квадрате
            double r1, r2;
            double result;

            Console.WriteLine("Введите исходные данные:");

            //как сделать проверку, чтобы вводимое значение было числом?
            //Как сделать паузу между выводимыми сообщениями в консоль?

            Console.WriteLine("Радиус кольца, (см)");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Радиус отверстия, (см)");
            r2 = Convert.ToDouble(Console.ReadLine());
            //int[] chastnoe = Convert.ToInt32[] (Console.ReadLine());
            Console.WriteLine("Радиус кольца = " + r1 + ", Радиус отверстия = " + r2);


            if (r1 < r2)
            {
                Console.WriteLine("Ошибка! Радиус отверстия не может быть больше радиуса кольца");
            }
            else if(r1 == r2)
            {
                Console.WriteLine("Ошибка! Радиус отверстия не может быть равен радиусу кольца");
            }
            else
            {
                result = Math.PI * Math.Pow(r1, 2) - Math.PI * Math.Pow(r2, 2);
                Console.WriteLine("Площадь кольца = " + result + " кв.см");
                Console.WriteLine("Площадь кольца = " + result.ToString("N01") + " кв.см");
            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();

        }


    }
}
