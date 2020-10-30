using MyGarage.Enum;
using System;
using Type = MyGarage.Enum.Type;

namespace MyGarage
{
    abstract class Car
    {
        protected int sitCount;
        public ConsoleColor consoleColor;
        public Type _type;

        public Car(ConsoleColor consoleColor, Type type)
        {
            this.consoleColor = consoleColor;
            _type = type;
        }

        public Car()
        {

        }

        public override string ToString()
        {
            return $"Color {consoleColor}\nType {_type}\n";
        }

        public virtual int this[CarBrands index]
        {
            get
            {
                Console.Write("In garage the count of this car brands is ");
                return (int)index;
            }
            set
            {
                index = (CarBrands)value;
            }
        }
        
    }
}
