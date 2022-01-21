using System;
using System.Collections.Generic;
using System.Text;

namespace Params
{
    class Calculadora
    {
        public static int Sum(params int [] numbers) // Não precisará mais intanciar o vetor na chamada
        {
            int sum = 0;
            for (int i = 0; i <numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
