namespace Assignment3.Models
{
    public static class BookingHelper
    {
        private static int _bookingCounter = 0;

        // 10% discount for groups of 5+ tickets
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;
            return numberOfTickets >= 5 ? total * 0.9 : total;
        }
        // overloaded method for group discount with a flat discount amount
        public static decimal CalcGroupDiscount(int numberOfTickets, decimal pricePerTicket)
        {
            decimal total = numberOfTickets * pricePerTicket;
            return numberOfTickets >= 5 ? total * 0.9m : total;
        }
        // Generates unique references: BK-1, BK-2, BK-3...
        public static string GenerateBookingReference()
        {
            return $"BK-{++_bookingCounter}";
        }
    }
}