using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExercise4.CouchProg
{
    class Program
    {
        public static string statusLog;

        static void Main(string[] args)
        {

            statusLog = WriteToFile();
            Console.WriteLine(statusLog);
            statusLog = ReadFromFile();
            Console.WriteLine(statusLog);
            Console.ReadLine();

        }

        public static string WriteToFile()
        {
            // create a writer and open the file
            TextWriter elScribe = new StreamWriter("date.txt");

            // condition to be evaluated
            for (int i = 0; i < 25; i++)
            {
                // write a line of text to the file
                elScribe.WriteLine(DateTime.Now);
            }

            // closing the stream
            elScribe.Close();
            return "File Has Been Created " + DateTime.Now;
        }

        public static string ReadFromFile()
        {
            TextReader textReader = new StreamReader("date.txt");

            Console.WriteLine(textReader.ReadLine());

            textReader.Close();

            return "Text Has Been Read From @ " + DateTime.Now;
        }

    }
}
