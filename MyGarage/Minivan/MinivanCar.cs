namespace MyGarage.Minivan
{
    class MinivanCar:Car
    {
        public MinivanCar()
        {
            sitCount = 8;

        }
       
        public override string ToString()
        {
            return base.ToString() + $"Sit count {sitCount}";
        }

    }
}
