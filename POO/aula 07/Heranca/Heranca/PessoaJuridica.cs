

namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
        //Campos
        private double limite;
        private static string titularConta;

        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        public PessoaJuridica(int numeroConta, double LimiteConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = LimiteConta;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta, double limiteEmprestimo) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta) : base(numeroConta, titularConta, saldoConta)
        {
        }

        //Métodos
        public void Limite(double quantia)
        {
            LimiteEmprestimo += quantia;
        }
    }
}
