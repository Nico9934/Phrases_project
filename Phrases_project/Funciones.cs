using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases_project
{
	internal class Funciones
	{
		public static int char_counter(string phrase)
		{
			int count = phrase.Length;
			return count;
		}
		public static int space_counter(string phrase)
		{
			int count = 0;  
			foreach (char s in phrase)
			{
				if (s.ToString() == " ") count = count + 1;
			}
			return count;
		}
		public static string started_word(string phrase)
		{
			string first_word = phrase.Split(' ')[0];
			return first_word;
		}
		public static string finish_word(string phrase)
		{

			string[] words = phrase.Split(" ");
			string last_word = words[words.Length - 1];
			return last_word;
		}
	}
}
