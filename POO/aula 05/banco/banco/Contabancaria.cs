namespace Banco
{
    internal class Contabancaria
    {
        //Campos ou atributos
        private int numero;
        private string titular;
        private double saldo;

        //Construtor
        public Contabancaria(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0;

        }

        public Contabancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            this.saldo = saldo;

        }


        //Métodos
        public void Deposito(double quantia)
        {
            saldo += quantia;
        }

        public void Saque(double quantia)
        {
            saldo -= quantia;
        }

        public void Dados()
        {
            Console.WriteLine("Dados da conta cadastrada:");
            Console.WriteLine($"\tTitular: {titular}\n+" +
            $" \tNumero da conta: {numero}\n" +
            $"\tSaldo da conta: R${saldo}");

        }
    }
}