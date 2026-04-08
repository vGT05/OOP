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
        WriteLine(conta.ToString());
        
        WriteLine("Deseja fazer um saque?(s/n)");
        WriteLine("(O saque tem uma taxa fixa de R$5.00)");
        char escolha2 = char.Parse(ReadLine().ToLower());
        if (escolha2 == 's')
        {
            Write("Digite o valor do saque: ");
            double saque = double.Parse(ReadLine());
            conta.Saque(saque);
            WriteLine(conta.ToString());
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
            poupanca.Consulta();
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
    case 3:
        ContaEmp empresa;
        Write("Digite o titular da conta: ");
        titular = ReadLine();
        Write("Digite o numero da conta: ");
        numero = int.Parse(ReadLine());
        WriteLine("Deseja fazer um depósito inicial? (s/n)");
        char escolha5 = char.Parse(ReadLine().ToLower());
        if (escolha5 == 's')
        {
            Write("Digite o valor do depósito: ");
            double deposito = double.Parse(ReadLine());

            Write("Digite o valor do limite de empréstimo: ");
            double limite = double.Parse(ReadLine());

            empresa = new ContaEmp(numero, titular, deposito, limite);   
        }
        else
        {
            double limite = 0;
            empresa = new ContaEmp(numero, titular, limite);
        }
        WriteLine(empresa.ToString());

        WriteLine("Deseja fazer um empréstimo(s/n)");
        char escolha6 = char.Parse(ReadLine().ToLower());
        if (escolha6 == 's')
        {
            Write("Digite o valor do empréstimo: ");
            double emprestimo = double.Parse(ReadLine());
            empresa.Emprestimo(emprestimo);
            WriteLine(empresa.ToString());
        }
        break;
}
