using FactoryPattern;

Console.WriteLine("Please enter number of tire in your vehicle: ");

try
{
    int _noOfTires = Convert.ToInt32(Console.ReadLine());
    var _factory = new VehicleFactory();
    var vehicle = _factory.BuildVehicle(_noOfTires);

    if (vehicle != null)
        vehicle.PrintVehicleInfo();
    else
        Console.WriteLine("Please enter 2 or 4 only!");
}
catch(Exception ex)
{
    Console.WriteLine("Invalid Input:" + ex.Message);
}


