using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem
{
    internal class Flight
    {
        private string flightNumber;
        private int availableSeats;

        public string FlightNumber
        {
            get; set;
        }

        public int AvailableSeats
        {
            get; set;
        }

        public Flight(string flightNumber, int availableSeats)
        {
            FlightNumber = flightNumber;
            AvailableSeats = availableSeats;
        }

        public void Booking(int numSeats, string customerName)
        {
            if (numSeats <= AvailableSeats)
            {
                AvailableSeats -= numSeats;
                Console.WriteLine($"Booking successful for customer: {customerName} for flight {FlightNumber}");
            } 
            else
            {
                Console.WriteLine("Booking could not be completed due to insufficient seats");
            }
        }

        public bool CheckFlightStatus(string queryFlightNumber, string customerName)
        {
            if (queryFlightNumber == FlightNumber)
            {
                Console.WriteLine($"Available seats: {AvailableSeats}, Thank you {customerName} for choosing our airline.");
                return true;
            }
            else
            {
                Console.WriteLine("Flight number is incorrect");
                return false;
            }
        }
    }
}
