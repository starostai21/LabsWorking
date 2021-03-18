// подключены какие-то библиотеки
using System;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Text.RegularExpressions;

// namespace такой же как и название проекта
namespace oapLaba
{
    public class Student
    {
        public string Name { get; set; }
        public string Familiya { get; set; }
        public string Otchestvo { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Facultet { get; set; }
        public int Kurs { get; set; }
        public Student(string name, string familiya, string otchestvo, DateTime birthday, string address, string phone, string facultet, int kurs)
        {
            Name = name;
            Familiya = familiya;
            Otchestvo = otchestvo;
            Birthday = birthday;
            Address = address;
            Phone = phone;
            Facultet = facultet;
            Kurs = kurs;
        }

        public Student()
        {
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}");
        }
    }
    class Program
    {
        public void Main(string[] args)
        {
            var Students = new List<Student>();

            using (TextFieldParser parser = new TextFieldParser(@"Data.csv"))
            {
                // свойство TextFieldType определяет тип полей: с разделителями или фиксированной ширины
                parser.TextFieldType = FieldType.Delimited;

                // можно указать произвольный разделитель
                parser.SetDelimiters(",");

                // считываем пока не дойдем до конца файла
                while (!parser.EndOfData)
                {
                    //метод ReadFields разбивает исходную строку на массив строк
                    string[] fields = parser.ReadFields();

                    Student tom = new Student();
                    tom.Name = fields[1];
                    tom.Familiya = fields[0];
                    tom.Otchestvo = fields[2];
                    Regex regex = new Regex(@"(\d\d)\.(\d\d)\.(\d{4})");
                    MatchCollection matches = regex.Matches(fields[3]);
                    if(matches.Count == 4)
                    {
                        tom.Birthday = new DateTime();

                        Students.Add(tom);
                    }
                    
                }
            }

            //tom.GetInfo();  // тут уже делаем что хотим с полученными значениями
            Console.ReadKey();
        }
    }

    
   
}
    