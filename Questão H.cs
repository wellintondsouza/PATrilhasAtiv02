using System;

namespace Projeto1
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite um numero:");
			double num1 = double.Parse (Console.ReadLine());

			
			double valorAbsoluto = Math.Abs(num1);
			 
			
			
				Console.WriteLine("A Raiz Quarada do número é de:" + valorAbsoluto);
				Console.ReadLine();
			
				  Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
		}
	}
}
