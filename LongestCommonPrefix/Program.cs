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
            int index = 0;
            int counter;
            StringBuilder result = new();
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
                    result.Append(words[0][index]);
                }
                else
                {
                    break;
                }
                index++;
            }
            return result.ToString();
        }
    }
}