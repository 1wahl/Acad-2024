using System;

namespace convertetempcelsiusparafahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("conversor celsius para fahrenheit");
            Console.Write("temperatura em celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"temperatura em fahrenheit: {fahrenheit}");
        }
    }
}