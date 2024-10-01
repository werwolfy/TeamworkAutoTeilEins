namespace TeamworkAutoTeilEins.States;

public class Parked : ICarState
{
    private AVehicle vehicle;
    public Parked(AVehicle vehicle)
    {
            vehicle = vehicle;
    }
    public void Drive()
    {
        vehicle.CurentState = this;
    }

    public void Parking()
    {
        vehicle.CurentState = this;
    }

    public void Crash()
    {
        vehicle.CurentState = this;
    }

    public void Repair()
    {
        vehicle.CurentState = this;
    }
}