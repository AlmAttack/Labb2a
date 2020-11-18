using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter_Del_1
{
   class Wizard
    {
        public string BloodStatus { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
        public string Name { get; set; }

        public Wizard()
        {
            BloodStatus = "";
            DeathEater = true; //vet ej om den bör få ett värde i början...
            DumbledoresArmy = false;
            Name = ""; 

        }
       
    }
}
