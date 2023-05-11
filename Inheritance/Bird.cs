using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird: Animal
    {
        public Bird() 
        { 
            isAlive = true;
            LegCount = 2;
            canBreathe = true;
            Age = 7;
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool WillMigrate { get; set; }
        public double BeakLength { get; set; }  
    }
}
