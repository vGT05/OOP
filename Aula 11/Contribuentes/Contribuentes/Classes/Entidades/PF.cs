
namespace Contribuentes.Classes.Entidades
{
    internal class PF : Contribuentes
    {
		private double gasto;

        public double GastoSaude
		{
			get { return gasto; }
			set { gasto = value; }
		}
        public PF(string nomeCont, double rendaAnual, double gastoSaude) : base(nomeCont, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public void Gasto(double gasto)
        {
            if (GastoSaude > 0)
            {
                gasto = GastoSaude * (50 / 100);
                return;
            }
        }

        public override void Imposto()
        {
            if (RendaAnual < 20000)
            {
                double imposto = RendaAnual * (15 / 100);
                return;
            }
            else if (RendaAnual >= 20000)
            {
                double imposto = RendaAnual * (25 / 100);
                return;
            }
        }
    }
}
