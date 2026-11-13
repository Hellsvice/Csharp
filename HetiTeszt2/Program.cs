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

            while (true)
            {
                Console.WriteLine("Válassz a menüpontok közül:");
                Console.WriteLine("1. Ticket hozzáadása");
                Console.WriteLine("2. Ticket lista");
                Console.WriteLine("3. Ticket keresése");
                Console.WriteLine("4. Ticket lezárása");
                Console.WriteLine("5. Ticket újra megnyitása");
                Console.WriteLine("0. Kilépés");
                Console.WriteLine();
                string? menuNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(menuNumber))
                {
                    Console.WriteLine("Érvénytelen választás.");
                }
                else
                {
                    if (int.TryParse(menuNumber, out int menuChoice))
                    {
                        switch (menuChoice)
                        {
                            case 1:
                                Console.WriteLine("Add meg mi a hiba:");
                                string? errorTicket = Console.ReadLine();
                                Ticket.AddTicket(tickets, errorTicket);
                                Console.WriteLine();
                                break;
                            case 2:
                                Ticket.ListTicket(tickets, null);
                                Console.WriteLine();
                                break;
                            case 3:
                                Console.WriteLine("Add meg a keresendő státuszt (Open/Closed/Ha az összes akkor hagyd üresen):");
                                string? inputStatus = Console.ReadLine();
                                Ticket.ListTicket(tickets, inputStatus);
                                Console.WriteLine();
                                break;
                            case 4:
                                Console.WriteLine("Adj meg egy lezárandó ID-t: ");
                                int input = Convert.ToInt32(Console.ReadLine());
                                Ticket.CloseTicket(tickets, input);
                                Console.WriteLine();
                                break;
                            case 5:
                                Console.WriteLine("Add meg a megnyitandó ticket ID-jét:");
                                string? reopenInput = Console.ReadLine();
                                if (int.TryParse(reopenInput, out int reopenId))
                                {
                                    Ticket.ReopenTicket(tickets, reopenId);
                                }
                                else
                                {
                                    Console.WriteLine("Érvénytelen ID.");
                                }
                                Console.WriteLine();
                                break;
                            case 0:
                                return;
                            default:
                                Console.WriteLine("Érvénytelen választás.");
                                Console.WriteLine();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Érvénytelen válasz.");
                    }
                }
            }
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
                    if (foundTicket.Status == "Open")
                    {
                        foundTicket.Status = "Closed";
                        return true;
                    }
                    else if (foundTicket.Status == "Closed")
                    {
                        Console.WriteLine("A ticket már le van zárva.");
                    }
                    else if(foundTicket.Status == null)
                    {
                        Console.WriteLine("A ticket státusza nem található.");
                    }
                    else
                    {
                        Console.WriteLine("A ticket nem található.");
                    }
                }
                else
                {
                    Console.WriteLine("A ticket nem található.");
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

            public static void AddTicket(List<Ticket> tickets, string? ticketTitle)
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

            public static void ListTicket(List<Ticket> tickets, string? status)
            {
                foreach (Ticket ticket in tickets)
                {
                    if (string.IsNullOrEmpty(status))
                    {
                        Console.WriteLine($"[{ticket.Id}] {ticket.Title} - {ticket.Status}");
                    }
                    else if (status == ticket.Status)
                    {
                        Console.WriteLine($"[{ticket.Id}] {ticket.Title} - {ticket.Status}");
                    }
                }
            }

            public static bool ReopenTicket(List<Ticket> tickets, int ticketId)
            {
                Ticket? foundTicket = Ticket.FindTicket(tickets, ticketId);
                if (foundTicket != null)
                {
                    if (foundTicket.Status == "Closed")
                    {
                        foundTicket.Status = "Open";
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("A ticket már nyitva van.");
                        return false;
                    }
                }
                Console.WriteLine("A ticket nem található.");
                return false;
            }
        }
    }
}