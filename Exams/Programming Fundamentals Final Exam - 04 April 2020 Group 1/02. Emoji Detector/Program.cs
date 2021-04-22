using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([:]{2}|[*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string fullemoji = string.Empty;
            string input = Console.ReadLine();
            List<string> list = new List<string>();
            int coolSum = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    string a = input[i].ToString();
                    int number = int.Parse(a);
                    coolSum *= number;

                }
            }

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string emojibar = match.Groups["1"].Value;
                    string emoji = match.Groups["emoji"].Value;
                    int sumEmoji = 0;
                    for (int i = 0; i < emoji.Length; i++)
                    {
                        sumEmoji += emoji[i];
                    }


                    if (coolSum <= sumEmoji)
                    {
                        list.Add($"{emojibar}{emoji}{emojibar}");
                    }
                }
            }

            Console.WriteLine($"Cool threshold: {coolSum}");

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(String.Join(Environment.NewLine,list));
        }
    }
}
