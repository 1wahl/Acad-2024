using System;

namespace consumo_combustivel_por_km
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculo de consumo de combustivel por km");
            Console.Write("quilometragem inicial: ");
            double kminicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("quilometragem final: ");
            double kmfinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("consumo de combustivel (litros): ");
            double consumo_combustivel = Convert.ToDouble(Console.ReadLine());

            double distancia_total = kmfinal - kminicial;
            double consumo_por_km = consumo_combustivel / distancia_total;
            Console.WriteLine($"consumo por km: {consumo_por_km} litros/km");
        }
    }
}