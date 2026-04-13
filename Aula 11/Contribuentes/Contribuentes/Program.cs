using Abstraction.Classes.Entidades;
using System.Numerics;
using static System.Console;
List<Contribuentes> lista = new();
Write("Digite a quantidade de contribuentes: ");
int qtd = int.Parse(ReadLine());
for (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do contribuente Nº {i}.");
    WriteLine("O contribuente é PF[1] ou PJ[2]?");
    int escolha = int.Parse(ReadLine());
    if (escolha == 1)
    {
        Write("Nome do contribuente: ");
        string nome = ReadLine();
        Write("Renda anual do contribuente: ");
        double renda = double.Parse(ReadLine());
        Write("Gasto com saúde do contribuente: ");
        double gasto = double.Parse(ReadLine());

        lista.Add(new PF(nome, renda, gasto));

    }
    else if (escolha == 2)
    {
        Write("Nome do contribuente: ");
        string nome = ReadLine();
        Write("Renda anual do contribuente: ");
        double renda = double.Parse(ReadLine());
        Write("Digite o número de funcionários: ");
        int funcionarios = int.Parse(ReadLine());

        lista.Add(new PJ(nome, renda, funcionarios));
    }
}
WriteLine("Impostos pagos: ");
double total = 0;

foreach (Contribuentes cont in lista)
{
    double imposto = cont.Imposto();
    WriteLine($"{cont.NomeCont}: {imposto:C}");
    total += imposto;
}
WriteLine($"Total de Impostos: {total:C}");