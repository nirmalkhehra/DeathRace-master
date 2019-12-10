using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathRace
{
    class Jeep
    {
        public int startPos { get; set; }
        public int finalPos { get; set; }
        public PictureBox jeepImg { get; set; }
        private Random rand = new Random();

        // Checks if Jeep is in Motion
        public bool isAccelerating()
        {
            Point updatedLoc = jeepImg.Location;
            updatedLoc.X += rand.Next(1, 6);
            jeepImg.Location = updatedLoc;

            // Checks whether the location of right side of Jeep is same as final destination
            if (updatedLoc.X >= finalPos)
                return true;
            else
                return false;
        }

        public void MoveToStart()
        {
            jeepImg.Left = startPos;
        }
    }
}
