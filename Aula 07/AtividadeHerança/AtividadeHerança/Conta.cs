using static System.Console;
namespace AtividadeHerança
{
    internal class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

        public Conta(int numeroConta, string titularConta) : this(numeroConta, titularConta, 0)
        {
            SaldoConta = 0;
        }

        public Conta(int numeroConta, string titularConta, double saldoConta)
        {
            SaldoConta = saldoConta;
            TitularConta = titularConta;
            NumeroConta = numeroConta;
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


        public void Deposito(double quantia)
        {
            saldo += quantia;
        }

        public virtual void Saque(double quantia) 
        {                                         
            //colocar virtual no método permite que ele possa ser sobreescrito por outro método
            //sealed faz o oposto, permite que o código não possa ser sobreescrito de qualquer maneira
            saldo -= quantia + 5.00;
        }
            
        public override string ToString()
        {
            return $"Dados do cliente.\n" +
                $"\n\tNome: {TitularConta}" +
                $"\n\tNúmero: {NumeroConta}" +
                $"\n\tSaldo: {SaldoConta:C}";
        }









    }
}
