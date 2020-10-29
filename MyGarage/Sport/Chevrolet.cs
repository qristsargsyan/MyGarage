using MyGarage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Sport
{
    class Chevrolet:SportCar
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


        public Chevrolet(DateTime productionyear)
        {
            Model = CarModels.SportsCar;
            Brand = CarBrands.Chevrolet;
            _year = productionyear;

        }

        public override string ToString()
        {
            return $"Brand {Brand}\n" +
                   $"Model {Model}\n" +
                   $"Production Year {Production}\n" +
                   $"Sit count {SitCount}\n";
        }


    }
}
