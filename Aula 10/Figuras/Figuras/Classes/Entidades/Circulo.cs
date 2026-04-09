
using Figuras.Classes.Enumerações;

namespace Figuras.Classes.Entidades
{
    internal class Circulo : Forma
    {
		private double raio;

        public double Raio
		{
			get { return raio; }
			set { raio = value; }
		}
        

        public Circulo(Cor corDaForma, double raio) : base(corDaForma)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return (Raio * Raio) * Math.PI;
        }
	}
}
