using static System.Console;
namespace DepartamentoPEssoal.Classes.Entidades
{
    internal class Terceiro : Funcionario
    {
		private double despesa;


        public double DespesaAdicional
		{
			get { return despesa; }
			set { despesa = value; }
		}

        public Terceiro(string nomeColaborador, int jornadaTrabalho, double valorHora, double despesa) : base(nomeColaborador, jornadaTrabalho, valorHora)
        {
            DespesaAdicional = despesa;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }
	}
}
