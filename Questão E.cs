using System;

namespace Projeto1
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite um numero:");
			int num1 = int.Parse (Console.ReadLine());
			
			Console.WriteLine("Digite outro número: ");
			int num2 = int.Parse (Console.ReadLine());
			
			int divisão = num1 / num2;
			
			
			
				Console.WriteLine("A fatoração dos números é de:" + divisão);
				Console.ReadLine();
			
				  Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
		}
	}
