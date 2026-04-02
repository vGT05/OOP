namespace Master
{
    internal class ContaPJ : Conta
    {
        private double limite;

        public double LimiteConta
		{
			get { return limite; }
			set { limite = value; }
		}
        public ContaPJ(int numeroConta, double saldoConta, Pessoa dadosCliente, double Limite) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = Limite;
        }

        public void Emprestimo(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd;
        }


	}
}
