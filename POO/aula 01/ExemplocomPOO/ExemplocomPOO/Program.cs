using ExemplocomPOO;
using static System.Console;
Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

WriteLine("Digite as  medidas do triangulo X");
Write("Digte a medida A: ");
x.ladoA = double.Parse(ReadLine());
Write("Digte a medida B: ");
x.ladoB = double.Parse(ReadLine());
Write("Digte a medida C: ");
x.ladoC = double.Parse(ReadLine());

WriteLine("Digite as  medidas do triangulo Y");
Write("Digte a medida A: ");
y.ladoA = double.Parse(ReadLine());
Write("Digte a medida B: ");
y.ladoB = double.Parse(ReadLine());
Write("Digte a medida C: ");
y.ladoC = double.Parse(ReadLine());

