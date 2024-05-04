using System.ComponentModel.Design;

namespace RoboTupiniquim.ConsoleApp;
internal class Program
{
    static int area;
    static int posX;
    static int posY;
    static char direcao;
    static string instString;
    static void Main(string[] args)
    {
        Console.WriteLine("Robo Tupiniquim");
        Console.WriteLine("tamanho area: ");
        area = int.Parse(Console.ReadLine());
        Console.WriteLine("posicao X: ");
        posX = int.Parse(Console.ReadLine());
        Console.WriteLine("posicao Y: ");
        posY = int.Parse(Console.ReadLine());
        Console.WriteLine("direcao: ");
        direcao = char.Parse(Console.ReadLine());

        Console.WriteLine("instrucao (E, D, M): ");
        instString = Console.ReadLine();
        char[] inst = instString.ToCharArray();

        Console.WriteLine("seu robo esta em:");
        posRobo(area, posX, posY);

        Console.WriteLine("pressione qualquer tecla...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine();

        for (int i = 0; i < inst.Length; i++)
        {
            switch (inst[i])
            {
                case 'E':
                    VirarEsquerda();
                    break;
            
                case 'D':
                    VirarDireita();
                    break;
                case 'M':
                    Mover();
                    break;
                default:
                    Console.WriteLine("insira uma opcao valida");
                    Console.Clear();
                    break;
            }
        }
        Console.WriteLine("seu robo esta em: ");
        posRobo(area, posX, posY);
    }
    static void Mover()
    {
        if (direcao == 'N')
        {
            posY++;
        }
        else if (direcao == 'S')
        {
            posY--;
        }
        else if (direcao == 'O')
        {
            posX--;
        }
        else if (direcao == 'L')
        {
            posX++;
        }
    }
    static void VirarEsquerda()
    {
        if (direcao == 'N')
        {
            direcao = 'O';
        }
        else if (direcao == 'O')
        {
            direcao = 'S';
        }
        else if (direcao == 'S')
        {
            direcao = 'L';
        }
        else if (direcao == 'L')
        {
            direcao = 'N';
        }
    }
    static void VirarDireita()
    {
        if (direcao == 'N')
        {
            direcao = 'L';
        }
        else if (direcao == 'O')
        {
            direcao = 'N';
        }
        else if (direcao == 'S')
        {
            direcao = 'O';
        }
        else if (direcao == 'L')
        {
            direcao = 'S';
        }
    }
    static void posRobo(int area, int col, int lin)
    {
        for (int i = 1; i <= area; i++)
        {
            for (int j = 1; j <= area; j++)
            {
                if (i == lin && j == col)
                {
                    Console.Write("0 ");
                    continue;
                }
                Console.Write("x ");
            }
            Console.WriteLine();
        }
        return;

        




    }
}
