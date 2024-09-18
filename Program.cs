namespace FlightSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide a Flight Number: ");
            string flightNumber = Console.ReadLine();

            int availableSeats = 0; //added for error prevention
            bool valSeat = false;

            while (!valSeat)
            {
                try
                {
                    Console.Write("Please provide the Number of Available Seats: ");
                    availableSeats = Convert.ToInt32(Console.ReadLine());
                    valSeat = true;
                }
                catch (Exception error)
                {
                    Console.WriteLine("Please provide a valid number");
                }
            }


            Flight flight1 = new Flight(flightNumber, availableSeats);

            int desiredSeats = 0; //added for error prevention
            bool valRequired = false;

            while (!valRequired)
            {
                try
                {
                    Console.Write("Please provide the number of seats you wish to book: ");
                    desiredSeats = Convert.ToInt32(Console.ReadLine());
                    valRequired = true;
                }
                catch (Exception error)
                {
                    Console.WriteLine("Please provide a valid number");
                }
            }

            Console.Write("Please provide your name: ");
            string customerName = Console.ReadLine();

            flight1.Booking(desiredSeats, customerName);

            Console.Write("Please provide the Flight Number you'd like to check: ");
            string flightInquire = flightInquire = Console.ReadLine(); ;
            
            flight1.CheckFlightStatus(flightInquire, customerName);

        }
    }
}
