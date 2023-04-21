using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        { 
            isAlive = true;
            LegCount = 4;
            canBreathe = true;
            Age = 0;
        }

        public bool IsColdBlooded { get; set; } 
        public bool IsScary { get; set; }
        public string Habitat {  get; set; }
        public bool CanGrowTail { get; set; }   
    }
}
