using System;

class Program
{
    #region atribuições
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do diamante (deve ser um número ímpar): \n");
        int n = Convert.ToInt32(Console.ReadLine());

        //ímpar?
        if (n % 2 == 0)
        {
            Console.WriteLine("Por favor, insira um número ímpar.\n");
            return;
        }

        Console.Write('\n'); Console.Clear();
        DrawDiamond(n);
        Console.WriteLine("\n");


        Console.ReadLine();
    }
    #endregion


    #region formato
    static void DrawDiamond(int size)
    {
        int i, j, space;

        #region parte superior
        for (i = 1; i <= size; i += 2)
        {
            for (space = 1; space <= (size - i) / 2; space++)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= i; j++)
            {
                Console.Write("x");
            }

            Console.WriteLine();
        }
        #endregion

        #region parte inferior
        for (i = size - 2; i >= 1; i -= 2)
        {
            for (space = 1; space <= (size - i) / 2; space++)
            {
                Console.Write(" ");
            }

            for (j = 1; j <= i; j++)
            {
                Console.Write("x");
            }

            Console.WriteLine();
        }
        #endregion

        #endregion
    }
}