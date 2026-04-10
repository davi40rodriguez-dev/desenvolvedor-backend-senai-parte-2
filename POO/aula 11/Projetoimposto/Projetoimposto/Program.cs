using System;
using System.Collections.Generic;
using ProjetoImposto.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos contribuintes? ");
        int n = int.Parse(Console.ReadLine());

        List<Contribuinte> lista = new List<Contribuinte>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Pessoa física ou jurídica (f/j)? ");
            char tipo = char.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Renda anual: ");
            double renda = double.Parse(Console.ReadLine());

            if (tipo == 'f')
            {
                Console.Write("Gastos com saúde: ");
                double saude = double.Parse(Console.ReadLine());

                lista.Add(new PessoaFisica(nome, renda, saude));
            }
            else
            {
                Console.Write("Número de funcionários: ");
                int func = int.Parse(Console.ReadLine());

                lista.Add(new PessoaJuridica(nome, renda, func));
            }
        }

        double total = 0;

        Console.WriteLine("\nIMPOSTOS:");

        foreach (Contribuinte c in lista)
        {
            double imposto = c.CalcularImposto();
            Console.WriteLine(c.Nome + ": R$ " + imposto);
            total += imposto;
        }

        Console.WriteLine("\nTOTAL: R$ " + total);
    }
}