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
        saldo = saldo - quantia - 5.0; // taxa padrão
    }
}