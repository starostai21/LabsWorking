// подключены какие-то библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace такой же как и название проекта
namespace oapLabaBati
{
    // про классы мы пока не говорили...
    class Program
    {
        // точка входа в программу
        static void Main(string[] args)
        {
            /*
            Console.Write("Input number1: ");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number2: ");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number3: ");
            var number3 = Convert.ToDouble(Console.ReadLine());

            if (number1 > number2 && number1 > number3 && number2 < number3)
            {
            var summa = number1 + number2;
            Console.WriteLine($"summa = {summa}");
            //тут складываем один и второе//
            }
            else if (number1 > number2 && number1 > number3 && number2 > number3)
            // буду складывать первое и третье
            {
            var summa = number1 + number3;
            Console.WriteLine($"summa = {summa}");
            }
            else if (number2 > number1 && number2 > number3 && number1 < number3)
            //складывает второе и первое
            {
            var summa = number2 + number1;
            Console.WriteLine($"summa = {summa}");
            }
            else if (number2 > number1 && number2 > number3 && number1 > number3)
            //Тут складывать второе и третье
            {
            var summa = number2 + number3;
            Console.WriteLine($"summa = {summa}");
            }
            else if (number3 > number1 && number3 > number2 && number1 < number2)
            //тут складываем третье и первое)
            {
            var summa = number3 + number1;
            Console.WriteLine($"summa = {summa}");
            }
            else if (number3 > number1 && number3 > number2 && number1 > number2)
            //тут складывать третье и второе
            {
            var summa = number3 + number2;
            Console.WriteLine($"summa = {summa}");
            }
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
            */
            /*
            Console.Write("Input XD: ");
            var 😆 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input YD: ");
            var YD = Convert.ToDouble(Console.ReadLine());
            var XA = 9;
            var YA = 12;
            var XB = 14;
            var YB = 3;
            var XC = -5;
            var YC = 1;
            var AB = Math.Pow((XA - XB), 2) + Math.Pow((YA - YB), 2);
            var AC = Math.Pow((XA - XC), 2) + Math.Pow((YA - YC), 2);
            var BC = Math.Pow((XC - XB), 2) + Math.Pow((YC - YB), 2);
            var PoluPerimetrABC = (AB + AC + BC) / 2;
            var PloshadABC = Math.Sqrt(PoluPerimetrABC * (PoluPerimetrABC - AB) * (PoluPerimetrABC - AC) * (PoluPerimetrABC - BC));
            var AD = Math.Pow((XA - XD), 2) + Math.Pow((YA - YD), 2);
            var BD = Math.Pow((XB - XD), 2) + Math.Pow((YB - YD), 2);
            var CD = Math.Pow((XC - XD), 2) + Math.Pow((YC - YD), 2);
            var PoluPerimetrADC = (AC + AD + CD) / 2;
            var PloshadADC = Math.Sqrt(PoluPerimetrADC * (PoluPerimetrADC - AC) * (PoluPerimetrADC - AD) * (PoluPerimetrADC - CD));
            var PoluPerimetrABD = (AB + BD + AD) / 2;
            var PloshadABD = Math.Sqrt(PoluPerimetrABD * (PoluPerimetrABD - AB) * (PoluPerimetrABD - AD) * (PoluPerimetrABD - BD));
            var PoluPerimetrBDC = (CD + BD + BC) / 2;
            var PloshadBDC = Math.Sqrt(PoluPerimetrBDC * (PoluPerimetrBDC - CD) * (PoluPerimetrBDC - BD) * (PoluPerimetrBDC - BC));
            var SummaPloshad = PloshadBDC + PloshadABD + PloshadADC;
            if (PloshadABC > SummaPloshad)
            {
            Console.WriteLine("Точка принадлежит треугольнику");
            }
            else
            {
            Console.WriteLine("Точка не принадлежит треугольнику");
            }
            */
            /*
            Console.Write("Input X: ");
            var X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Y: ");
            var Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Radius: ");
            var Radius = Convert.ToDouble(Console.ReadLine());
            var DlinaDoTochki = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            if (Radius > DlinaDoTochki || Radius == DlinaDoTochki)
            {
            Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
            Console.WriteLine("Точка не принадлежит окружности");
            }

            */

            Console.Write("Input Storona1: ");
            var Storona1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Storona2: ");
            var Storona2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Storona3: ");
            var Storona3 =

            Convert.ToDouble(Console.ReadLine());

            if ((Storona1 + Storona2 < Storona3 || Storona1 + Storona3 < Storona2 || Storona2 + Storona3 < Storona1))
            {

                if (Storona1 > Storona2 && Storona1 > Storona3)
                {
                    var BStorona = Storona1;
                    if (Math.Pow(BStorona, 2) == Math.Pow(Storona2, 2) + Math.Pow(Storona3, 2))
                    {
                        Console.WriteLine("Треугольник существует и он прямоугольный");
                    }
                    else
                    {
                        if (Math.Pow(BStorona, 2) > Math.Pow(Storona2, 2) + Math.Pow(Storona3, 2))
                        {
                            Console.WriteLine("Треугольник существует и он тупоугольный");
                        }
                        else
                        {
                            if (Math.Pow(BStorona, 2) < Math.Pow(Storona2, 2) + Math.Pow(Storona3, 2))
                            {
                                Console.WriteLine("Треугольник существует и он остроугольный");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник не существует");
                            }
                        }
                    }
                }
                else if (Storona2 > Storona1 && Storona2 > Storona3)
                {
                    var BStorona = Storona2;
                    if (Math.Pow(BStorona, 2) == Math.Pow(Storona1, 2) + Math.Pow(Storona3, 2))
                    {
                        Console.WriteLine("Треугольник существует и он прямоугольный");
                    }
                    else
                    {
                        if (Math.Pow(BStorona, 2) > Math.Pow(Storona1, 2) + Math.Pow(Storona3, 2))
                        {
                            Console.WriteLine("Треугольник существует и он тупоугольный");
                        }
                        else
                        {
                            if (Math.Pow(BStorona, 2) < Math.Pow(Storona1, 2) + Math.Pow(Storona3, 2))
                            {
                                Console.WriteLine("Треугольник существует и он остроугольный");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник не существует");
                            }
                        }
                    }
                }
                else if (Storona3 > Storona2 && Storona3 > Storona1)
                {
                    var BStorona = Storona3;
                    if (Math.Pow(BStorona, 2) == Math.Pow(Storona2, 2) + Math.Pow(Storona1, 2))
                    {
                        Console.WriteLine("Треугольник существует и он прямоугольный");
                    }
                    else
                    {
                        if (Math.Pow(BStorona, 2) > Math.Pow(Storona2, 2) + Math.Pow(Storona1, 2))
                        {
                            Console.WriteLine("Треугольник существует и он тупоугольный");
                        }
                        else
                        {
                            if (Math.Pow(BStorona, 2) < Math.Pow(Storona2, 2) + Math.Pow(Storona1, 2))
                            {
                                Console.WriteLine("Треугольник существует и он остроугольный");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник не существует");
                            }
                        }
                    }
                }
            }
            else if ((Storona1 + Storona2 > Storona3 || Storona1 + Storona3 > Storona2 || Storona2 + Storona3 > Storona1))
            {
                Console.WriteLine("Треугольник не существует");
            }

            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
