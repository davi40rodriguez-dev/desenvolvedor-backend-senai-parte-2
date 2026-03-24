using static System.Console;
using static System.ConsoleColor;

Title = "CALCULADORA 01";

//Declaração de variaveis
double raio, circunferencia, volume;
const double PI = 3.14;

//Entrada de dados
Write("Entre com o valor do raio da circunferencia:");
ForegroundColor = Red;
raio = double.Parse(ReadLine());
ResetColor();

//Saída de dados
WriteLine($"Circurenferencia: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI: {PI}");

//Calculo da circunferencia
double Circunferencia(double r)
{
    return 2 * PI * r;
}
//Calcular o Volume

double Volume(double r)
{
    return (4 / 3) * r;
}