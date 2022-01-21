using System;

namespace FuncoesDoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = " ABC def GhI 092 BC    ";
            string p1 = original.ToUpper(); // Transforma tudo em maiúsculo
            string p2 = original.ToLower(); // Transforma tudo em minúsculo
            string p3 = original.Trim(); // Apaga espaços em branco antes e depois da string
            
            int n1 = original.IndexOf("BC"); // Irá buscar na string a 1° ocorrência de BC
            int n2 = original.LastIndexOf("BC"); // Irá buscar na string a ultima ocorrência de BC

            string p4 = original.Substring(3); // Corta a string a partir da posição informada

            string p5 = original.Substring(3, 6); // Corta a string da posição até o indice indicado

            string p6 = original.Replace('A', 'X'); // Troca todos os caracteres "A" por "X"
            string p7 = original.Replace("ABC", "Xy"); // Troca todos os caracteres "ABC" por "Xy"

            bool b1 = string.IsNullOrEmpty(original); // Irá testar se a variável é nula ou vazia
            bool b2 = string.IsNullOrWhiteSpace(original); // Verifica se variável é nula ou vários espaços em branco



            Console.WriteLine($"String original -{original}-\nString To Upper: -{p1}-" +
                $"\nString To Lower: -{p2}-\nString Trim: -{p3}-");
            Console.WriteLine();
            
            Console.WriteLine($"Index of 'BC': {n1}");
            Console.WriteLine($"Last of 'BC': {n2}");
            Console.WriteLine();

            Console.WriteLine($"String após ser cortada pelo substring(3): {p4}");
            Console.WriteLine($"String após ser cortada pelo substring(3) até indice 6: {p5}");
            Console.WriteLine();

            Console.WriteLine($"Substituindo caracteres 'A' por 'X' com Replace: {p6}");
            Console.WriteLine($"Substituindo caracteres 'ABC' por 'Xy' com Replace: {p7}");
            Console.WriteLine();

            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
        }
    }
}
