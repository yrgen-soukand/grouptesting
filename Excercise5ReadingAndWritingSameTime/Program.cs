using System;
using System.Collections.Generic;
using System.IO;
namespace Excercise5ReadingAndWritingSameTime
{
    class Program
    {
        static void Main(string[] args)
        {


            string line;
            int questionNr = 1;

            using (StreamReader reader = new StreamReader("questions.txt"))
            {
                using (StreamWriter writer = new StreamWriter("anwsers.txt", true))
                {
                    Console.WriteLine("Sisesta enda nimi: ");
                    writer.WriteLine("Nimi: " + Console.ReadLine());

                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();                        
                        Console.WriteLine(line);                      
                        writer.WriteLine(questionNr +". " +Console.ReadLine());
                        questionNr = questionNr +1;
                    }

                    writer.WriteLine("\n" );
                }
            }
            Console.WriteLine("Thank you for answering.");
            Console.ReadLine();


        }
    }
}
