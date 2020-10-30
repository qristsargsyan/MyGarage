using System;

namespace MyGarage
{
    class GeneralGarage
    {

        public string Location{ get; private set; }
        public DateTime Open { get; private set; }
        public DateTime Close { get; private set; }
        private static int generalCarsCount;
    

        public GeneralGarage()
        {
            Location = "Los Anjeles Trumb Street";
            Open = DateTime.Parse("09:00");
            Close = DateTime.Parse("21:00");
            generalCarsCount = 115;

        }

        public override string ToString()
        {
            return $"Location  {Location}\n" +
                   $"Openint at  {Open}\n" +
                   $"Closing at  {Close}\n" +
                   $"General count of cars {generalCarsCount}\n";
                   
        }
    }
}
