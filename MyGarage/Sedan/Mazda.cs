using MyGarage.Enum;
using System;
using Type = MyGarage.Enum.Type;

namespace MyGarage.Sedan
{
    class Mazda:SedanCar
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


        public Mazda(DateTime productionyear, int price, ConsoleColor color, Type type)
        {
            _year = productionyear;
            _price = price;
            Model = CarModels.Sedan;
            Brand = CarBrands.Mazda;
            base.consoleColor = color;
            base._type = type;

        }
        public Mazda()
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

        public override bool Equals(object obj)
        {
            if (obj is Mazda)
            {
                Mazda mazda = (Mazda)obj;
                return mazda._price.Equals(this._price)
                       && mazda.Model.Equals(this.Model)
                       && mazda.Brand.Equals(this.Brand);
            }
            return false;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
