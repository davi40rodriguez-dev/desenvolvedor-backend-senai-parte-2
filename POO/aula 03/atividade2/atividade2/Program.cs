using atividade2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();

        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();

        Console.Write("Salario bruto: ");
        func.SalarioBruto = double.Parse(Console.ReadLine());

        Console.Write("Imposto: ");
        func.Imposto = double.Parse(Console.ReadLine());

        Console.WriteLine("Salario liquido: " + func.SalarioLiquido());

        Console.Write("Aumento (%): ");
        double p = double.Parse(Console.ReadLine());

        func.AumentarSalario(p);

        Console.WriteLine("Novo salario liquido: " + func.SalarioLiquido());
    }
}
