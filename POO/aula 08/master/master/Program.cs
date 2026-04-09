
using master;


Console.WriteLine(tipo.ContaNormal);
Console.WriteLine(tipo.ContaPoupanca);
Console.WriteLine(tipo.ContaPJ);

Conta conta = new Conta(12345, 11550.56, new Pessoa
("Clodoaldo", 40688831));


ContaPJ pj = new ContaPJ(54321, 500000, new Pessoa("Clodoaldo", 5444323), 20000); 

var b = pj.ToString();
Console.WriteLine(b);

ContaPoupanca pp = new ContaPoupanca(6666666, 666.66, new Pessoa("lu", 6666666), 5.0);

pp.Consulta();

Console.ReadKey();
