// подключены какие-то библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace такой же как и название проекта
namespace oapLabaSmirnov
{
    // про классы мы пока не говорили...
    class Program
    {
         // точка входа в программу
         static void Main(string[] args)
        {/*
            Console.Write("Input number1: ");
            var number1 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Input number2: ");
            var number2 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Input number3: ");
            var number3 = Convert.ToDouble( Console.ReadLine() );

            if (number1 >= 0)
            {
                number1 = Math.Pow(number1, 2);
            }
            else 
            {
                number1 = Math.Pow(number1, 4);
            }

            if (number2 >= 0)
            {
                number2 = Math.Pow(number2, 2);
            }
            else 
            {
                number2 = Math.Pow(number2, 4);
            }


            number3 = (number3 >= 0) ? Math.Pow(number3, 2) : швMath.Pow(number3, 4);

            if (number3 >= 0)
            {
                number3 = Math.Pow(number3, 2);
            }
            else
            {
                number3 = Math.Pow(number3, 4);
            }
            Console.WriteLine($"number1 = {number1}");
            Console.WriteLine($"number2 = {number2}");
            Console.WriteLine($"number3 = {number3}");
            
            */
            /*
            Console.Write("Input X1: ");
            var X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Y1: ");
            var Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input X2: ");
            var X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Y2: ");
            var Y2 = Convert.ToDouble(Console.ReadLine());
            var Dlina1 = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
            var Dlina2 = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
            if (Dlina1 < Dlina2)
            {
                Console.WriteLine("первaя точка ближе");
            }
            else
            {
                Console.WriteLine("вторая точка ближе");
            }
           */
            /*
            Console.Write("Input Ugol1: ");
            var Ugol1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Ugol2: ");
            var Ugol2 = Convert.ToDouble(Console.ReadLine());
            if((Ugol1 + Ugol2)<180)
            {
                Console.WriteLine("треугольник существует");
                if(Ugol1 == 90 || Ugol2 == 90 || Ugol2 + Ugol1 == 90)
                {
                    Console.WriteLine("треугольник прямоугольный");
                }
                else Console.WriteLine("треугольник не прямоугольный");
            }
            else
            {
                Console.WriteLine("треугольник не существует");
            }
            */
            /*
            Console.Write("Number1: ");
            var Number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number2: ");
            var Number2 = Convert.ToDouble(Console.ReadLine());
            var PoluSumma = (Number1 + Number2) / 2;
            var Proizvedenie = 2 * (Number1 * Number2);
            if (Number1 < Number2)
            {
                Number1 = PoluSumma;
                Number2 = Proizvedenie;
            }
            else
            {
                Number2 = PoluSumma;
                Number1 = Proizvedenie;
            }
            Console.WriteLine($"number1 = {Number1}");
            Console.WriteLine($"number2 = {Number2}");
            */
            Console.Write("Input X: ");
            var X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Y: ");
            var Y = Convert.ToDouble(Console.ReadLine());
            if(X == 0)
            {
                if (Y==0)
                    Console.WriteLine("является началом координат");
                else 
                Console.WriteLine("пренадлежит оси Y");

            }
            else
            {
                if(X > 0 && Y > 0)
                {
                    Console.WriteLine("пренадлежит первой четверти");
                }
                else if (X > 0 && Y < 0)
                { 
                    Console.WriteLine("пренадлежит четвертой четверти"); 
                }
             if (Y == 0)
                {
                    Console.WriteLine("пренадлежит оси X");
                }
             else
                {
                    if (X < 0 && Y > 0)
                    {
                        Console.WriteLine("пренадлежит второй четверти");
                    }
                    else if (X < 0 && Y < 0)
                    {
                        Console.WriteLine("пренадлежит третей четверти");
                    }
            
                }
            }
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }
 }
    }

            