using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise28
{
    internal class ReverseString
    {
        public static void Main()
        {
            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("\nOriginal String: " + line);
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = line.Split(new[] {
                " "
                }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach (String s in wordsList)
            {

                Console.WriteLine("\nReverse String: " + s);
            }
        }
    }
}

