using TeamworkAutoTeilEins.Strategy;

namespace TeamworkAutoTeilEins.Builder;

public class VehicleBuilder
{
    private readonly AVehicle _vehicle;

    public VehicleBuilder SetSpeed(int speed)
    {
        _vehicle.Speed = speed;
        return this;
    }
}