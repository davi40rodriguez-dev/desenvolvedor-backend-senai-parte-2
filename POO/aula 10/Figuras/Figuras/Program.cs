using Figuras.Classes.Entidades;
using Figuras.Classes.Enumeração;

//Forma geo1 = new Forma(Cor.Vermelho);
Forma geo2 = new Retangulo(Cor.Azul, 10, 10);
Forma geo3 = new Circulo(Cor.Rosa, 5);

Console.WriteLine($"" +
    $"Geo 2 - Tipo Forma -> Retangulo : Area = {geo2.Area()}" +
    $"\n" +
      $"Geo 3 - Tipo Forma -> Circulo : Area = {geo3.Area()}" );
Console.ReadKey();