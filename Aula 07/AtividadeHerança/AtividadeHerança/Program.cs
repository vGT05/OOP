using AtividadeHerança;
using static System.Console;

Conta contaBanc;

WriteLine("Abertura de conta --Banco Master--");
WriteLine("Digite [1] para abrir uma conta comum, [2] para abrir uma conta poupança, ou [3] para abrir uma conta empresarial");

int opcao = int.Parse(ReadLine());
switch (opcao)
{
    case 1:
        Conta conta;
        Write("Digite o titular da conta: ");
        string titular = ReadLine();
        Write("Digite o numero da conta: ");
        int numero = int.Parse(ReadLine());
        Write("Deseja fazer um depósito inicial? (s/n)");
        char escolha = char.Parse(ReadLine().ToLower());
            if (escolha == 's')
        {
            Write("Digite o valor do depósito ");
            double deposito = double.Parse(ReadLine());
            conta = new Conta(numero, titular, deposito);
        }
            else
        {
            conta = new Conta(numero, titular);
        }








    
        
     break;
}
