public class ContaPoupanca : Conta
{
    public double taxaDeJuros;

    public void AtualizacaoDeSaldo()
    {
        saldo = saldo + (saldo * taxaDeJuros);
    }

    public override void Saque(double quantia)
    {
        saldo = saldo - quantia; // saque sem taxa
    }
}
