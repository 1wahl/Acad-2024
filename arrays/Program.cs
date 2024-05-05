using System;

class Program
{
    static void Main(string[] args)
    {
        int[] valores = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };

        MostrarValores(valores);

        int maior = EncontrarMaiorValor(valores);
        Console.WriteLine("Maior Valor: " + maior);

        int menor = EncontrarMenorValor(valores);
        Console.WriteLine("Menor Valor: " + menor);

        double media = CalcularMedia(valores);
        Console.WriteLine("Valor Medio: " + media);

        int[] tresMaiores = EncontrarTresMaiores(valores);
        Console.WriteLine("Tres Maiores Valores:");
        MostrarValores(tresMaiores);

        int[] negativos = EncontrarValoresNegativos(valores);
        Console.WriteLine("Valores Negativos:");
        MostrarValores(negativos);

        int[] novaSequencia = RemoverItem(valores);
        Console.WriteLine("Sequencia apos remover um valor aleatorio:");
        MostrarValores(novaSequencia);
    }

    static void MostrarValores(int[] array)
    {
        foreach (int valor in array)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }

    static int EncontrarMaiorValor(int[] array)
    {
        int maior = array[0];
        foreach (int valor in array)
        {
            if (valor > maior)
            {
                maior = valor;
            }
        }
        return maior;
    }

    static int EncontrarMenorValor(int[] array)
    {
        int menor = array[0];
        foreach (int valor in array)
        {
            if (valor < menor)
            {
                menor = valor;
            }
        }
        return menor;
    }

    static double CalcularMedia(int[] array)
    {
        double soma = 0;
        foreach (int valor in array)
        {
            soma += valor;
        }
        return soma / array.Length;
    }

    static int[] EncontrarTresMaiores(int[] array)
    {
        Array.Sort(array);
        int[] tresMaiores = new int[3];
        int length = array.Length;
        tresMaiores[0] = array[length - 1];
        tresMaiores[1] = array[length - 2];
        tresMaiores[2] = array[length - 3];
        return tresMaiores;
    }

    static int[] EncontrarValoresNegativos(int[] array)
    {
        int count = 0;
        foreach (int valor in array)
        {
            if (valor < 0)
            {
                count++;
            }
        }
        int[] negativos = new int[count];
        int index = 0;
        foreach (int valor in array)
        {
            if (valor < 0)
            {
                negativos[index++] = valor;
            }
        }
        return negativos;
    }

    static int[] RemoverItem(int[] array)
    {
        Random rand = new Random();
        int index = rand.Next(array.Length);
        int[] newArray = new int[array.Length - 1];
        Array.Copy(array, 0, newArray, 0, index);
        Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
        return newArray;
    }
}
