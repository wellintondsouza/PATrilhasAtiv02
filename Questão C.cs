using System;

namespace Projeto1
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite um numero:");
			int num1 = int.Parse (Console.ReadLine());
			
				
			int metade = num1 / 2;
			
				
				Console.WriteLine("A soma dos números é de:" + metade);
				Console.ReadLine();
			
				  Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
		}
	}
}
