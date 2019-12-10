using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathRace
{
    class Bet : Jeep
    {
        public int BetAmount { get; set; }
        public Bettor bettor { get; set; }
        public int jeep { get; set; }
        public int rewardMultiplier = 4;

        public int CashOut(int winningJeep)
        {
            if (winningJeep == jeep)
                return BetAmount * rewardMultiplier;
            else
                return (0 - BetAmount);
        }
    }
}
