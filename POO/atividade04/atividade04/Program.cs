using System;
using System.Reflection;

namespace ExercicioDolar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine());

            double resultado = ConversorDeMoeda.Calcular(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2"));

            Console.ReadLine();
        }
    }

    class ConversorDeMoeda
    {
        public static double Calcular(double cotacao, double quantidade)
        {
            double total = cotacao * quantidade;
            double iof = total * 0.06; // 6% de IOF
            return total + iof;
        }
    }
}


