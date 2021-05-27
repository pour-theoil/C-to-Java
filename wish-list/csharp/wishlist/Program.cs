using System;

namespace wishlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My wishes");

            Iwishfor wishes = new Iwishfor();
            wishes.AddWish("An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'");
            wishes.AddWish("The ability to think of interesting wishes on short notice");
            wishes.AddWish("A washtub of Skittles");
            wishes.AddWish("World peace, but not the kind of world peace where all the humans are removed from existence");
            wishes.AddWish("A TV that is NOT internet-capable");
            wishes.AddWish("The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?");

            wishes.Displaywish();
        }
    }
}
