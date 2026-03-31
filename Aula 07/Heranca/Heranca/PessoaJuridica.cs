namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
        private double limite;

        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        public PessoaJuridica(int numeroConta, string titularConta, double limiteConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public PessoaJuridica(int numeroConta, string titularConta, double saldoConta, double limiteConta) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limiteConta;
        }


        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }






    }
}