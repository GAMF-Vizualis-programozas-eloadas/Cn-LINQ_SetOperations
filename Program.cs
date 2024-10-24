using System;
using System.Collections.Generic;
using System.Linq;

namespace CnLINQ_SetOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> A = new List<int> { 1, 2, 3, 4, 5, 6 };
			List<int> B = new List<int> { 1, 2, 3, 7, 8, 9 };
			Console.WriteLine("A= " + A.Aggregate("", (a, b) => a + b + ", "));
			Console.WriteLine("B= " + B.Aggregate("", (a, b) => a + b + ", "));
			Console.WriteLine("A Union B= " + 
				A.Union(B).Aggregate("", (a, b) => a + b + ", "));
			Console.WriteLine("A Intersect B= " + 
				A.Intersect(B).Aggregate("", (a, b) => a + b + ", "));
			A.Reverse();
			Console.WriteLine("Reverse A= " + A.Aggregate("", (a, b) => a + b + ", "));
		}

	}

}
