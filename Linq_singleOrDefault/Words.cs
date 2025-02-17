using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_singleOrDefault
{
	public class Words
	{
		public List<AppWordSet> AllWords { get; set; }
		public string? _errorMessage { get; set; } = null;

		public string GetErrorMessage()
		{
			return _errorMessage;
		}

		public void loadAllWords()
		{
			AppWordSetData data = new AppWordSetData();
			AllWords = data.loadAllWords();

		}

		public void loadCurrentWordSet(int cid)
		{
			AppWordSetData data = new AppWordSetData();		
			AllWords = data.loadCurrentSet(cid);
		}

		public AppWordSet GetSingleOrDefault(string englishWord)
		{
			var defaultValue = new AppWordSet
			{
				En = englishWord,
				Esl = "default value not translated",
				Ess = "default value not translated",
				Cid = 0,
				Wid = 0
			};

			_errorMessage = null;

			try
			{
				AppWordSet? singleWord = AllWords.SingleOrDefault(p => p.En.ToUpper().Trim() == englishWord.ToUpper().Trim());

				// If no match is found, return defaultValue
				if (singleWord == null)
				{
					return defaultValue;
				}

				// Otherwise, return the found word
				return singleWord;
			}
			catch (Exception ex)
			{
				_errorMessage = ex.Message;

				// Return defaultValue if an error occurs
				return defaultValue;
			}

		}
	}
}
