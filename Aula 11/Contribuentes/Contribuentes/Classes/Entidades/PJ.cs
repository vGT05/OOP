
namespace Abstraction.Classes.Entidades
{
    internal class PJ : Contribuentes
    {
		private int funcionarios;


        public int NumeroFuncionarios
		{
			get { return funcionarios; }
			set { funcionarios = value; }
		}
        public PJ(string nomeCont, double rendaAnual, int numeroFuncionarios) : base(nomeCont, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }
        public override double Imposto()
        {
            double taxa;

            if (funcionarios < 10)
            {
                taxa = 0.16;
            }
            else
            {
                taxa = 0.14;
            }

            return RendaAnual * taxa;
        }
    }
}
