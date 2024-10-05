

using TeamworkAutoTeilEins.Strategy;

namespace TeamworkAutoTeilEins.Builder;

public class VehicleBuilder
{
    private AVehicle _vehicle;

    public VehicleBuilder SetSpeed(int speed)
    {
        _vehicle.Speed = speed;
        return this;
    }

    public VehicleBuilder SetModel(string model)
    {
        _vehicle.Model = model;
        return this;
    }

    public VehicleBuilder SetCurrentState(ICarState state)
    {
        _vehicle.CurrentState = state;
        return this;
    }

    public VehicleBuilder SetDriveMode(IDriveStrategy strategy)
    {
        _vehicle.DriveMode = strategy;
        return this;
    }

    public AVehicle BuildCar()
    {
        _vehicle = new Car();
        return _vehicle;
    }
    
}