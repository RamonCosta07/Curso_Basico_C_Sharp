using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp";
            try
            {
                //Listar todas as sub pastas dentro da pasta indicada
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }
                //Listar todos os arquivos dentro da pasta indicada
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\newfolder"); // Criar nova pasta

            } catch (IOException e)
            {
                Console.WriteLine("An error ocurred" + e);
            }
        }
    }
}
