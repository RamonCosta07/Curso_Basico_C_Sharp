using ExcessoesPersonalizadas.Entities;
using ExcessoesPersonalizadas.Exceptions;
using System;

namespace ExcessoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in  date (dd/mm/yyyy): ");
                DateTime dateIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy): ");
                DateTime dateOut = DateTime.Parse(Console.ReadLine());

                Reservation p1 = new Reservation(room, dateIn, dateOut);
                Console.WriteLine(p1);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in  date (dd/mm/yyyy): ");
                dateIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy): ");
                dateOut = DateTime.Parse(Console.ReadLine());

                p1.UpdateDates(dateIn, dateOut);
                Console.WriteLine(p1);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            } catch (Exception e) // Pegar qualquer outra excessão não prevista
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }

    }
}
