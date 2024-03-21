using System;

namespace converterfahrenheitparacelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("conversor fahrenheit para celsius");
            Console.Write("temperatura em fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"temperatura em celsius: {celsius}");
        }
    }
}