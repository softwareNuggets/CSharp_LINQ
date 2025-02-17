using System;
using System.Diagnostics;

namespace Linq_singleOrDefault
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var words = new Words();
			words.loadAllWords();
			words.loadCurrentWordSet(8);

			string[] numbers = { "one", "notthere" };
			for(int i=0;i<numbers.Length; i++)
			{
				var firstword = words.GetSingleOrDefault(numbers[i]);
				Console.WriteLine($"{firstword.En} = {firstword.Esl}");

			}

			Console.WriteLine("\n\n--------------------------\n\n");

			// Second Example, let reload the data to use CID=7
			// use wordset
			words.loadCurrentWordSet(7);

			string[] n2 = { "once", "zero" };
			for(int i=0;i<n2.Length;i++)
			{
				var firstWord = words.GetSingleOrDefault(n2[i]);
				if(firstWord != null)
				{
					Console.WriteLine
						($"\t\t{firstWord.En} = {firstWord.Esl}");
				}
                else
                {
					Console.WriteLine
						($"{n2[i]} = Message:= {words.GetErrorMessage()}");
				}
            }

		}
	}
}
