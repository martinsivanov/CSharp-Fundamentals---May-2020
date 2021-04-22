using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool charLenght = CheckCharacters(password);
            bool LetterDigits = CheckLettersAndDigits(password);
            bool TwoDigitsAtLast = CheckTwoDigits(password);
            if (charLenght && LetterDigits && TwoDigitsAtLast)
            {
                Console.WriteLine("Password is valid");
            }
            if (!charLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!LetterDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!TwoDigitsAtLast)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


        }

        static bool CheckTwoDigits(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                int curr = password[i];
                if (curr >= 48 && curr <= 57)
                {
                    counter++;

                }

            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckCharacters(string password)
        {
            // S o f t u n i
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char currChar = password[i];
                count++;

            }
            if (count <= 10 && count >= 6)
            {
                return true;
            }
            else
            {
                return false;

            }


        }
        static bool CheckLettersAndDigits(string password)
        {
            bool check = false;
            int check2 = 0;
            for (int i = 0; i < password.Length; i++)
            {

                int curr = password[i];
                if ((curr >= 48 && curr <= 57) || (curr >= 65 && curr <= 90) || (curr >= 97 && curr <= 122))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    check2++;
                }
            }
            if (check2 > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
