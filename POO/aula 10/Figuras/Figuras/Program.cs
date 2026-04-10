using Figuras.Classes.Enumeração;
using static System.Console;
using Figuras.Classes.Entidades;

List<Forma> formas = new();

Write("Entre com a quantidade de formas: ");
int qtd = int.Parse(ReadLine());

for (int i = 0; i < qtd;  i++)
{
    WriteLine($"Dados do objeto geométrico n°{i + 1}:");
    Write($"Retângulo ou Circulo (R/C): ");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 'r')
    {
    WriteLine("Qual é a cor do objeto? " +
        "\n\t1 - Vermelho" +
        "\n\t2 - Azul" +
        "\n\t3 - Amarelo" +
        "\n\t4 - Rosa");
    int cor = int.Parse(ReadLine());
        Write("Digite a largura do retângulo: ");
        double l = double.Parse(ReadLine());
        double r = double.Parse(ReadLine());
        formas.Add(new Circulo((Cor)cor, r));

    }
}