using MyGarage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Minivan
{
    class Ford:MinivanCar
    {
        public CarModels Model;
        public CarBrands Brand;
        private DateTime _year;

        public DateTime ProcutionYear
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

        public Ford(DateTime productionyear)
        {
            Model = CarModels.MinivanVan;
            Brand = CarBrands.Ford;
            _year = productionyear;

        }
        public Ford()
        {

        }

        public override string ToString()
        {
            return $"Brand {Brand}\n" +
                   $"Model {Model}\n" +
                   $"Production Year {ProcutionYear}\n" +
                   $"Sit count {SitCount}\n";
        }

        public override void DoorCount()
        {
            Console.WriteLine("The ford has 3 doors");
        }

        public new string this[int index]
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
                Console.WriteLine("Ford new indexer");
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
