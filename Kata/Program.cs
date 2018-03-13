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
		private static readonly int ROTIndex = 13;
		private static readonly string LetterWords = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		private static Dictionary<string, string> LetterDictionary = new Dictionary<string, string>();

		public static string Rot13(string input)
		{
			InitialLetterCollection();

			string result = string.Empty;
			
			input.ToCharArray().ToList().ForEach(item =>
			{
				result = string.Concat(result, ConvertLetter(item.ToString()));
			});

			return result;
		}
		private static string ConvertLetter(string input)
		{
			if (LetterDictionary.ContainsKey(input))
			{
				return LetterDictionary[input];
			}
			return input;
		}

		private static void InitialLetterCollection()
		{
			LetterWords.ToList().ForEach( item =>
			{
				LetterDictionary.Add(item.ToString(), ROTLetter(item.ToString()));
				LetterDictionary.Add(item.ToString().ToLower(), ROTLetter(item.ToString()).ToLower());
			});
		}

		private static string ROTLetter(string input)
		{
			var letterIndex = LetterWords.IndexOf(input.ToString());

			if (letterIndex < 0)
			{
				return input.ToString();
			}
			else
			{
				var newLetterIndex = (letterIndex >= ROTIndex) ? letterIndex -= ROTIndex : letterIndex += ROTIndex;
				return LetterWords.ElementAt(newLetterIndex).ToString();
			}
		}
	}
}
