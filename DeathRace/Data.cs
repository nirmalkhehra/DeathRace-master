using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathRace
{
    abstract class Data
    {
        public static Jeep[] jeeps = new Jeep[4];
        public static Bettor[] bettor = new Bettor[3];
        public static Random rand = new Random();
        public static int currentGambler { get; set; }
    }
}
