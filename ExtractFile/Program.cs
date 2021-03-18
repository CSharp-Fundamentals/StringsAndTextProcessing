using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split((char)92);

            string fileWithExtension = path[path.Length-1];
            string[] tokens = fileWithExtension.Split(".");


            string extension = tokens[tokens.Length-1];
            string fileName = fileWithExtension.Replace($".{extension}","");

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
