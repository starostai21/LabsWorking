// подключены какие-то библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

// namespace такой же как и название проекта
namespace oapLaba
{
    public class People
    {
        public string Name { get; set; }
        public string Familiya { get; set; }
        public string Otchestvo { get; set; }
                
        public People(string name, string familiya, string otchestvo)
        {
            Name = name;
            Familiya = familiya;
            Otchestvo = otchestvo;
        }
        static void SpisokStudent()
        {
            XDocument xdoc = new XDocument();
            // создаем первый элемент
            XElement iphone6 = new XElement("phone");
            // создаем атрибут
            XAttribute iphoneNameAttr = new XAttribute("name", "iPhone 6");
            XElement iphoneCompanyElem = new XElement("company", "Apple");
            XElement iphonePriceElem = new XElement("price", "40000");
            // добавляем атрибут и элементы в первый элемент
            iphone6.Add(iphoneNameAttr);
            iphone6.Add(iphoneCompanyElem);
            iphone6.Add(iphonePriceElem);

            // создаем второй элемент
            XElement galaxys5 = new XElement("phone");
            XAttribute galaxysNameAttr = new XAttribute("name", "Samsung Galaxy S5");
            XElement galaxysCompanyElem = new XElement("company", "Samsung");
            XElement galaxysPriceElem = new XElement("price", "33000");
            galaxys5.Add(galaxysNameAttr);
            galaxys5.Add(galaxysCompanyElem);
            galaxys5.Add(galaxysPriceElem);

            // создаем корневой элемент
            XElement phones = new XElement("phones");
            // добавляем в корневой элемент
            phones.Add(iphone6);
            phones.Add(galaxys5);
            // добавляем корневой элемент в документ
            xdoc.Add(phones);
            //сохраняем документ
            xdoc.Save("phones.xml");
        }
    }
    /*public class Teacher:People
    {

    }*/
    public class Subject
    {
        public string NameSubject { get; set; }
        public string Teacher { get; set; }
        public Subject(string namesubject, string teacher)
        {
            NameSubject = namesubject;
            Teacher = teacher;            
        }
    }
    public class Grade
    {
        public string Subject { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public Grade(string subject, int value, DateTime date)
        {
            Subject = subject;
            Value = value;
            Date = date;
        }
    }

}
    