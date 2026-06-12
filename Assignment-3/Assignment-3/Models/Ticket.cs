namespace Assignment3.Models
{
    public class Ticket
    {
        private static int _ticketCounter = 0;
        private decimal _price;

        public string MovieName { get; set; }

        // Price must be > 0 (enforced in setter)
        public decimal Price
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new ArgumentException("Price must be greater than 0.");
            }
        }

        // Read-only, auto-incremented
        public int TicketId { get; }

        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            TicketId = ++_ticketCounter;
            MovieName = movieName;
            Price = price;
        }


        public static int GetTotalTickets()
        {
            return _ticketCounter;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }
}

// old class from assignment 2, not used in assignment 3, but kept for reference
//namespace Assignment3.Models
//{
//    public class Ticket
//    {
//        private static int ticketCounter = 0;

//        private string _movieName;
//        private TicketType _type;
//        private SeatLocation _seat;
//        private double _price;
//        private readonly int _ticketId;

//        public string MovieName
//        {
//            get => _movieName;
//            set
//            {
//                if (!string.IsNullOrEmpty(value))
//                {
//                    _movieName = value;
//                }
//            }
//        }

//        public TicketType Type
//        {
//            get => _type;
//            set => _type = value;
//        }

//        public SeatLocation Seat
//        {
//            get => _seat;
//            set => _seat = value;
//        }

//        public double Price
//        {
//            get => _price;
//            set
//            {
//                if (value > 0)
//                {
//                    _price = value;
//                }
//            }
//        }

//        // Calculated property: price + 14% tax (not stored)
//        public double PriceAfterTax => _price * 1.14;

//        public int TicketId => _ticketId;

//        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
//        {
//            _ticketId = ++ticketCounter; 
//            MovieName = movieName; 
//            Type = type;
//            Seat = seat;
//            Price = price; 
//        }

//        // Constructor chaining for default ticket
//        public Ticket(string movieName)
//            : this(movieName, TicketType.Standard, new SeatLocation('A', 1), 50.0)
//        {
//        }

//        // Static method to get total tickets created
//        public static int GetTotalTicketsSold()
//        {
//            return ticketCounter;
//        }
//    }
//}