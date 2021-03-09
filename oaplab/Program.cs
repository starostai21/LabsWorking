
            // подключены какие-то библиотеки
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

// namespace такой же как и название проекта
namespace oapLabaSmirnov
{

    /*class Program
    {
        // точка входа в программу
        static void Main(string[] args)
        {
            //ExceptionTest();
            //ExceptionTest2();
            //ExceptionTest3();
            //ExceptionTest4();
            //ExceptionTest5();
            //ExceptionTest6();
            //ExceptionTest7();
            //ExceptionTest8();
            //ExceptionTest9();
            //ExceptionTest10();
            //ExceptionTest11();
            ExceptionTest12();
            //ExceptionTest13();
            //ExceptionTest14();
            //ExceptionTest15();
            //ExceptionTest16();
            //ExceptionTest17();
            //ExceptionTest18();
            //ExceptionTest19();
            Console.ReadKey();
        }

        static void ExceptionTest()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }

        }

        static void ExceptionTest2()
        {
            string dirName = "C:\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
        }

        static void ExceptionTest3()
        {
            string path = @"C:\SomeDir";
            string subpath = @"program\avalon";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
        }

        static void ExceptionTest4()
        {
            string dirName = "C:\\Program Files";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
        }

        static void ExceptionTest5()
        {
            string dirName = @"C:\SomeFolder";

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        static void ExceptionTest6()
        {
            string oldPath = @"C:\SomeFolder";
            string newPath = @"C:\SomeDir";
            DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
            if (dirInfo.Exists && Directory.Exists(newPath) == false)
            {
                dirInfo.MoveTo(newPath);
            }
        }

        static void ExceptionTest7()
        {
            string path = @"C:\Users\User\source\repos\Oap_Lab\фигня.docx";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length);
            }

        }

        static void ExceptionTest8() { 
        string path = @"C:\Users\User\source\repos\Oap_Lab\фигня.docx";
            FileInfo fileInf = new FileInfo(path);
        if (fileInf.Exists)
        {
        fileInf.Delete();
        // альтернатива с помощью класса File
        // File.Delete(path);
            }
}

        static void ExceptionTest9()
        {
            string path = @"C:\Users\User\source\repos\Oap_Lab\фигня.docx";
            string newPath = @"C: \Users\User\source\repos\фигня.docx";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.MoveTo(newPath);
                // альтернатива с помощью класса File
                // File.Move(path, newPath);
            }
            Console.WriteLine("Файл перемещен");
        }

        static void ExceptionTest10()
        {
            string path = @"C:\И-21";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists) 
            {
                dirInfo.Create();
            }
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            // запись в файл
            using (FileStream fstream = new FileStream($"{path}\\note.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }

            // чтение из файла
            using (FileStream fstream = File.OpenRead($"{path}\\note.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

            Console.ReadLine();
        }

        static void ExceptionTest11()
        {
            string text = "hello world";

            // запись в файл
            using (FileStream fstream = new FileStream(@"D:\\note.dat", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] input = Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(input, 0, input.Length);
                Console.WriteLine("Текст записан в файл");

                // перемещаем указатель в конец файла, до конца файла- пять байт
                fstream.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока

                // считываем четыре символов с текущей позиции
                byte[] output = new byte[4];
                fstream.Read(output, 0, output.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine($"Текст из файла: {textFromFile}"); // worl

                // заменим в файле слово world на слово house
                string replaceText = "house";
                fstream.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока
                input = Encoding.Default.GetBytes(replaceText);
                fstream.Write(input, 0, input.Length);

                // считываем весь файл
                // возвращаем указатель в начало файла
                fstream.Seek(0, SeekOrigin.Begin);
                output = new byte[fstream.Length];
                fstream.Read(output, 0, output.Length);
                // декодируем байты в строку
                textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine($"Текст из файла: {textFromFile}"); // hello house
            }
            Console.Read();
        }

        static void ExceptionTest12()
        {
            string writePath = @"C:\И-21\hta.txt";

            string text = "Привет мир!\nПока мир...";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Дозапись");
                    sw.Write(4.5);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
        static void ExceptionTest13()
        {
            string path = @"C:\SomeDir\hta.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            // асинхронное чтение
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        } 
            
    }*/
    /*struct State
    {
        public string name;
        public string capital;
        public int area;
        public double people;

        public State(string n, string c, int a, double p)
        {
            name = n;
            capital = c;
            people = p;
            area = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            State[] states = new State[2];
            states[0] = new State("Германия", "Берлин", 357168, 80.8);
            states[1] = new State("Франция", "Париж", 640679, 64.7);

            string path = @"C:\SomeDir\states.dat";

            try
            {
                // создаем объект BinaryWriter
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    // записываем в файл значение каждого поля структуры
                    foreach (State s in states)
                    {
                        writer.Write(s.name);
                        writer.Write(s.capital);
                        writer.Write(s.area);
                        writer.Write(s.people);
                    }
                }
                // создаем объект BinaryReader
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        string capital = reader.ReadString();
                        int area = reader.ReadInt32();
                        double population = reader.ReadDouble();

                        Console.WriteLine("Страна: {0}  столица: {1}  площадь {2} кв. км   численность населения: {3} млн. чел.",
                            name, capital, area, population);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }*/
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Person person = new Person("Tom", 29);
            Console.WriteLine("Объект создан");

            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newPerson.Name} --- Возраст: {newPerson.Age}");
            }

            Console.ReadLine();
        }
    }
}
