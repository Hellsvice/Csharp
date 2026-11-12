using System;

namespace HetiTeszt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = new List<string>
            {
                "Open",
                "Closed",
                "open",
                "InProgress",
                "OPEN"
            };

            static int CountOpenTickets(List<string> tickets)
            {
                int openCount = 0;
                for (int i = 0; i < tickets.Count; i++)
                {
                    if (tickets[i].ToLower() == "open")
                    {
                        openCount++;
                    }
                }

                return openCount;
            }
            Console.WriteLine("Nyitott hibajegyek száma: " + CountOpenTickets(tickets));
            Console.ReadKey();
        }
    }
}