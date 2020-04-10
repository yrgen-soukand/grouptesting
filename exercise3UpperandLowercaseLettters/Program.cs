using System;

namespace exercise3UpperandLowercaseLettters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta sõna mida tahad modifikatseerida: ");
            string word = Console.ReadLine();
            Console.WriteLine(UpperAndLowerCase(word));
            Console.ReadLine();

        }

        public static string UpperAndLowerCase(string word)
        {
            string replacedWord = string.Empty;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                char c = word[i];
                if (Char.IsUpper(c))
                {
                    char small = char.ToLower(c);
                    replacedWord += small;
                }
                else
                {
                    char big = char.ToUpper(c);
                    replacedWord += big;
                }
               
            }
            return replacedWord;

            


        }
    }
}
