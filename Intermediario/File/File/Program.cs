using System;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt"; // caminho do arquivo. @ usado para não ter que
            //digitar duas barras invertidas no caminho do arquivo "\\"
            string targetPath = @"C:\temp\file2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // Copia de um arquivo para outro, caso ele não exista
                string[] lines = System.IO.File.ReadAllLines(sourcePath); // Cada linha será um elemento do vetor
                foreach(string i in lines)
                {
                    Console.WriteLine(i);
                }

            } catch (Exception e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
