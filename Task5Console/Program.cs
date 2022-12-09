using System;
namespace Hello
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (x == -2) throw new Exception();
                else return 3 / Math.Abs(Math.Pow(x, 3) + 8);
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите h: "); ;
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}
