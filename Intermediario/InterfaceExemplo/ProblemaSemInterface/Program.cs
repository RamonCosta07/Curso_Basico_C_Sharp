using System;
using System.Globalization;
using InterfaceExemplo.Entities;
using InterfaceExemplo.Servicies;

/* Uma locadora brasileira de carros cobra um valor por hora para locações
 * de até 12 horas. Porém, se a duração da locação ultrapassar 12 horas,
 * a locação será cobrada com base em um valor diário. Além do valor 
 * da locação, é acrescido no preço o valor do imposto conforme regras
 * do país, que no caso do Brasil, é 20% para valores até 100.00, 
 * ou 15% para valores acima de 100.00. Fazer um programa que lê 
 * os dados da locação (modelo do carro, instante inicial e final da
 * locação), bem como o valor por hora e o valor diário de locação. 
 * O programa deve então gerar a nota de pagamento (contendo valor 
 * da locação, valor do imposto e valor total do pagamento)
 * e informar os dados na tela
 */

namespace InterfaceExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental date");
            Console.Write("Car model: ");
            string car = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(car));

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalServicie rental = new RentalServicie(priceHour, priceDay, new BrazilTaxService());

            rental.ProcessInvoice(carRental);

            Console.WriteLine(carRental.Invoice);
        }
    }
}
