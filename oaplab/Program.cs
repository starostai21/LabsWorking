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
    /*class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person { Name = "Tom", Age = 17 };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.Read();
        }
    }
    class Person
    {
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("Лицам до 18 регистрация запрещена");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    }
    */
    class Program
    {
        // точка входа в программу
        /*static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string InpStroka = Console.ReadLine();
            string FullNumber = "";
            string OutputString = "";
            foreach (char CurrentSymb in InpStroka)
            {

                if(char.IsDigit(CurrentSymb))
                {
                    FullNumber += CurrentSymb;
                }
                else
                {
                    for(int i = 0; i < Convert.ToInt32(FullNumber); i++)
                    {
                        OutputString += CurrentSymb;
                        
                    }
                    FullNumber = "";
                }
            }

            Console.WriteLine(OutputString);
            Console.ReadLine();
        }
        */
        static void Main(string[] args)
        {
            var Rand = new Random();
            string Number = "";
            while(Number.Length < 4)
            {
                var RandSymb = Rand.Next(0, 9).ToString();
                if (Number.Contains(RandSymb))
                    continue;
                Number += RandSymb;
                
            }

            Console.WriteLine(Number);
            Console.ReadKey();
        }
    }
}
