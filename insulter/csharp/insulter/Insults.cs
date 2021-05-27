using System;
using System.Collections.Generic;

namespace insulter
{
    class Insults
    {
        public List<string> insultslist { get; }

        public Insults()
        {
            insultslist = new List<string>();
        }

        public void Addinsult(string saying)
        {
            insultslist.Add(saying);
        }

        
        

    }
}