namespace MyGarage.Sport
{
    class SportCar:Car
    {

        public SportCar()
        {
            sitCount = 2;
        }

        public override string ToString()
        {
            return base.ToString() + $"Sit count {sitCount}";
        }
    }
}
