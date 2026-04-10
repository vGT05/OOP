
using Contribuentes.Classes.Contratos;

namespace Contribuentes.Classes.Entidades
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

        public override void Imposto()
        {
            if (funcionarios < 10)
            {
                double imposto = RendaAnual * (16 / 100);
                return;
            }
            else if (funcionarios > 10)
            {
                double imposto = RendaAnual * (14 / 100);
                return;
            }
        }
    }
}
