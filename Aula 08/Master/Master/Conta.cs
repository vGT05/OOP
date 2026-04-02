namespace Master
{
    internal class Conta :IOperacao
    {
        private Pessoa cliente;
        private int numero;
        private double saldo;

        public Conta(int numeroConta, double saldoConta, Pessoa dadosCliente)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
            DadosCliente = dadosCliente;
        }

        public int NumeroConta 
        {
            get { return numero; }
            set { numero = value; } 
        }
        public double SaldoConta 
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Pessoa DadosCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        
        public void Deposito(double qtd)
        {
            SaldoConta =+ qtd;
        }

        public void Saque(double qtd)
        {
            SaldoConta -= qtd;
        }
    }
}
