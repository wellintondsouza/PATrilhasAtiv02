using System;

namespace Projeto1
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite um numero:");
			int num1 = int.Parse (Console.ReadLine());
			
			
				Console.WriteLine("Digite outro número:");
				int num2 = int.Parse(Console.ReadLine());
				
				int soma = num1 + num2;
			
				
				Console.WriteLine("A soma dos números é de:" + soma);
				Console.ReadLine();
			
		}
	}
}
