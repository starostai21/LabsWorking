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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

// namespace такой же как и название проекта
namespace oapLaba
{
    [DataContract]
    abstract class Vehicle
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Speed { get; set; }
        [DataMember]
        public int LiftingCapacity { get; set;}
        

    }
    class Car : Vehicle    
    {
        public double Arenda { get; set; }
        public int Rashod { get; set;}
        
    }
    [DataContract]
    class Bike : Vehicle    {
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int TimeWork { get; set; } 
        }
    class Сarriage : Vehicle   { }
    class Program
    {
        static void Main(string[] args)
        {
            var CarList = new List<Car>();
            using (TextFieldParser parser = new TextFieldParser("Car.csv"))
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

                    Car CurrentCar = new Car();
                    CurrentCar.Name = fields[0];
                    CurrentCar.Speed = Convert.ToInt32(fields[1]);
                    CurrentCar.LiftingCapacity = Convert.ToInt32(fields[2]);
                    CurrentCar.Arenda = Convert.ToDouble(fields[4]);
                    CurrentCar.Rashod = Convert.ToInt32(fields[3]);
                     
                    CarList.Add(CurrentCar);
                   


                }
            }
            Bike[] BikeArray;

            var Serializer = new DataContractJsonSerializer(typeof(Bike[]));
            using (var sr = new StreamReader("bike.json"))
            {
               BikeArray = (Bike[])Serializer.ReadObject(sr.BaseStream);

            }



        }
    }

}