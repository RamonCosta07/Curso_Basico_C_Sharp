﻿using System;
using System.IO;

namespace FileStreamExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file3.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open); // Abrirá o arquivo
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            } catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            } finally
            {
                if(fs != null)
                    fs.Close();
                if(sr != null)
                    sr.Close();
            }
        }
    }
}
