using MyGarage.Enum;
using System;
using Type = MyGarage.Enum.Type;

namespace MyGarage.Sport
{
    class Chevrolet : SportCar
    {
        public CarModels Model;
        public CarBrands Brand;
        private DateTime _year;
        private double _price;

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


        public Chevrolet(DateTime productionyear, int price, ConsoleColor color, Type type)
        {
            _year = productionyear;
            _price = price;
            Model = CarModels.SportsCar;
            Brand = CarBrands.Chevrolet;
            base.consoleColor = color;
            base._type = type;

        }
        public Chevrolet()
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

        public static double operator +(Chevrolet car, Chevrolet car1)
        {
            return car._price + car1._price;
        }

        public static double operator -(Chevrolet car, Chevrolet car1)
        {
            return car._price - car1._price;
        }

        public static bool operator ==(Chevrolet car, Chevrolet car1)
        {
            return car._price == car1._price;
        }

        public static bool operator !=(Chevrolet car, Chevrolet car1)
        {
            return car.Model == car1.Model;
        }

        public static bool operator <=(Chevrolet car, Chevrolet car1)
        {
            return car._year <= car1._year;
        }

        public static bool operator >=(Chevrolet car, Chevrolet car1)
        {
            return car._year == car1._year;
        }


        public static implicit operator Chevrolet(double number)
        {
            Console.WriteLine("Conversion occurred");
            return new Chevrolet { _price = number };
        }

        public static explicit operator double(Chevrolet num)
        {
            Console.WriteLine("Conversion occurred.");
            return num._price;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Chevrolet)
            {
                Chevrolet chevrolet = (Chevrolet)obj;
                return chevrolet.sitCount.Equals(this.sitCount);
            }
            return false;
        }
    }
}
