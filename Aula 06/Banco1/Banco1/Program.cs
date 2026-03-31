using Banco1;
using static System.Console;
using static System.ConsoleColor;

Title = "Cadastro de conta";
ContaBancaria conta;

ForegroundColor = Yellow;
Write("Entre com o numero da conta: ");
ResetColor();
string input = ReadLine();
if (!int.TryParse(input, out int n) || input.Length > 5)
{
    WriteLine("Número de conta inválido. Deve ter no máximo 5 dígitos.");
    return;
}

ForegroundColor = Yellow;
Write("Entre com o nome do titular da conta: ");
ResetColor();
string nome = ReadLine();

ForegroundColor = Green;
Write("Deseja fazer um depósito inicial? (s/n) ");
ResetColor();
char resposta = char.Parse(ReadLine().ToLower());

if (resposta == 's')
{
    ForegroundColor = Green;
    Write("Entre com o valor do depósito inicial: ");
    ResetColor();
    double dep = double.Parse(ReadLine());
    conta = new ContaBancaria(n, nome, dep);
}

else
{
    conta = new(n, nome);
}

conta.Dados();
ReadKey();