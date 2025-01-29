using System;

namespace Projeto1
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite um numero:");
			int num1 = int.Parse (Console.ReadLine());

			Console.WriteLine("Digite um numero:");
			int num2 = int.Parse (Console.ReadLine());
			
			int subtracao = num2 - num1;
			 
			
			
				Console.WriteLine("A Raiz Quarada do número é de:" + subtracao);
				Console.ReadLine();
			
				  Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
		}
	}
}
