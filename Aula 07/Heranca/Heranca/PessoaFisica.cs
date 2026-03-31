using static System.Console;
using static System.ConsoleColor;
namespace Heranca
{
    internal class PessoaFisica
    {
        private int numero;
        private string titular;
        private double saldo;

        public PessoaFisica(int numeroConta, string titularConta) : this(numeroConta, titularConta, 0)
        {
            SaldoConta = 0;
        }

        public PessoaFisica(int numeroConta, string titularConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }



        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }
        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }

        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }

        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }

        public override string ToString()
        {
            return $"Dados do cliente: " +
                $"\n\t Número da conta: {NumeroConta}" +
                $"\n\t Titular da conta: {TitularConta}" +
                $"\n\t Saldo da conta: {SaldoConta:C}";

        }

    }
}
