using System;
using System.Text;

namespace LongestCommonPrefix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = { "flower","fkow" };
            Console.WriteLine(LongestCommonIndex(words));
        }

        public static string LongestCommonIndex(string[] words)
        {
            string result = "";
            int index = 0;
            int counter;
            StringBuilder tmp_string = new();
            while (index < words[0].Length)
            {
                counter = 0;
                for (int j = 0; j < words.Length; j++)
                {
                    if (index < words[j].Length && words[0][index] == words[j][index])
                    {
                        counter++;
                    }
                }
                if (counter == words.Length)
                {
                    tmp_string.Append(words[0][index]);
                }
                else
                {
                    tmp_string.Clear();
                    break;
                }
                if (tmp_string.Length > result.Length)
                {
                    result = tmp_string.ToString();
                }
                index++;
            }
            return result;
        }
    }
}