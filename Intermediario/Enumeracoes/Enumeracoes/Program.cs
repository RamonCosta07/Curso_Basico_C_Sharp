using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };
            Console.WriteLine(order.ToString());

            // Converter um tipo de enumeração para string
            string txt = OrderStatus.Shipped.ToString();
            Console.WriteLine($"Enumeração convertida para string: {txt}");


            // Converter um valor em forma de string para um tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // O nome tem que ser = do enum
            Console.WriteLine($"String convertida para Enumeração: {os}");
        }
    }
}
