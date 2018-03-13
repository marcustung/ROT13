using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Kata.Rot13("ROT13 example."));
			Console.ReadKey();
		}
	}

	public class Kata
	{
		private static Dictionary<string, string> dic = new Dictionary<string, string>();
		static string[] key = { "A","B","C","D","E","F","G","H","I","J","K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W","X","Y","Z" };
		static string[] value = { "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" };
		
		private static void initDictionary()
		{
			for (int i = 0; i < key.Length; i++)
			{
				dic.Add(key[i], value[i]);
				dic.Add(key[i].ToLower(), value[i].ToLower());
			}
		}

		public static string Rot13(string input)
		{
			initDictionary();
			StringBuilder sb = new StringBuilder();

			var splitString = input.ToCharArray();
			for (int i = 0; i < splitString.Length; i++)
			{
				sb.Append(conventChar(splitString[i]));
			}
			return sb.ToString() ;
	    }

		private static string conventChar(char input)
		{
			var code = input.ToString();
			if (dic.ContainsKey(code))
			{
				return dic[code];
			}
			return code;
		}
	}
}
