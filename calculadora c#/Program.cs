using System.Globalization;

namespace calculadora
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            while (true)
            {
                MostrarMenu();

                Console.Clear();
                Console.WriteLine("Calculadora Tabajara 2024\n");

                Console.WriteLine("digite 1 para adicionar");
                Console.WriteLine("digite 2 para subtrair");
                Console.WriteLine("digite 3 para dividir");
                Console.WriteLine("digite 4 para multiplicar");

                Console.WriteLine("digite 'sair' para sair");

                if (Console.ReadLine() == "");
                {
                    Console.WriteLine("tente novamente, pressione enter para reiniciar");

                    if (Console.ReadLine() == "") Console.WriteLine(MostrarMenu);



                }

                string operacao = Console.ReadLine();

                if (operacao == "sair")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "sair")
                {
                    Console.WriteLine("operacao invalida, atribua uma das operacoes predefinidas");
                    Console.ReadLine();

                    continue;
                }


                Console.WriteLine("digite o primeiro numero");

                float primeironumero = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("digite o segundo numero");

                float segundonumero = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);

                float resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeironumero + segundonumero;
                }


                else if (operacao == "2") 
                {
                    resultado = primeironumero - segundonumero;
                }

                else if (operacao == "3")
                {
                    
                    while (segundonumero == 0) {
                        Console.WriteLine("impossivel dividir por zero");
                        Console.WriteLine("digite o novo valor designado para o segundo numero");
                    segundonumero = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);


                    }
                    resultado = primeironumero / segundonumero;
                }

                else if (operacao == "4")
                {
                    resultado = primeironumero * segundonumero;
                }


                Console.WriteLine("o resultado e " + resultado);

                Console.WriteLine("deseja encerrar a sessao? (s/n)");

                string resposta = Console.ReadLine();

                if (resposta == "s")
                {
                    break;
                }


            }
       }
        static void MostrarMenu()
        {


        }


    }
}
