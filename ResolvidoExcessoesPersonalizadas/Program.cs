using ResolvidoExcessoesPersonalizadas.Entities;
using ResolvidoExcessoesPersonalizadas.Entities.Exceptions;
using System;

namespace ResolvidoExcessoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Room number: ");
                int roomnumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(roomnumber, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);

                Console.WriteLine("Reservation: " + reservation);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }


}




