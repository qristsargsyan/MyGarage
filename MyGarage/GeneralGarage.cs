using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class GeneralGarage
    {


        public int count = 15;
        public string location;
        public DateTime open;
        public DateTime close;
        public int floor;

        public GeneralGarage()
        {
            location = "Los Anjeles Trumb Street";
            open = DateTime.Parse("09:00");
            close = DateTime.Parse("21:00");
            floor = 2;
        }

        public override string ToString()
        {
            return $"Location  {location}\n" +
                   $"Openint at  {open}\n" +
                   $"Closing at  {close}\n" +
                   $"Floor  {floor}\n";
        }
    }
}
