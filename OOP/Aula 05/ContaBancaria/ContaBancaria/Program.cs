using Banco;
using static System.Console;
using static System.ConsoleColor;
using static System.Globalization.CultureInfo;

Title = "Abertura de conta";
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
    
    ContaBancaria conta = new ContaBancaria(numero, nome, deposito);   
}

else
{
    ContaBancaria conta = new ContaBancaria(numero, nome);
}