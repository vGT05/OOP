
using Contribuentes.Classes.Contratos;

namespace Contribuentes.Classes.Entidades
{
    abstract internal class Contribuentes : IImposto
    {
		private string nome;
		private double renda;

        public string NomeCont
		{
			get { return nome; }
			set { nome = value; }
		}
		public double RendaAnual
		{
			get { return renda; }
			set { renda = value; }
		}
        protected Contribuentes(string nomeCont, double rendaAnual)
        {
            NomeCont = nomeCont;
            RendaAnual = rendaAnual;
        }

        public abstract void Imposto();
    }
}
