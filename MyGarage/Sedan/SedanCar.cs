namespace MyGarage.Sedan
{
    class SedanCar:Car
    {

        public SedanCar()
        {
            sitCount = 4;
        }

        public override string ToString()
        {
            return base.ToString() + $"Sit count {sitCount}";
        }
    }
}
