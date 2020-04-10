using System;
using System.Collections.Generic;
using System.IO; //vajalik et kasutada StreamReader ja StreamWriter

namespace Excercise4StreamReaderStreamWriter
{
    public class Program
    {
        static void Main(string[] args)
        {

            

            string line;
            using (StreamReader reader = new StreamReader("list.txt")) //failinimi 1 sõnaline alati
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                    myList.Add(line);
                }
 
            }

            foreach (string value in myList)
                Console.WriteLine(value);   

            Console.WriteLine("\n");
            myList.Sort();
            foreach (string value in myList)
                Console.WriteLine(value);
            Console.WriteLine("\n");

            using (StreamWriter writer = new StreamWriter("sortedList.txt",false)) //false kirjutatakse üle //true kirjutatakse uuesti
            {
                writer.WriteLine("test");
                foreach (string copy in myList)
                    writer.WriteLine(copy);
            }

            Console.ReadLine();
        }
    }
}
