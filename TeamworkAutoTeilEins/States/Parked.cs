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
        vehicle.CurrentState = this;
    }

    public void Parking()
    {
        vehicle.CurrentState = this;
    }

    public void Crash()
    {
        vehicle.CurrentState = this;
    }

    public void Repair()
    {
        vehicle.CurrentState = this;
    }
}