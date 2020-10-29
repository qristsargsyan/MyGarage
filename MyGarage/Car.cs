using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class Car
    {
        public int TypeCount { get; set; }

        public Car(int count)
        {
            TypeCount = count;
        }

        public override string ToString()
        {
            return $"Age {TypeCount}\n";
        }

        public override int GetHashCode()
        {
            return this.TypeCount.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is Car car &&
                   TypeCount == car.TypeCount;
        }


        public static int operator +(Car car, Car car1)
        {
            return car.TypeCount + car1.TypeCount;
        }

        public static int operator -(Car car, Car car1)
        {
            return car.TypeCount - car1.TypeCount;
        }

        public static bool operator ==(Car car, Car car1)
        {
            return car.TypeCount == car1.TypeCount;
        }

        public static bool operator !=(Car car, Car car1)
        {
            return car.TypeCount != car1.TypeCount;
        }


        public static bool operator <=(Car car, Car car1)
        {
            return car.TypeCount <= car1.TypeCount;
        }

        public static bool operator >=(Car car, Car car1)
        {
            return car.TypeCount >= car1.TypeCount;
        }

        public static implicit operator int(Car number)
        {
            Console.WriteLine(number.ToString());
            return number.TypeCount;
        }

        public static explicit operator Car(int num)
        {
            return new Car(num);

        }

    }
}
