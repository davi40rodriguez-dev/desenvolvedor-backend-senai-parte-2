using System;

namespace ProjetoImposto.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double renda, double saude)
            : base(nome, renda)
        {
            GastosSaude = saude;
        }

        public override double CalcularImposto()
        {
            double imposto;

            if (RendaAnual < 20000)
                imposto = RendaAnual * 0.15;
            else
                imposto = RendaAnual * 0.25;

            imposto -= GastosSaude * 0.5;

            return imposto;
        }
    }
}