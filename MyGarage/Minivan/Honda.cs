using MyGarage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Minivan
{
    class Honda:MinivanCar
    {
        public CarModels Model;
        public CarBrands Brand;
        private DateTime _year;

        public DateTime Production
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    _year = value;
                }
                throw new IndexOutOfRangeException();
            }
        }

        public Honda(DateTime productionyear)
        {
            Model = CarModels.MinivanVan;
            Brand = CarBrands.Honda;
            _year = productionyear;

        }
        public Honda()
        {

        }

        public override string ToString()
        {
            return $"Brand {Brand}\n" +
                   $"Model {Model}\n" +
                   $"Production Year {Production}\n" +
                   $"Sit count {SitCount}\n";
        }

        public override void DoorCount()
        {
            Console.WriteLine("The Honda has 8 doors");
        }

        public override string this[int index]
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
                Console.WriteLine("Honda override indexer");
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
