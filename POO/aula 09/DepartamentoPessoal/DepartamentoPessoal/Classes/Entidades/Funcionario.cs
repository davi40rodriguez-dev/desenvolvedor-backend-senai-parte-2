using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentoPessoal.Classes.Entidades
{
    internal class Funcionario
    {

        //Campos
        private string nome;
        private int jornada;
        private double valor;

        public Funcionario(string nomeColaborador, int jornadaTrabalho, double valorHora)
        {
            NomeColaborador = nomeColaborador;
            JornadaTrabalho = jornadaTrabalho;
            ValorHora = valorHora;
        }

        //Propriedades
        protected string NomeColaborador
        {
            get { return nome; }
            set { nome = value; }
        }
        protected int JornadaTrabalho
        {
            get { return jornada; }
            set { jornada = value; }
        }
        protected double ValorHora
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}