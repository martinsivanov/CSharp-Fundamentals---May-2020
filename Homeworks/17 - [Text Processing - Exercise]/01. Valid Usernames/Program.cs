using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string equal = string.Empty;
            string[] input = Console.ReadLine().Split(", ").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                for (int j = 0; j < current.Length; j++)
                {
                    char currLetter = (char)(current[j]);

                    if (current.Length >= 3 && current.Length <= 16 && (char.IsLetterOrDigit(current[j]) || current[j] == '-' || current[j] == '_'))
                    {
                        equal += currLetter;
                        if (equal == current)
                        {
                            sb.AppendLine(current);
                        }
                    }
                }
                equal = string.Empty;
            }
            Console.WriteLine(sb);
        }
    }
}
