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


            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
 }
 
    