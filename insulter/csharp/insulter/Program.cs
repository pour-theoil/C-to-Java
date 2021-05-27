using System;

namespace insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            Insults readinsults = new Insults();

            readinsults.Addinsult("You look like what morning breath smells like.");
            readinsults.Addinsult("If you tried to give me cpr I would probably throw myself back under water");
            readinsults.Addinsult("I am not a fan of you");
            readinsults.Addinsult("You think you're so special...and you are. The fact of your existence is nearly impossible to believe");
            readinsults.Addinsult("I'd rather walk than be on the same plane as you");
            readinsults.Addinsult("If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy");
            readinsults.Addinsult("Do you have to be so...like that?");

            Random spot = new Random();
            int getrandom()
            {
                int num = spot.Next(1, readinsults.insultslist.Count - 1);
                return num;
            }

            for (int i = 0; i < 3; i++)
            {
                // string insulttoread = readinsults.ReadInsult(getrandom());
                Console.WriteLine($"{readinsults.insultslist[getrandom()]}");
            }
        
        }
    }
}
