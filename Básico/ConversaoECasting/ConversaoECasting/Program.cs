using System;

namespace ConversaoECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 5.4f;
            double a = 5.3;
            float b;
            int c;

            double y = x; // conversão implicita de float para double
            b = (float)a; // casting
            c = (int)b;

            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
