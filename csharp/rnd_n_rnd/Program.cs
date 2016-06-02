using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://codefights.com/challenge/4kTs8etaaLh3cpPS4/main
namespace Round_and_Round
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] arrInputs = {

			};			
			
			for (int i=0; i<arrInputs.Length; i++) {
				int n = arrLines[i][0],
				    a = arrLines[i][1],
				    b = arrLines[i][2];
				Console.WriteLine("({0}, {1}, {2}) => {3}", n, a, b, getRound_and_Round(n, a, b));
			}
			
			//immWin();
			Console.WriteLine("Press anykey to exit ...");
			//Console.Read();
		}		
		
		static int getRound_and_Round(int n, int a, int b) {
		    // if b > n, then we only need the actual offset
		    // so we use b%n to calculate the final door, c
		    int c = a + b%n;

		    // if c is greater than n then we just need the offset
		    // else if c is greater than 0 then we just use it as is
		    // otherwise we need to add it to the n to get the offset
		    // in the reverse direction
		    return (c > n)? (c % n) : a>0? a : n+a;
		}							
	}
}
