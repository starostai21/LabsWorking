
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace такой же как и название проекта
namespace oapLaba
{
    interface IReport
    {
        void DoReport();
        
    }
    class OutPutScreen : IReport
    {
        public void DoReport()
        {
            Console.WriteLine(@"C:\И-21\hta.txt");
        }
    }    
    class Print : IReport
    {
            public void DoReport()
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\И-21\hta.txt"))
                {
                    file.WriteLine(@"C:\И-21\hta.txt");
                }

                PrintDocument D = new PrintDocument();
                D.DocumentName = @"C:\И-21\hta.txt";
                D.Print();
            }            
    }
    class Save : IReport
    {
        public void DoReport()
            {
        string Path = @"C:\И-21\hta.txt";

        string Text = "Привет мир!\nПока мир...";
        try
            {
                using (StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(Text);
                }

                using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
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
    }       
    class FileWork
    {
        static void Main(string[] args)
        {
            IReport MyReport = null;

            Console.WriteLine("Я умею три вещи:\n 1)Выводить на экран\n 2)Печатать файл\n 3)Сохранять введенную строку в документ");
            Console.WriteLine("Что вы хотите сделать? Введите цифру: ");
            string wish = Console.ReadLine();
            if (wish == "1")
            {
                MyReport = new OutPutScreen();
            }
            else if (wish == "2")
            {
                MyReport = new Print();
            }
            else if (wish == "3")
            {
                MyReport = new Save();
            }
            else
            {
                Console.WriteLine("Приляг и поспи внатуре, я такое не умею");
            }
            MyReport.DoReport();

            Console.ReadLine();
        }
        
    }

}

 
    