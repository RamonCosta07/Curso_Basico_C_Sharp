using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();
            Console.Write("Digite a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i);
                Console.Write("Digite o id do funcionário: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o salário do funcionário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o ID do funcionário receberá aumento: ");
            int idTeste = int.Parse(Console.ReadLine());
            Funcionario buscar = lista.Find(x => x.Id == idTeste);
            if(buscar != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                buscar.Aumento(aumento);
            }
            else
            {
                Console.WriteLine("ID Inválido!");
            }

            Console.WriteLine();
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
