using atividade3;
using System;

class Program
{
    static void Main(string[] args)
    {
        Aluno d = new Aluno();

        Console.Write("Nome do aluno: ");
        d.NomeDoAluno = Console.ReadLine();

        Console.WriteLine("Digite as três notas:");
        d.Nota1 = double.Parse(Console.ReadLine());
        d.Nota2 = double.Parse(Console.ReadLine());
        d.Nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Nota final do aluno: " + d.NotaFinal());

        if (d.AprovadoOuReprovado())
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
         
        }
    }
}