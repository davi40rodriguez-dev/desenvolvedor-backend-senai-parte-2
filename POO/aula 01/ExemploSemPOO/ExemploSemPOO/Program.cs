using static System.Console;
//Entrada de dados
WriteLine("Digite as medidas do triângulo X:");
Write("Digite o valor de a:");
double ax = double.Parse(ReadLine());
Write("Digite o valor de b:");
double bx= double.Parse(ReadLine());
Write("Digite o valor de c:");
double cx = double.Parse(ReadLine());

WriteLine("Digite as medidas do triângulo Y:");
Write("Digite o valor de a:");
double ay = double.Parse(ReadLine());
Write("Digite o valor de b:");
double by = double.Parse(ReadLine());
Write("Digite o valor de c:");
double cy = double.Parse(ReadLine());

//Processamento de dados
double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(px * (px - ay) * (px - by) * (px - cy));

//Saída de dados
WriteLine($"A aréa do triângulo X: {areax: F2}");
WriteLine($"A aréa do triângulo Y: {areay: F2}");

if (areax > areay)
{
    WriteLine("Maior área é do triâgulo X:");
}
else if (areax > areax)
{
    WriteLine("Maior área do triangulo Y:");
}
else
{
    WriteLine("Os triangulos de aréas iguais");
}
ReadKey();





