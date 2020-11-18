using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter_Del_1
{
    class Hufflepuff
    {
        public string HouseGhost { get; set; } //Se Benjamins första HL vid 8 min.
        public string Mascot { get; set; } // get set innebär att den ska kunna hämta och lämna ett värde!
        public string Password { get; set; }

        public Hufflepuff()
        {
            HouseGhost = "Den Tjocke Munkbrodern";
            Mascot = "Grävling";
            Password = "en ensam trollkarl";

        }
        
       /* public string hufflepuff(string houseGhost, string mascot) //metod för att ge klassem de 3 egenskaperna (properties)
        {
            string ok; 
            return ok; 
        }*/

    }
}


