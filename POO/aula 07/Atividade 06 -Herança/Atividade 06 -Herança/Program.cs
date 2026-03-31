using System;

namespace BancoSenai
{
    class Program
    {
            public class Conta
        {
            public int numero;
            public string titular;
            public double saldo;

            public void Deposito(double quantia)
            {
                saldo = saldo + quantia;
            }

            public virtual void Saque(double quantia)
            {
                saldo = saldo - quantia - 5.0;
            }
        }

        public class ContaPoupanca : Conta
        {
            public double taxaDeJuros;

            public void AtualizacaoDeSaldo()
            {
                saldo = saldo + (saldo * taxaDeJuros);
            }

            public override void Saque(double quantia)
            {
                saldo = saldo - quantia;
            }
        }

        public class ContaParaEmpresa : Conta
        {
            public double limiteDeEmprestimo;

            public void Emprestimo(double quantia)
            {
                if (quantia <= limiteDeEmprestimo)
                {
                    saldo = saldo + quantia;
                }
            }
        }
    }  
}
