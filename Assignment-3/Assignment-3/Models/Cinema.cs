using Assignment3.Models;

public class Cinema
{
    private Ticket[] _tickets = new Ticket[20];
    private int _ticketCount = 0;

    // COMPOSITION: The Projector is created and entirely managed by the Cinema
    private Projector _projector;

    public string CinemaName { get; set; }

    public Cinema(string cinemaName)
    {
        CinemaName = cinemaName;
        _projector = new Projector(); 
    }

    public bool AddTicket(Ticket t)
    {
        if (_ticketCount < 20)
        {
            _tickets[_ticketCount++] = t;
            return true;
        }
        return false;
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("\nAll Tickets");
        for (int i = 0; i < _ticketCount; i++)
        {
            Console.WriteLine(_tickets[i].ToString());
        }
    }

    public void OpenCinema()
    {
        Console.WriteLine("========== Cinema Opened ==========");
        _projector.Start();
    }

    public void CloseCinema()
    {
        Console.WriteLine("\n========== Cinema Closed ==========");
        _projector.Stop();
    }
}

// old model from assignment 2, not used in assignment 3, but kept for reference
//namespace Assignment3.Models
//{
//    public class Cinema
//    {
//        private Ticket[] _tickets;
//        private const int MaxTickets = 20;

//        public Cinema()
//        {
//            _tickets = new Ticket[MaxTickets];
//        }

//        // Indexer: get/set tickets by index with bounds checking
//        public Ticket this[int index]
//        {
//            get
//            {
//                if (index >= 0 && index < MaxTickets)
//                    return _tickets[index];
//                return null;
//            }
//            set
//            {
//                if (index >= 0 && index < MaxTickets)
//                    _tickets[index] = value;
//            }
//        }

//        // Find first ticket matching movie name (case-insensitive)
//        public Ticket GetTicketByMovieName(string movieName)
//        {
//            foreach (var ticket in _tickets)
//            {
//                if (ticket != null &&
//                    string.Equals(ticket.MovieName, movieName, StringComparison.OrdinalIgnoreCase))
//                    return ticket;
//            }
//            return null;
//        }

//        // Add ticket to first available slot
//        public bool AddTicket(Ticket t)
//        {
//            for (int i = 0; i < MaxTickets; i++)
//            {
//                if (_tickets[i] == null)
//                {
//                    _tickets[i] = t;
//                    return true;
//                }
//            }
//            return false; // Cinema is full
//        }
//    }
//}