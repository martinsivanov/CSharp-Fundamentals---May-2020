using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patern = new Regex(@"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b");

            string phones = Console.ReadLine();


            MatchCollection phoneCollections = patern.Matches(phones);

            List<string> list = new List<string>();

            foreach (var phone in phoneCollections)
            {
                list.Add(phone.ToString());
            }
            Console.WriteLine(String.Join(", ", list));
        }
    }
}
