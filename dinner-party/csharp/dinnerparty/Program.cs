using System;
using System.Collections.Generic;

namespace dinnerparty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Guest> attendees = new List<Guest>();

            Guest Marilin = new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model");
            Guest Abraham = new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war");
            Guest Martin = new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner");
            Guest Rosa = new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist");
            Guest Peter = new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian");
            Guest Alan = new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world");
            Guest Grace = new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds");
            Guest Indira = new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977");

            attendees.Add(Marilin);
            attendees.Add(Abraham);
            attendees.Add(Martin);
            attendees.Add(Rosa);
            attendees.Add(Peter);
            attendees.Add(Alan);
            attendees.Add(Grace);
            attendees.Add(Indira);

            Dictionary<Guest, string> tableone = new Dictionary<Guest, string>();
            Dictionary<Guest, string> tabletwo = new Dictionary<Guest, string>();

            void Setthetable(List<Guest> values)
            {

                foreach (Guest value in values)
                {
                    if (tableone.ContainsValue(value.Occupation))
                    {
                        tabletwo.Add(value, value.Occupation);
                    }
                    else
                    {
                        tableone.Add(value, value.Occupation);
                    }
                }
            }

            Setthetable(attendees);
            Console.WriteLine("Table 1");
            foreach (var guests in tableone)
            {
                Console.WriteLine($"{guests.Key.Name} {guests.Key.Occupation} {guests.Key.Bio}");
            }

            Console.WriteLine("Table 2");
            foreach (var guests in tabletwo)
            {
                Console.WriteLine($"{guests.Key.Name} {guests.Key.Occupation} {guests.Key.Bio}");
            }
        }

    }
}

