using static System.Console;
namespace AtividadeHerança
{
    internal class ContaPoup : Conta
    {
        private double taxa;

        public double TaxaDeJuros
        {
            get { return taxa; }
            set { taxa = 0; }
        }

        public ContaPoup(string titularConta, int numeroConta, double Taxadd) : base(numeroConta, titularConta)
        {
            TaxaDeJuros = Taxadd;
        }
        public ContaPoup(string titularConta, int numeroConta, double saldoConta, double Taxadd) : base(numeroConta, titularConta, saldoConta)
        {
            TaxaDeJuros = Taxadd;
        }

        public void AtualizacaoDeSaldo()
        {
            SaldoConta = SaldoConta + (SaldoConta * TaxaDeJuros);
        }

        public override void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }

        public override string ToString()
        {
            return $"Dados do cliente.\n" +
                $"\n\tNome: {TitularConta}" +
                $"\n\tNúmero: {NumeroConta}" +
                $"\n\tSaldo: {SaldoConta}" +
                $"\n\tTaxa de Juros: {TaxaDeJuros}%";
        }






    }







}
