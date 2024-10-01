namespace TeamworkAutoTeilEins.States;

public class Driving : ICarState
{
    private AVehicle vehicle;

    public Driving(AVehicle vehicle)
    {
        this.vehicle = vehicle;
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