using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x) // irá analisar a variável x
            {
                case 1: // se ela for 1...
                    dia = "Domingo";
                    break; // no final de cada caso, tem que ter o break
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default: // se não for enhuma das opções acima
                    dia = "Valor inválido!";
                    break;
            }
            Console.WriteLine($"Dia: {dia}");
        }
    }
}
