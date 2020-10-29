using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Minivan
{
    abstract class MinivanCar
    {

        public int SitCount;
        static public int size = 10;
        protected string[] namelist = new string[size];
        public string tmp;


        public MinivanCar()
        {
            SitCount = 8;
        }

        public abstract void DoorCount();

        public virtual string this[int index]
        {
            get
            {

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                Console.WriteLine("Minivan virtual indexer");
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
    }
}
