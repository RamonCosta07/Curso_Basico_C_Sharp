using System;
using System.Globalization;

namespace ExercicioClassesAtributosEMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p = new Funcionario();
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            p.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumento do salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AumentarSalario(aumento);
            Console.WriteLine($"\nDados atualizados:\n{p}");
        }
    }
}
