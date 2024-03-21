using System;

namespace MediaHarmonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo da Media Harmonica de Notas");

            double somaInversos = 0;
            int quantidadeNotas = 0;

            while (true)
            {
                Console.Write("Digite a nota (ou digite 'resultado' para calcular): ");
                string inputNota = Console.ReadLine();

                if (inputNota.ToLower() == "resultado")
                {
                    if (quantidadeNotas < 2)
                    {
                        Console.WriteLine("É necessário pelo menos 2 notas para calcular a média harmônica.");
                        continue;
                    }

                    break;
                }

                double nota;
                if (!double.TryParse(inputNota, out nota) || nota <= 0)
                {
                    Console.WriteLine("Por favor, digite um valor válido para a nota (maior que zero).");
                    continue;
                }

                somaInversos += 1 / nota;
                quantidadeNotas++;
            }

            if (quantidadeNotas < 2)
            {
                Console.WriteLine("É necessário pelo menos 2 notas para calcular a média harmônica.");
            }
            else
            {
                double mediaHarmonica = quantidadeNotas / somaInversos;
                Console.WriteLine($"A média harmônica das {quantidadeNotas} notas é: {mediaHarmonica}");
            }
        }
    }
}