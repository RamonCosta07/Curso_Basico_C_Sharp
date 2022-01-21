

namespace ParametrosRefEOut
{
    class Calculadora
    {
        public static void Triple(ref int x) // Dessa forma, será mexido na variavel original
            //e não apenas no escopo da Classe
        {
            x = x * 3;
        }

        public static void Duplic(int origin, out int result)
        {
            result = origin * 2;
        }
    }
}
