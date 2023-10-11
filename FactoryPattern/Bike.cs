
namespace FactoryPattern
{
    internal class Bike: IVehicle
    {
        public Bike() { }

        public void PrintVehicleInfo()
        {
            Console.WriteLine("This is bike object");
        }
    }
}
