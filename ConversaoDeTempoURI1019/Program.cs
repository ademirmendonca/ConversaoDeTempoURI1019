using System;
using System.Globalization;

namespace ConversaoDeTempoURI1019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis declaradas
            int minutos;
            double conta;

            Console.Write("Insira o tempo total gasto: ");

            minutos = int.Parse(Console.ReadLine());

            //Define o valor da conta
            conta = 50.0;

            //Condição para a soma total da conta
            if (minutos > 100)
            {
                //Verifica a diferença entre o valor já pré estabelecido, com os valores excedidos.
                conta = conta + (minutos - 100) * 2.0;
            }

            //Imprimir o valor total a pagar
            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
