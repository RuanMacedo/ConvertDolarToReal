using System;

namespace OngConvertDolarToReal
{
    class Program
    {
        static void Main(string[] args)
        {

            double vlr,vlrReal,dolar;

            Console.WriteLine("Bem vindo ao conversor da ONG!");
            Console.WriteLine("");

            Console.WriteLine("Digite o valor da doação em Dolar:");
            vlr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cotação atual do dólar: ");
            dolar = Convert.ToDouble(Console.ReadLine());

            vlrReal = vlr * dolar;

            Console.WriteLine("Valor da doação em Real: {0}",vlrReal.ToString("0.00"));

        }
    }
}
