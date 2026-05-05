using Microsoft.EntityFrameworkCore;
using Estudante.Classes.Dados;
using Estudante.Classes.Entidades;

using var context = new AlunoContext();

context.Database.EnsureCreated();
//Adicionar dados ao Banco de dados
Aluno pessoa1 = new Aluno("Clodoaldo", 12345, "DEV");
context.Alunos.Add(pessoa1);
context.SaveChanges();

//Exibir o dado
var pessoas = context.Alunos.FirstOrDefault(c => c.Id == 1);
pessoas.ExibirDados();

//Uptade
pessoas = context.Alunos.FirstOrDefault(c =>c.Id == 2);
pessoas.Curso = "Backend";