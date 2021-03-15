using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace smirnov
{
    class Program
    {
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
            //ExceptionTest12();
            //ExceptionTest13();
            //ExceptionTest14();

            FactorialAsync(-4);
            FactorialAsync(6);

            Console.ReadKey();
        }

        private static void FactorialAsync(int v)
        {
            throw new NotImplementedException();
        }

        static void ExceptionTest()
        {
            Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
            task1.Start();

            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));

            Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));

            Console.ReadLine();
        }
        static void ExceptionTest2()
        {
            Task task = new Task(Display);
            task.Start();

            Console.WriteLine("Завершение метода Main");

            Console.ReadLine();
        }
        static void ExceptionTest3()
        {
            Task task = new Task(Display);
            task.Start();
            task.Wait();
            Console.WriteLine("Завершение метода Main");
            Console.ReadLine();
        }
        static async Task ExceptionTest4Async()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Факториал равен {result}");

            Console.WriteLine("Начало метода FactorialAsync"); // выполняется синхронно
            await Task.Run(() => Factorial());                // выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsync");
        }
        static void ExceptionTest5()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Факториал равен {result}");

            Console.WriteLine("Начало метода FactorialAsync"); // выполняется синхронно
            await Task.Run(() => FactorialAsync());                // выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsync");
        }
        static void ExceptionTest6()
        {
            string s = "Hello world! One step at a time";


            using (StreamWriter writer = new StreamWriter("hello.txt", false))
            {
                await writer.WriteLineAsync(s);  // асинхронная запись в файл
            }
            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine(result);
            }
        }
            static void ExceptionTest6()
            {
                int result = 1;
                for (int i = 1; i <= 6; i++)
                {
                    result *= i;
                }
                Thread.Sleep(8000);
                Console.WriteLine($"Факториал равен {result}");
            }

        static void ExceptionTest7()
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(5000);
            Console.WriteLine($"Факториал равен {result}");
            {
                Console.WriteLine("Некоторая работа");
                Console.Read();
            }
        }
            static void ExceptionTest8()
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            // определение асинхронного метода
            /*static async void FactorialAsync(int n)
                {
                    int x = await Task.Run(() => Factorial(n));
                    Console.WriteLine($"Факториал равен {x}");
                }
                static void Main(string[] args)
                {
                    FactorialAsync(5);
                    FactorialAsync(6);
                    Console.Read();*/
        
        static void ExceptionTest9()
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static async Task<int> FactorialAsync(int n)
        {
            return await Task.Run(() => Factorial(n));
        }
        static async Task Main(string[] args)
        {
            int n1 = await FactorialAsync(5);
            int n2 = await FactorialAsync(6);
            Console.WriteLine($"n1={n1}  n2={n2}");
            Console.Read();
        }
        static void ExceptionTest10()
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {result}");
        }
        // определение асинхронного метода
        static async void FactorialAsync()
        {
            await Task.Run(() => Factorial(4));
            await Task.Run(() => Factorial(3));
            await Task.Run(() => Factorial(5));
        }
        static void ExceptionTest11()
        {
            if (n < 1)
                throw new Exception($"{n} : число не должно быть меньше 1");
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {result}");
        }
        static async void FactorialAsync(int n)
        {
            try
            {
                await Task.Run(() => Factorial(n));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ExceptionTest12()
        {
            Task task = null;
            try
            {
                task = Task.Run(() => Factorial(n));
                await task;
            }
            catch (Exception ex)
            {
                Console.WriteLine(task.Exception.InnerException.Message);
                Console.WriteLine($"IsFaulted: {task.IsFaulted}");
            }

        }
        static void ExceptionTest13()
        {
            try
            {
                await Task.Run(() => Factorial(n)); ;
            }
            catch (Exception ex)
            {
                await Task.Run(() => Console.WriteLine(ex.Message));
            }
            finally
            {
                await Task.Run(() => Console.WriteLine("await в блоке finally"));
            }
        }
        static void ExceptionTest14()
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                    return;
                }
                result *= i;
                Console.WriteLine($"Факториал числа {i} равен {result}");
                Thread.Sleep(1000);
            }
        }
        // определение асинхронного метода
        static async void FactorialAsync(int n, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return;
            await Task.Run(() => Factorial(n, token));
        }

        static void Main1(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            FactorialAsync(6, token);
            Thread.Sleep(3000);
            cts.Cancel();
            Console.Read();
        }


    }
}