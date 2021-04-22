using System;
using System.Text.RegularExpressions;

namespace _02.MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([*@])(?<tag>[A-Z][a-z]{2,})\1\:\s\[(?<gr1>[A-Za-z]+)\]\|\[(?<gr2>[A-Za-z]+)\]\|\[(?<gr3>[A-Za-z]+)\]\|$";

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string result = string.Empty;
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string tag = match.Groups["tag"].Value;
                    string gr1 = match.Groups["gr1"].Value;
                    string gr2 = match.Groups["gr2"].Value;
                    string gr3 = match.Groups["gr3"].Value;

                    result += gr1;
                    result += gr2;
                    result += gr3;
                    string commandsNumbers = string.Empty;
                    for (int j = 0; j < result.Length; j++)
                    {
                        int num = (char)(result[j]);
                        commandsNumbers += num + " ";
                    }
                    Console.WriteLine($"{tag}: {commandsNumbers}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
