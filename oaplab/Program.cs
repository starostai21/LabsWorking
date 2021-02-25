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
            var MassivDate = new List<DateTime>() { 
                new DateTime(2021, 1, 15), 
                new DateTime(2021, 2, 20),
                new DateTime(2011, 5, 2),
                new DateTime(2015, 5, 1),
                new DateTime(2013, 5, 3),
                new DateTime(2020, 1, 17)};
            var result = new Dictionary<int, int>();
            foreach(DateTime TekushayaData in MassivDate)
            {
                if (result.ContainsKey(TekushayaData.Month))
                {
                    result[TekushayaData.Month] = result[TekushayaData.Month] + 1;
                }
                else
                    result[TekushayaData.Month] = 1;
            }
            var PopularMonth = -1;
            var MaxCount = 0;
            foreach (KeyValuePair<int,int> keyValue in result)
            {
                if(keyValue.Value > MaxCount)
                {
                    MaxCount = keyValue.Value;
                    PopularMonth = keyValue.Key;
                }
            }
            Console.WriteLine($"Самый популярный месяц {PopularMonth}");
            */
            /*
            Console.WriteLine("Input posledovatelnost: ");
            string Posledovatelnost = Console.ReadLine();
            var StrelkaCoint = 0;
            var strelka1 = ">>-->";
            var strelka2 = "<--<<";
            int poz = 0;
            while((poz = Posledovatelnost.IndexOf(strelka1, poz))>=0)
            {
                StrelkaCoint++;
                poz++;
            }
            poz = 0;
            while ((poz = Posledovatelnost.IndexOf(strelka2, poz)) >= 0)
            {
                StrelkaCoint++;
                poz++;
            }
            Console.WriteLine($"Количество стрелок: {StrelkaCoint}");
            */
            /*

            DateTime date1 = new DateTime(2021, 02, 21);
            DateTime date2 = new DateTime(2026, 02, 25);
            Console.WriteLine(Math.Abs(date1.Subtract(date2).TotalDays));
            */
            /*
            Console.WriteLine("Введите год: ");
            DateTime date1 = new DateTime(Convert.ToInt32(Console.ReadLine()), 1, 1);
            date1 = date1.AddDays(255);
            var DateString = date1.ToString("dd MMMM");
            Console.WriteLine($"день программиста отмечается  {DateString}");
            */
            /*
            Console.WriteLine("Введите день: ");
            DateTime date1 = new DateTime(2021, 1, 1);
            date1 = date1.AddDays(Convert.ToInt32(Console.ReadLine())-1);
            var DateString = date1.ToString("dddd");
            var voskresenie = date1.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)date1.DayOfWeek;
            Console.WriteLine($"день недели {DateString}, и номер дня недели {voskresenie}");
            */
            DateTime date1 = new DateTime(2021, 06, 21);
            Console.WriteLine("Введите дату в формате дд.мм.гггг: ");
            string date2 = Console.ReadLine();
            string[] StringArray = date2.Split('.');
            var Date3 = new DateTime(Convert.ToInt32(StringArray[2]), Convert.ToInt32(StringArray[1]), Convert.ToInt32(StringArray[0]));
            var Raznitca = date1.Subtract(Date3);
            if (Raznitca.TotalDays == 0)
            {
                Console.WriteLine("Сегодня экзамен");
            }
            else if (Raznitca.TotalDays > 0)
                Console.WriteLine($"Экзамен будет через {Raznitca.TotalDays} дней");
            else 
                Console.WriteLine($"Экзамен был {Math.Abs(Raznitca.TotalDays)} дней назад");
            

            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
 }
 
    