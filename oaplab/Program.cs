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
using System.Globalization;

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
        abstract public (double, double) Calc(int Massa, int Distance);

    }
    class Car : Vehicle    
    {
        public double Arenda { get; set; }
        public int Rashod { get; set;}
        public override (double, double) Calc(int Massa, int Distance)
        {
            return ((double)Distance / (double)Speed, Convert.ToInt32(Arenda* Distance + Distance / 100*Rashod));
        }

    }
    [DataContract]
    class Bike : Vehicle    {
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public double TimeWork { get; set; }

        public override (double, double) Calc(int Massa, int Distance)
        {
            double Time = (double)Distance / (double)Speed;
            if (Time > TimeWork)
                Time = Time / TimeWork * 24;
                return (Time, Convert.ToInt32(Price * Distance));
        }
    }
    class Carriage : Vehicle  
    {
    public double DopBabki { get; set; }

        public override (double, double) Calc(int Massa, int Distance)
        {
            double Time = (double)Distance / (double)Speed;
            return (Time,  DopBabki * Time / 24);
        }
    }
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
                    CurrentCar.Arenda = double.Parse(fields[4], CultureInfo.InvariantCulture);
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
            var CarriageList = new List<Carriage>();
            XDocument xdoc = XDocument.Load("Сarriage.xml");
            foreach (XElement СarriageElement in xdoc.Element("Сarriages").Elements("Сarriage"))
            {
                XAttribute NameAttribute = СarriageElement.Attribute("Name");
                XElement SpeedElement = СarriageElement.Element("Speed");
                XElement LiftingCapacityElement = СarriageElement.Element("LiftingCapacity");
                XElement DopBabkiElement = СarriageElement.Element("DopBabki"); 
                CarriageList.Add(new Carriage { Name = СarriageElement.Attribute("Name").Value, Speed = Convert.ToInt32(СarriageElement.Element("Speed").Value), LiftingCapacity = Convert.ToInt32(СarriageElement.Element("LiftingCapacity").Value), DopBabki = Convert.ToInt32(СarriageElement.Element("DopBabki").Value) });
                

            }

            var AllVehicles = CarList.Concat<Vehicle>(BikeArray).Concat(CarriageList);
            Console.WriteLine("Введите расстояние");
            var Distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массу груза в кг");
            var MassaGruza = Convert.ToInt32(Console.ReadLine());
            var filter1 = AllVehicles.Where(v => v.LiftingCapacity > MassaGruza).Select(v => new
            {
                Name = v.Name,
                TimeAndPrice = v.Calc(MassaGruza, Distance)
            }) ;
            foreach (var CurrentVehicle in filter1)
            {
                Console.WriteLine($"{CurrentVehicle.Name} {CurrentVehicle.TimeAndPrice.Item1}час {CurrentVehicle.TimeAndPrice.Item2}руб");
            }

            Console.ReadLine();
        }
    }

}