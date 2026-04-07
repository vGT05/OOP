using Master;
/*
Console.WriteLine(Tipo.ContaNormal);
Console.WriteLine(Tipo.ContaPoupanca);
Console.WriteLine(Tipo.ContaPJ);
*/

Conta conta = new Conta(12345, 1500.56, new Pessoa("Clodoaldo", 12345));

var a = conta.ToString();
Console.WriteLine(a);

ContaPJ pj = new ContaPJ(54321, 50000, new Pessoa("César", 50197810010), 20000);

var b = pj.ToString();
Console.WriteLine(b);


ContaPoupanca pp = new ContaPoupanca(666666, 666.66, new("Lu", 66666666666), 5.0);
var c = pp.ToString();
Console.WriteLine(c);

Console.ReadKey();











