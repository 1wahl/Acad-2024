using System;

namespace calculosalariototalvendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculo do salario total de um vendedor");
            Console.Write("salario base do vendedor: ");
            double salario_base = Convert.ToDouble(Console.ReadLine());

            Console.Write("total de vendas do vendedor: ");
            double total_vendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("comissao (em porcentagem): ");
            double comissao = Convert.ToDouble(Console.ReadLine());

            double valor_comissao = total_vendas * (comissao / 100);
            double salario_total = salario_base + valor_comissao;
            Console.WriteLine($"salario total do vendedor: {salario_total}");
        }
    }
}