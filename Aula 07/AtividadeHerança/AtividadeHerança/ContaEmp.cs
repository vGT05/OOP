namespace AtividadeHerança
{
    internal class ContaEmp : Conta
    {
        private double limite;
        public double LimiteEmp
        {
            get { return LimiteEmp; }
            set { LimiteEmp = value; }
        }

        public ContaEmp(int numeroConta, string titularConta, double limiteEmp) : base(numeroConta, titularConta)
        {
            limite = limiteEmp;
        }

        public ContaEmp(int numeroConta, string titularConta, double saldoConta, double limiteEmp) : base(numeroConta, titularConta, saldoConta)
        {
            limite = limiteEmp;
        }


       

        public void Emprestimo(double quantia)
        {
            LimiteEmp -= quantia;
            SaldoConta += quantia;
        }














    }
}

