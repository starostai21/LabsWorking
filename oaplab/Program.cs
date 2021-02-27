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
            Console.Write("Введите год XXI века: ");
            int God1 = Convert.ToInt32(Console.ReadLine());
            if (God1 >= 2001 & God1 < 2101)
            {
                //будут вычесления
                for(int i = 1901; i < 2001; i++)
                {
                    int age = God1 - i;
                    CheckYear(i, age);
                }
            }
            else
            {
                Console.Write("Год не XXI века: ");
            }
            Console.ReadKey();
        }
        static void CheckYear(int Year, int Age)
        {
            var StartDateTime = new DateTime(Year, 1, 1);
            do
            {
                if (ValidDate(StartDateTime, Age))
                    Console.WriteLine(StartDateTime);
                StartDateTime = StartDateTime.AddDays(1);


            } while (StartDateTime.Year==Year);


            
        }

        static bool ValidDate(DateTime CheckedDate, int Age)
        {
            var YearSqr = 0;
            var CurentYear = CheckedDate.Year;
            while (CurentYear > 0)
            {
                var LastDiget = CurentYear % 10;
                YearSqr += (int)Math.Pow(LastDiget , 2 );
                CurentYear =(int) Math.Ceiling((double)( CurentYear / 10));

            }
            return (YearSqr - (int)Math.Pow(CheckedDate.Day, 2)) == Age;

                    }

    }
 }
 
    