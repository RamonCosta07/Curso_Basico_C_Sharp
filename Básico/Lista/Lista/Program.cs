using System;
using System.Collections.Generic; // Para poder utilizar Lista

namespace Lista
{
    class Program
    {
        /* Vantagens da Lista:
         * Tamanho variável
         * Facilidade para adicionar e remover elementos
         * Desvantagem: Acesso sequencial aos elementos
         */
        static void Main(string[] args)
        {
            List<String> lista = new List<string>();
            //Ela inicia vazia. Não é obg instanciar na criação
            List<String> lista2 = new List<string> { "Maria", "João" }; // colocar elementos na criação
            lista.Add("Victor"); // Adicionar elementos no final da lista, um de cada vez
            lista.Add("Mônica");
            lista.Add("Roger");
            lista.Add("Erick");
            lista.Insert(3, "Lavínia"); // insert da pra escolher a posição da lista a ser adicionada
            lista.Add("Renato");
            lista.Add("Kiara");
            lista.Add("Alice");
            lista.Add("Guilherme");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine($"Tamanho da Lista: {lista.Count}");
            Console.WriteLine();
            string s1 = lista.Find(x => x[0] == 'E');
            // Quero um objeto x, tal que x na posição 0 = ao caracter E maiusculo
            Console.WriteLine("Primeira vez que um nome começa com E na lista: " + s1);

            Console.WriteLine();
            string s2 = lista.FindLast(x => x[0] == 'R');
            Console.WriteLine("Última vez que um nome começa com R na lista: " + s2);

            Console.WriteLine();
            int pos1 = lista.FindIndex(x => x[0] == 'R');
            Console.WriteLine("Primeira posição começando com 'R': " + pos1);

            Console.WriteLine();
            int pos2 = lista.FindLastIndex(x => x[0] == 'R');
            Console.WriteLine("Última posição começando com 'R': " + pos2);

            Console.WriteLine();
            List<string> listaNova = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("Os elementos da primeira lista com apenas 5 caracteres são: ");
            foreach(string obj in listaNova){
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            lista.Remove("Renato"); // tem que informar qual elemento quer remover, pelo nome dele
            Console.WriteLine("Após remover o Renato da lista: ");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            lista.RemoveAll(x => x[1] == 'i'); // remover todos os elementos na posição que tenham i
            Console.WriteLine("Após remover pessoas com a segunda letra i do nome da lista: ");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            lista.RemoveAt(2); // remover um elemento da posição 2
            Console.WriteLine("Após remover o elemento da posição 2 da lista: ");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            lista.RemoveRange(2, 2); // remover a partir da posição 2, e irá remover dois elementos
            Console.WriteLine("Após remover o elemento da posição 2 até 2 elementos depois da lista: ");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
