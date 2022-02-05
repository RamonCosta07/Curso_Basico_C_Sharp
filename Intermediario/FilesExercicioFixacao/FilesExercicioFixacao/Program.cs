using System;
using System.IO;
using System.Globalization;
using FilesExercicioFixacao.Entities;

/* Necessário antes de executar o programa criar um arquivo
 * na pasta que será informada com os seguintes dados:
 * TV LED,1290.99,1
   Video Game Chair,350.50,3
   Iphone X,900.00,2
   Samsung Galaxy 9,850.00,2
*/

namespace FilesExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string targetFolderPath = Path.GetDirectoryName(sourceFilePath) + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}