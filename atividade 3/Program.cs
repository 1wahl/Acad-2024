using System;

namespace calculovolumecilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculo do volume de um cilindro");
            Console.Write("raio da base: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine($"volume do cilindro: {volume}");
        }
    }
}