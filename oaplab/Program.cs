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
         {
            /*
            
            // команда Console.Write выводит текст в консоль
             Console.Write("Input katet1: ");
             // команда Console.ReadLine читает СТРОКУ из консоли
             var Katet1 = Console.ReadLine();

             Console.Write("Input katet2: ");
             var Katet2 = Console.ReadLine();

             // команда Math.Sqrt - квадратный корень
             // Math.Pow - возведение в степень
             // Convert.ToDouble - преобразует строку в число
             var Gipotenuza = Math.Sqrt(Math.Pow(Convert.ToDouble(Katet1), 2) + Math.Pow(Convert.ToDouble(Katet2), 2));
             var Perimetr = Convert.ToDouble(Katet1) + Convert.ToDouble(Katet2) + Convert.ToDouble(Gipotenuza);
             var Ploshad = (Convert.ToDouble(Katet1) * Convert.ToDouble(Katet2)) / 2;
             // выводим результат
             // знак $ перед строкой указывает, что внутри строки в фигурных скобках названия переменных
             Console.WriteLine($"Perimetr = {Perimetr}");
             Console.WriteLine($"Ploshad = {Ploshad}");
             // читаем строку, чтобы консольное окно сразу не закрылось
             Console.Write("Press ENTER to continue...");
             Console.ReadLine();
             // при запуске программы будет выполняться код, который вы напишете тут
            */

            Console.Write("Inpat radius: ");
            var radius = Console.ReadLine();
            var dlina = Convert.ToDouble(radius) * Math.PI * 2;
            var ploshad = Math.Pow(Convert.ToDouble(radius), 2) * Math.PI;
            Console.WriteLine($"dlina = {dlina}");
            Console.WriteLine($"Ploshad = {ploshad}");
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();

        }
     }
 }
 
    