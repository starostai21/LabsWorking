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
            while (true)
            {
                Console.Write("Input Nomer: ");
                string InputNomer = Console.ReadLine();
                if (InputNomer.Length == 0)
                    break;


                char[] GosNomerSimb = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'O', 'P', 'T', 'X', 'Y' };
                if (InputNomer.Length == 6)
                {
                    var ValidNumber = true;
                    for (int i = 0; i < 6 & ValidNumber; i++)
                    {
                        if (i == 1 | i == 2 | i == 3)
                            ValidNumber &= Char.IsDigit(InputNomer[i]);
                        else

                            ValidNumber &= (InputNomer[i].ToString().IndexOfAny(GosNomerSimb) >= 0);
                    }
                    Console.Write(ValidNumber ? "номер правильный\n" : "номер не правильный\n");
                }
                else
                {
                    Console.Write("пошли нафиг\n");
                    
                }
            }*/
            Console.Write("Введите последовательность: ");
            string Posledovatelnost = Console.ReadLine();
            char[] Strelka1 = { '>', '<', '-' };
            if (Posledovatelnost == Strelka1[0] &  )
            Console.Write("\nPress ENTER to continue...");
            Console.ReadLine();
         }
    }
 }
 
    