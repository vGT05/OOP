using Banco;
using static System.Console;
using static System.ConsoleColor;
using static System.Globalization.CultureInfo;

Title = "Abertura de conta";
ContaBancaria conta;

ForegroundColor = Green;
WriteLine("Abertura de conta - Nika Investment");
ResetColor();
Write("Entre com um número de conta: ");
int numero = int.Parse(ReadLine());
Write("Entre com o nome do titular: ");
ForegroundColor = Yellow;
string nome = ReadLine();
ResetColor();
Write("Deseja fazer um depósito inicial (s/n): ");
char resposta = char.Parse(ReadLine().ToLower());


if (resposta == 's')
{
    Write("Entre com o valor do depósito: R$");
    double deposito = double.Parse(ReadLine());
    
    conta = new ContaBancaria(numero, nome, deposito);   
}

else
{
    conta = new ContaBancaria(numero, nome);
}

conta.Dados();

WriteLine("Entre com um valor para depósito: ");
double quantia = double.Parse(ReadLine());
conta.Deposito(quantia);
WriteLine("Entre com um valor para saque: ");
quantia = double.Parse(ReadLine());
conta.Saque(quantia);
conta.Dados();

ReadKey();