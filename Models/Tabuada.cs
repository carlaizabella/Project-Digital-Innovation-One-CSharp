using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
	public class Tabuada
	{

		public void MetodoTabuada( int x )
		{
			for ( int i = 0; i < 11; i++)
			{
				
				Console.WriteLine($"{x} * {i} = { x * i }");
			}
		}
	}
}
