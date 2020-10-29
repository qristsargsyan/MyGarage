using MyGarage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Sedan
{
    class Hyundai:SedanCar
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

        public Hyundai(DateTime productionyear)
        {
            Model = CarModels.Sedan;
            Brand = CarBrands.Hyundai;
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
