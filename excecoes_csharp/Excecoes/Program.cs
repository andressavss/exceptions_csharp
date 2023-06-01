using System;
using Excecoes.Entities;

namespace Exececoes;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Room Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (MM/dd/yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (MM/dd/yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        if (checkOut <= checkIn)
        {
            Console.WriteLine("Error in Reservation: Check-out must be after check-in date!");
        }
        else
        {
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (MM/dd/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (MM/dd/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                Console.WriteLine("Error in reservation: Reservation dates for update must be future dates!");
            }
            else if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in Reservation: Check-out must be date check-in date!");
            } 
            else
            {
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
        }
    }
}
