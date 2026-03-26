using banco;
using static System.Console;
using static System.Globalization.CultureInfo;

Title = "Abertura de conta";
Contabancaria conta;
WriteLine("Abertura de conta");
Write("Entre com um numero de conta ");
int numero = int.Parse(ReadLine());
Write("Entre com o nome do  titular");
string nome = ReadLine();
Write("Deseja fazer depósito inicial (s/n): ");
char resposta = char.Parse(ReadLine());

if (resposta == 's')
{
    Write("Entre com o valor de depósito inicial: R$");
    double deposito = double.Parse(ReadLine());
     conta = new Contabancaria(numero, nome, deposito);
}
else
{
     conta = new Contabancaria(numero, nome);
}

conta.Dados();

WriteLine("Entre com um valor para depósito: ");
double quantia = double.Parse(ReadLine());
conta.Deposito(quantia);
WriteLine("Entre com um valor para saque: R$");
quantia = double.Parse(ReadLine());
conta.Saque(quantia);


ReadKey();