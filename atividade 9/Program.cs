using System;

namespace mediaponderada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculo da media ponderada de notas");

            double somaNotas = 0;
            double somaPesos = 0;

            while (true)
            {
                Console.Write("digite a nota (ou digite 'resultado' para calcular): ");
                string inputNota = Console.ReadLine();

                if (inputNota.ToLower() == "resultado")
                {
                    if (somaPesos == 0)
                    {
                        Console.WriteLine("e necessario pelo menos 1 nota e peso para calcular a media ponderada.");
                        continue;
                    }

                    break;
                }

                double nota;
                if (!double.TryParse(inputNota, out nota) || nota < 0)
                {
                    Console.WriteLine("por favor, digite um valor valido para a nota (maior ou igual a zero).");
                    continue;
                }

                Console.Write("digite o peso: ");
                double peso;
                if (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
                {
                    Console.WriteLine("por favor, digite um valor valido para o peso (maior que zero).");
                    continue;
                }

                somaNotas += nota * peso;
                somaPesos += peso;
            }

            if (somaPesos == 0)
            {
                Console.WriteLine("e necessario pelo menos 1 nota e peso para calcular a media ponderada.");
            }
            else
            {
                double mediaPonderada = somaNotas / somaPesos;
                Console.WriteLine($"a media ponderada das notas e: {mediaPonderada}");
            }
        }
    }
}