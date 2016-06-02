using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSquare
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arrLinesN = {
				"SATORAREPOTENETOPERAROTAS",	//true
				"NOTSQUARE",	//false
				"ABCDBEFGCFHIDGIJ",	//true
				"ABCDBEGGCFHIDGIJ",	//false				
				"LEVELELDERVDORAEERIELRAES",	//true
				"LEVELELZERVKORBEERIELRAES",	//false				
				"ABBC",	//true
				"ABDC",	//false
				"ABCBDECEF",	//true
				"ABCHDECEF",	//false
				"BITICETEN",	//true 
				"CARDAREAREARDART",	//true
				"AAAAACEEELLRRRTT",	//true
				"AAACCEEEEHHHMMTT",	//true
				"AAACCEEEEHHHMMTTXXX", //false
				"ABCD", //false
				"ABC",	//false
				"GHBEAEFGCIIDFHGG", //true
				(
				"ABCDEFG" +
				"BCDEFGH" +
				"CDEFGHI" +
				"DEFGHIJ" +
				"EFGHIJK" +
				"FGHIJKL" +
				"GHIJKLM"
				), //true
				"AAAAAABBBBABCCCABCDDABCDE", //true
				("PQDA" +
				"QBBB" +
				"EBCC" +
				"ABCD" +
				"E"),	//false
				"AAAA"	//true
			};

			string[] arrLines1 = {
				"AAAA"
			};			
			
			string[] arrLines = arrLinesN;
			for (int i=0; i<arrLines.Length; i++) {
				Console.WriteLine("{0}:\t{1}", arrLines[i], canFormWordSquare2(arrLines[i]));
			}
			
			//immWin();
			Console.WriteLine("Press anykey to exit ...");
			//Console.Read();
		}
		
		static void immWin() {
			//char[] ltrs = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K'};
			int size = 10, j;
			for (int i=0; i<26; i++) {
				j = 65 + i;
				Console.WriteLine("{0}, {1}, {2}", (char)j, j % 26, (j % 26) % size);
			}
		}
		
		static bool isWordSquare(string letters) {
			int len = letters.Length;
			int n = (int)Math.Round(Math.Sqrt(len));
			if (len != n*n) return false;
			
			int row, col, j;
			for (int i=0; i<len; i++) {
				row = i / n;
				col = i - (row * n);
				
				// calculate the mirror index for a given index
				// along the diagnoal of a square
				j = col*n + row;
				// if the index is in the top right of the triangle area of a square
				// that is the index is less than the corresponding mirror index				
				if (i < j) {
					// if the character at the index has a mirror
					if (letters[i] != letters[j]) return false;
				}
			}
			
			// if we checked through all approp. characters
			// then return true
			return true;
		}
		
		static bool canFormWordSquare(string letters) {
			int len = letters.Length;
			int n = (int)Math.Round(Math.Sqrt(len));
			if (len != n*n) return false;
			
			// maximum number of unique characters we expect for a given n
			int maxChrs = n + (len - n)/2;
			Dictionary<char, int> counts = new Dictionary<char, int>(maxChrs);
			
			// get the counts
			char c;
			for (int i=0; i<len; i++) {
				c = letters[i];
				if (counts.ContainsKey(c)) {
					counts[c]++;
				}
				else {
					counts.Add(c, 1);
				}
			}

			// if we have more than the unique # of characters allowed for the square size
			if (counts.Keys.Count() > maxChrs) return false;
			
			int oddChrs = 0;
			foreach(char kc in counts.Keys) {
				if (counts[kc] % 2 == 1) oddChrs++;
			}
			
			return (oddChrs <= n); 
		}

		static bool canFormWordSquare2(string letters) {
			int len = letters.Length, 
				n = (int)(Math.Sqrt(len)),
				j=0, //index for the array
				oc=0, //count of characters that occur odd # of times
				uc=0, //count of unique characters in the given string
				// ml - unique # of characters allowed for the square size				
				ml = n + (len - n)/2;
			if (len != n*n) return false;
									
			// get the counts
			int[] counts = new int[26];
			for (int i=0; i<len; i++) {
				j = letters[i] - 'A';
				counts[j]++;
			}

			// find the counts of each character
			for (int i=0; i<26; i++) {
				if (counts[i] > 0) uc++;
				if (counts[i] % 2 == 1) oc++; 
			}			
			
			// unique character count is <= max allowed for the square size
			// and # of odd characters is less than square size
			return (uc <= ml && oc <= n); 
		}					
	}
}
