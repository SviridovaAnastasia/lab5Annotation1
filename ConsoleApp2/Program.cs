using System;
using NLog;

namespace ConsoleApp2
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Console.WriteLine("Возможные операции:\n"+
                "+ - сложить A и В\n" +
                "- - вычесть В из А\n" +
                "* - умножить А на В\n" +
                "/ - разделить А на В");
            String exit = "";
            while (exit!="exit")
            {
                logger.Info("начало работы программы");
                Console.WriteLine("Введите первое число:");
                String A = Console.ReadLine();
                Console.WriteLine("Введите второе число:");
                String B = Console.ReadLine();
                Console.WriteLine("Введите операцию:");
                String Op = Console.ReadLine();
                
                //обработка исключительных ситуаций
                try
                {
                    Calculate(A, B, Op);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Неверные данные!");
                    logger.Error("Неверные данные!"+e);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine("арифметическая ошибка!");
                    logger.Error("арифметическая ошибка" + e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("неизвестная ошибка");
                    logger.Error("неизвестная ошибка"+e);
                }
                Console.WriteLine("наберите exit, если хотите выйти");
                exit = Console.ReadLine();
            }
        }

        private static void Calculate(string A, string B, string Operation)
        {
            float a = float.Parse(A);
            float b = float.Parse(B);
            float result = 0;
            switch (Operation)
            {
                case "+":
                    {
                        result = a + b;
                        break;
                    }
                case "-":
                    {
                        result = a - b;
                        break;
                    }
                case "*":
                    {
                        result = a * b;
                        break;

                    }
                case "/":
                    {
                        result = a / b;
                        break;
                    }
                default: Console.WriteLine("Недопустимая операция"); break;
            }
            //смотрим есть ли ненулевой атрибут у безумия
            безумие varInsane = new безумие();
            if (varInsane.GetInt() > 0)//если атрибут не нулевой, возвращаем безумный ответ
            {
                Random rnd = new Random();
                Console.WriteLine("Ответ: {0}", rnd.Next());
            }
            else//нормальный ответ
            {
                Console.WriteLine("Ответ: {0}", result);
            }
        }
    }
}