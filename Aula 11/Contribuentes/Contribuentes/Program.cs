using Contribuentes.Classes.Entidades;
using System.Runtime.CompilerServices;
using static System.Console;

Write("Digite a quantidade de contribuentes: ");
int qtd = int.Parse(ReadLine());

for  (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do contribuente Nº {i}.");
    WriteLine("O contribuente é PF[1] ou PJ[2]?");
    int escolha = int.Parse(ReadLine());
    if (escolha == 1)
    {
        Write("Digite o nome do contribuente: ");
        string nome = ReadLine();
        Write("Digite o saldo anual do contribuente: ");
        double saldo = double.Parse(ReadLine());
        Write("Digite o gasto com saúde do contribuente: ");
        double gasto = double.Parse(ReadLine());
        PF.Gasto(gasto);
    }
}