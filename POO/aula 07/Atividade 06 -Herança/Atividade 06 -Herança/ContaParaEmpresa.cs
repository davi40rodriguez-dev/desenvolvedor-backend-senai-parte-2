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
