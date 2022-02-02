using System;
using ExcessoesPersonalizadas.Exceptions;

namespace ExcessoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn); // Diferença entre um instante e outro
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn <= now || checkOut <= now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room: {RoomNumber}" +
                $", Check-in: {CheckIn.ToString("dd/MM/yyyy")}" +
                $", Check-out: {CheckOut.ToString("dd/MM/yyyy")}" +
                $", Duração: {Duration()} noites";
        }
    }
}
