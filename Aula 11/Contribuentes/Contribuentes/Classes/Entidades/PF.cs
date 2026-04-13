using static System.Console;
namespace Abstraction.Classes.Entidades
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

        public double Gasto()
        {
            if (GastoSaude > 0)
            {

                gasto = GastoSaude * 0.5;
            }
            return gasto;
        }

        public override double Imposto()
        {
            double imposto;
            if (RendaAnual > 20000.0)
            {
                imposto = RendaAnual * 0.25;
            }
            else
            {
                imposto = RendaAnual * 0.15;
            }
            return imposto;
        }

    }
}