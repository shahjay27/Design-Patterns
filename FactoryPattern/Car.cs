
namespace FactoryPattern
{
    internal class Car: IVehicle
    {
        public Car() { }

        public void PrintVehicleInfo()
        {
            Console.WriteLine("This is car object");
        }
    }
}
