
namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public VehicleFactory() { }

        public IVehicle BuildVehicle(int id)
        {
            if (id == 2) return new Bike();
            if (id == 4) return new Car();
            return null;
        }
    }
}
