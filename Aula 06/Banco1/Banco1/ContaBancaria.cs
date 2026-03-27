using System.ComponentModel.DataAnnotations;
using static System.Console;
namespace Banco1
{
    internal class ContaBancaria
    {
		private int numero;
		private string titular;
		private double saldo;
		
		public double Saldo
		{
			get { return saldo; }
			set
			{
				if (value > 0)
				{
					saldo = value;
				}
				else
				{
					saldo = 0;
				}
			}
		}
		public string Titular
		{
			get { return titular; }
			set { titular = value; }
		}
		public int Numero
		{
			get { return numero; }
			set { 
					if (Max)  
				
				
						numero = value; 
				}
		}

		public ContaBancaria(int numero, string titular)
		{
			Numero = numero;
			Titular = titular;
			Saldo = 0;
		}
		public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
			Saldo = saldo;
		}	

	 public void Deposito (double quantia)
		{
			Saldo += quantia;
		}

		public void Saque (double quantia)
		{
			Saldo -= quantia;
		}

		public void Dados()
		{
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine($"Dados da conta: \n" +
				$"\tNúmero: {Numero}\n" +
				$"\tTitular: {Titular}\n" +
				$"\tSaldo:{Saldo:C}");
			ResetColor();
		}


	}
}
