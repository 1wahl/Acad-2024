using System;

namespace calculovolumeesfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculo do volume de uma esfera");
            Console.Write("raio da esfera: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine($"volume da esfera: {volume}");
        }
    }
}