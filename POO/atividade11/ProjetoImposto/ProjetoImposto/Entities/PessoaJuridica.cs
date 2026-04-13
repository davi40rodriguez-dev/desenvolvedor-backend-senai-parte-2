using System;

namespace ProjetoImposto.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica(string nome, double renda, int funcionarios)
            : base(nome, renda)
        {
            Funcionarios = funcionarios;
        }

        public override double CalcularImposto()
        {
            if (Funcionarios > 10)
                return RendaAnual * 0.14;
            else
                return RendaAnual * 0.16;
        }
    }
}