namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Galaxy Cinema");
            cinema.OpenCinema();

            cinema.AddTicket(new Models.StandardTicket("Inception", 120m, "A-5"));
            cinema.AddTicket(new Models.VIPTicket("Avengers", 200m, true));
            cinema.AddTicket(new Models.IMAXTicket("Dune", 180m, false));

            cinema.PrintAllTickets();

            Console.WriteLine("\n========== Statistics ==========");
            Console.WriteLine($"Total Tickets Created: {Models.Ticket.GetTotalTickets()}");

            Console.WriteLine($"\nBooking Ref 1: {Models.BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Ref 2: {Models.BookingHelper.GenerateBookingReference()}");

            decimal discount = Models.BookingHelper.CalcGroupDiscount(5, 100m);
            Console.WriteLine($"\nGroup Discount (5 x 100 EGP): {discount} EGP (10% off)");

            cinema.CloseCinema();
        }
    }
}