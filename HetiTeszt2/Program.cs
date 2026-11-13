using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using static HetiTeszt2.Program;

namespace HetiTeszt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ticket> tickets = new List<Ticket>();
                tickets.Add(new Ticket(1, "Nem működik a nyomtató", "Open"));
                tickets.Add(new Ticket(2, "Windows frissítés szükséges", "Closed"));
                tickets.Add(new Ticket(3, "Nincs internetkapcsolat", "Open"));

            Console.WriteLine("Add meg mi a hiba:");
            string? hibaTicket = Console.ReadLine();

            Ticket.AddTicket(tickets, hibaTicket);
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine($"[{ticket.Id}] {ticket.Title} - {ticket.Status}");
            }


            for (int i = 0; i < tickets.Count; i++)
            {
                Console.WriteLine($"[{tickets[i].Id}] {tickets[i].Title} - {tickets[i].Status}");
            }
            Console.WriteLine("\n");


            

            Ticket? findTicket = Ticket.FindTicket(tickets, 3);

            if (findTicket != null)
            {
                Console.WriteLine($"{findTicket.Title}\n");
            }
            else
            {
                Console.WriteLine("Ticket nem található");
            }
            Console.WriteLine("Adj meg egy lezárandó ID-t: ");

            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int ticketId))
            {
                Console.WriteLine("\nAdj meg egy érvényes ID-t!");
            }
            else if(!Ticket.CloseTicket(tickets, ticketId))
            {
                Console.WriteLine("\nA megadott ID-hoz nem tartozik ticket!");
            }
            else
            {
                Console.WriteLine("A megadott ticket lezárva.");
                
            }

            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine($"[{ticket.Id}] {ticket.Title} - {ticket.Status}");
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        public class Ticket
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Status { get; set; }

            public Ticket(int id, string title, string status)
            {
                this.Id = id;
                this.Title = title;
                this.Status = status;
            }
            
            public static bool CloseTicket(List<Ticket> tickets, int ticketId)
            {
                Ticket? foundTicket = Ticket.FindTicket(tickets, ticketId);
                if (foundTicket != null)
                {
                    foundTicket.Status = "Closed";
                    return true;
                }
                return false;
            }
            public static Ticket? FindTicket(List<Ticket> tickets, int ticketId)
            {
                for (int i = 0; i < tickets.Count; i++)
                {
                    if (ticketId == tickets[i].Id)
                    {
                        return tickets[i];
                    }
                }
                return null;
            }

            public static void AddTicket(List<Ticket> tickets, string ticketTitle)
            {
                if (string.IsNullOrEmpty(ticketTitle))
                {
                    Console.WriteLine("A hiba nem lehet üres!");
                }
                else
                {
                    if (tickets.Count == 0)
                    {
                        tickets.Add(new Ticket(1, ticketTitle, "Open"));
                    }
                    else
                    {
                        tickets.Add(new Ticket(tickets.Max(t => t.Id) + 1, ticketTitle, "Open"));
                    }
                }
            }
        }
    }
}