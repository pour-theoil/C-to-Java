using System;
using System.Collections.Generic;

namespace wishlist
{
    class Iwishfor
    {
        public List<string> WishList { get; } 

        public Iwishfor(){
            WishList = new List<string>();
        }
        
        public void Displaywish ()
           {

            foreach (string item in WishList)
            {
                Console.WriteLine($"{item}");
            }
            
        } 

        public void AddWish(string entry)
        {
            WishList.Add(entry);
        }
            
        
    }
}