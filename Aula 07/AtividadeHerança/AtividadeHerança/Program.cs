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
        WriteLine("Deseja fazer um depósito inicial? (s/n)");
        char escolha1 = char.Parse(ReadLine().ToLower());
        if (escolha1 == 's')
        {
            Write("Digite o valor do depósito: ");
            double deposito = double.Parse(ReadLine());
            conta = new Conta(numero, titular, deposito);
        }
        else
        {
            conta = new Conta(numero, titular);
        }
        conta.Consulta();
        
        WriteLine("Deseja fazer um saque?(s/n)");
        WriteLine("(O saque tem uma taxa fixa de R$5.00)");
        char escolha2 = char.Parse(ReadLine().ToLower());
        if (escolha2 == 's')
        {
            Write("Digite o valor do saque: ");
            double saque = double.Parse(ReadLine());
            conta.Saque(saque);
            conta.Consulta();
        }
        break;
    
    case 2:
        ContaPoup poupanca;
        Write("Digite o titular da conta: ");
        titular = ReadLine();
        Write("Digite o numero da conta: ");
        numero = int.Parse(ReadLine());
        WriteLine("Deseja fazer um depósito inicial? (s/n)");
        char escolha3 = char.Parse(ReadLine().ToLower());
        if (escolha3 == 's')
        {
            Write("Digite o valor do depósito: ");
            double deposito = double.Parse(ReadLine());

            Write("Digite o valor da taxa de de juros: ");
            double taxa = double.Parse(ReadLine());
            
            poupanca = new ContaPoup(titular, numero, deposito, taxa);
            
            poupanca.AtualizacaoDeSaldo();
            poupanca.ToString();
        }
        else
        {
            double taxa = 0;
            poupanca = new ContaPoup(titular, numero, taxa);
        }

        WriteLine("Deseja fazer um saque?(s/n)");
        char escolha4 = char.Parse(ReadLine().ToLower());
        if (escolha4 == 's')
        {
            Write("Digite o valor do saque: ");
            double saque = double.Parse(ReadLine());
            poupanca.Saque(saque);
            poupanca.Consulta();
        }
        break;
}
