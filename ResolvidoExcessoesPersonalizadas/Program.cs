using ResolvidoExcessoesPersonalizadas.Entities;
using System;

namespace ResolvidoExcessoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomnumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if(checkout <= checkin)
            {
                Console.WriteLine("Error in reservation: check-out date must be after check-in");
            }
            else
            {
                Reservation reservation = new Reservation(roomnumber, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates must be future dates");
                }
                else if (checkout <= checkin)
                {
                    Console.WriteLine("Error in reservation: check-out date must be after check-in");
                }
                else
                {
                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
            

            
        }
    }
}
