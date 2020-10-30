using MyGarage.Enum;
using System;
using Type = MyGarage.Enum.Type;

namespace MyGarage.Sedan
{
    class Hyundai:SedanCar
    {
        public CarModels Model;
        public CarBrands Brand;
        private DateTime _year;
        private int _price;

        public DateTime Production
        {
            get
            {
                return _year;
            }
            set
            {
                if (DateTime.Now > value)
                {
                    _year = value;
                }
                throw new IndexOutOfRangeException();
            }
        }


        public Hyundai(DateTime productionyear, int price, ConsoleColor color, Type type)
        {
            _year = productionyear;
            _price = price;
            Model = CarModels.Sedan;
            Brand = CarBrands.Hyundai;
            base.consoleColor = color;
            base._type = type;

        }
        public Hyundai()
        {

        }

        public override string ToString()
        {
            return $"Brand {Brand}\n" +
                   $"Model {Model}\n" +
                   $"Production Year {Production}\n" +
                   $"Price is {_price}$\n" +
                   base.ToString();

        }

        public override int this[CarBrands index]
        {
            get
            {
                return base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }
}
