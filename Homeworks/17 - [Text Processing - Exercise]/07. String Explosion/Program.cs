using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int power = 0;
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];

                if (current == '>')
                {

                    power += int.Parse(text[i + 1].ToString());
                    sb.Append(current);

                }
                else if (power == 0)
                {
                    sb.Append(current);

                }
                else
                {
                    power--;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
