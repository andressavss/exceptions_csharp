﻿using System;

namespace Excecoes.Entities
{
    internal class Reservation
    {
         public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }   
        public DateTime CheckOut { get; set; }

        public Reservation() 
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("MM/dd/yyyy")
                + ", check-out: "
                + CheckOut.ToString("MM/dd/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
