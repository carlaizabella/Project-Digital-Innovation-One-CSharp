using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;


//CalculadoraProjectDigitalInnovationOne cal = new CalculadoraProjectDigitalInnovationOne();

//Tabuada tabu = new Tabuada();



string opcao;

while (true)
{
	Console.WriteLine("Digite  a sua opção: ");
	Console.WriteLine("1 - Cadastrar cliente");
	Console.WriteLine("2 - Buscar cliente");
	Console.WriteLine("3 - Apagar cliente");
	Console.WriteLine("4 - Encerrar");

	opcao = Console.ReadLine();

	switch (opcao)
	{
		case "1":
			Console.WriteLine("Cadastro do cliente");
			break;

		case "2":
			Console.WriteLine("Busca de cliente");
			break;
		case "3":
			Console.WriteLine("Apagar cliente");
			break;
		case "4":
			Console.WriteLine("Encerrar");
			Environment.Exit(0);
			break;
		default:
			Console.WriteLine("Opção inválida!");
			break;
	}
}









//cal.Somar(10, 8) ;
//cal.Subtrair(10,50);
//cal.Mutiplicar(15, 45);
//cal.Dividir(2, 2);
//cal.Modular(8, 3);
//cal.OperadorPotencia(2, 3);
//cal.Seno(30);
//cal.Coseno(30);
//cal.Tangente(30);
//
//cal.RaizQuadrada(64);
//tabu.MetodoTabuada(2);

