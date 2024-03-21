using System;

namespace calculovolumecaixaretangular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculo do volume de uma caixa retangular");
            Console.Write("comprimento: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = comprimento * largura * altura;
            Console.WriteLine($"volume da caixa: {volume}");
        }
    }
}