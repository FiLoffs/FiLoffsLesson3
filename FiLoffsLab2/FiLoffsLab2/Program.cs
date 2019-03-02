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
            task9();
            tas11();
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
                //Console.WriteLine($ "Площадь кольца = {result.ToString("N01")} кв.см");

            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();

        }

        public static void task9()
        {
            Console.WriteLine("В каком году была основана Одесса?");
            //s = PI * r в квадрате
            int date;

            //как сделать проверку, чтобы вводимое значение было числом?
            //Как сделать паузу между выводимыми сообщениями в консоль?

            Console.WriteLine("Введите число и нажмите <Enter>");
            date = Convert.ToInt16(Console.ReadLine());

            if (date == 1794)
            {
                Console.WriteLine("Вы правы, Одесса была основана в 1794 году");
            }
            else
            {
                Console.WriteLine("Вы ошиблись, Одесса была основана в 1794 году");
            }

            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();

        }

        public static void tas11()
        {
            Console.WriteLine("В каком году была основана Одесса?");
            //s = PI * r в квадрате
            byte num;

            //как сделать проверку, чтобы вводимое значение было числом?
            //Как сделать паузу между выводимыми сообщениями в консоль?

            Console.WriteLine("Архитектор Исаакиевского собора:");
            Console.WriteLine("   " + "1. Доменико Трезини");
            Console.WriteLine("   " + "2. Огюст Монферран");
            Console.WriteLine("   " + "3. Карл Росси");
            Console.WriteLine("Введите номер правильного ответа и нажмите <Enter>");

            num = Convert.ToByte(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Вы ошиблись. Архитектор Исаакиевского собора Огюст Монферран");
                    break;
                case 2:
                    Console.WriteLine("Вы совершено правы! Архитектор Исаакиевского собора Огюст Монферран");
                    break;
                case 3:
                    Console.WriteLine("Вы ошиблись. Архитектор Исаакиевского собора Огюст Монферран");
                    break;
                default:
                    Console.WriteLine("Вы ошиблись в выборе номера ответа.");
                    break;
            }
            
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine();


        }

    }
}
