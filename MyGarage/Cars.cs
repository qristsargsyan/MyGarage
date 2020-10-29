using MyGarage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class Cars:Car
    {

        Car[] cars;


        public Cars(int count) : base(count)
        {
            cars = new Car[count];
        }

        public virtual int this[CarBrands index]
        {
            get
            {

                return (int)index;
            }
            set
            {
                index = (CarBrands)value;
            }
        }
    }
}
