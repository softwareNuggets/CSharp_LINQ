using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_singleOrDefault
{
	public class AppWordSet
	{
		public int Uid { get; set; }
		public int Cid { get; set; }
		public int Wid { get; set; }
		public string En { get; set; }
		public string Esl { get; set; }
		public string Ess { get; set; }
	}

	public class AppWordSetData
	{

		public List<AppWordSet> loadCurrentSet(int cid)
		{
			List<AppWordSet> allWords = loadAllWords();
			return allWords.Where(p => p.Cid == cid).OrderBy(p => p.Wid).ToList();
		}

		
		public List<AppWordSet> loadAllWords()
		{
			var words = new List<AppWordSet>()
			{
				// 7
				new AppWordSet { Uid=80, Cid=7, Wid=1, En="black", Esl="negro"  , Ess="negro" } ,
				new AppWordSet { Uid=81, Cid=7, Wid=2, En="blue", Esl="azul"  , Ess="azul" } ,
				new AppWordSet { Uid=82, Cid=7, Wid=3, En="brown", Esl="marrón"  , Ess="marrón" } ,
				new AppWordSet { Uid=83, Cid=7, Wid=4, En="green", Esl="verde"  , Ess="verde" } ,
				new AppWordSet { Uid=84, Cid=7, Wid=5, En="orange", Esl="naranja"  , Ess="naranja" } ,
				new AppWordSet { Uid=85, Cid=7, Wid=6, En="pink", Esl="rosado"  , Ess="rosa" } , // Y
				new AppWordSet { Uid=86, Cid=7, Wid=7, En="purple", Esl="morado"  , Ess="morado" } ,
				new AppWordSet { Uid=87, Cid=7, Wid=8, En="red", Esl="rojo"  , Ess="rojo" } ,
				new AppWordSet { Uid=88, Cid=7, Wid=9, En="white", Esl="blanco"  , Ess="blanco" } ,
				new AppWordSet { Uid=89, Cid=7, Wid=10, En="yellow", Esl="amarillo"  , Ess="amarillo" } ,

				new AppWordSet { Uid=81, Cid=7, Wid=2, En="grey", Esl="gris"  , Ess="gris" } ,
				new AppWordSet { Uid=82, Cid=7, Wid=3, En="rust", Esl="óxido"  , Ess="óxido" } ,
				new AppWordSet { Uid=83, Cid=7, Wid=4, En="copper", Esl="cobre"  , Ess="cobre" } ,
				new AppWordSet { Uid=84, Cid=7, Wid=5, En="silver", Esl="plateado"  , Ess="plateado" } ,
				new AppWordSet { Uid=85, Cid=7, Wid=6, En="gold", Esl="dorado"  , Ess="dorado" } , // Y
				new AppWordSet { Uid=403, Cid=7, Wid=4, En="turquoise", Esl="turquesa"  , Ess="turquesa" } ,
				new AppWordSet { Uid=404, Cid=7, Wid=5, En="violet", Esl="violeta"  , Ess="violeta" } ,
				new AppWordSet { Uid=406, Cid=7, Wid=7, En="ivory", Esl="marfil"  , Ess="marfil" } ,
				new AppWordSet { Uid=407, Cid=7, Wid=8, En="magenta", Esl="magenta"  , Ess="magenta" } ,

				new AppWordSet { Uid=410, Cid=8, Wid=1, En="zero", Esl="cero"  , Ess="cero" } ,
				new AppWordSet { Uid=411, Cid=8, Wid=2, En="one", Esl="uno"  , Ess="uno" } ,
				new AppWordSet { Uid = 412, Cid = 8, Wid = 3, En = "two", Esl = "dos", Ess = "dos" } ,
				new AppWordSet { Uid = 413, Cid = 8, Wid = 4, En = "three", Esl = "tres", Ess = "tres" } ,
				new AppWordSet { Uid = 414, Cid = 8, Wid = 5, En = "four", Esl = "cuatro", Ess = "cuatro" } ,
				new AppWordSet { Uid = 415, Cid = 8, Wid = 6, En = "five", Esl = "cinco", Ess = "cinco" } ,
				new AppWordSet { Uid = 416, Cid = 8, Wid = 7, En = "six", Esl = "seis", Ess = "seis" } ,
				new AppWordSet { Uid = 417, Cid = 8, Wid = 8, En = "seven", Esl = "siete", Ess = "siete" } ,
				new AppWordSet { Uid = 418, Cid = 8, Wid = 9, En = "eight", Esl = "ocho", Ess = "ocho" } ,
				new AppWordSet { Uid = 419, Cid = 8, Wid = 10, En = "nine", Esl = "nueve", Ess = "nueve" } ,
				new AppWordSet { Uid = 421, Cid = 8, Wid = 1, En = "ten", Esl = "diez", Ess = "diez" } ,
				new AppWordSet { Uid = 422, Cid = 8, Wid = 2, En = "eleven", Esl = "once", Ess = "once" } ,
				new AppWordSet { Uid = 423, Cid = 8, Wid = 3, En = "twelve", Esl = "doce", Ess = "doce" } ,
				new AppWordSet { Uid = 424, Cid = 8, Wid = 4, En = "thirteen", Esl = "trece", Ess = "trece" } ,
				new AppWordSet { Uid = 425, Cid = 8, Wid = 5, En = "fourteen", Esl = "catorce", Ess = "catorce" } ,
				new AppWordSet { Uid = 426, Cid = 8, Wid = 6, En = "fifteen", Esl = "quince", Ess = "quince" } ,
				new AppWordSet { Uid = 427, Cid = 8, Wid = 7, En = "sixteen", Esl = "dieciséis", Ess = "dieciséis" } ,
				new AppWordSet { Uid = 428, Cid = 8, Wid = 8, En = "seventeen", Esl = "diecisiete", Ess = "diecisiete" } ,
				new AppWordSet { Uid = 429, Cid = 8, Wid = 9, En = "eighteen", Esl = "dieciocho", Ess = "dieciocho" } ,
				new AppWordSet { Uid = 430, Cid = 8, Wid = 10, En = "nineteen", Esl = "diecinueve", Ess = "diecinueve" }
			};

			
			return (words);
		}
	}

	
}
