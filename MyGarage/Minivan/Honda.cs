using MyGarage.Enum;
using System;
using Type = MyGarage.Enum.Type;


namespace MyGarage.Minivan
{
    class Honda : MinivanCar
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


        public Honda(DateTime productionyear, int price, ConsoleColor color, Type type)
        {
            _year = productionyear;
            _price = price;
            Model = CarModels.MinivanVan;
            Brand = CarBrands.Honda;
            base.consoleColor = color;
            base._type = type;

        }
        public Honda()
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
            if (obj is Honda)
            {
                Honda honda = (Honda)obj;
                return honda._price.Equals(this._price);
            }
            return false;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
