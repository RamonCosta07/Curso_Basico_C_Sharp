using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Tentar executar esse código
            {

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            } catch (DivideByZeroException e) // Caso seja gerada uma excessão irá capturar ela
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch (FormatException c)
            {
                Console.WriteLine("Format Error! " + c.Message);
            }
            finally{ // Será executado independentemente de excessões
                // Normalmente utilizado para fechar conexão com banco ou fechar arquivos
                Console.WriteLine("Fim do programa!");
            }
        }
    }
}
