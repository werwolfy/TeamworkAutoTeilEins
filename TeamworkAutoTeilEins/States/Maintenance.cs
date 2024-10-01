namespace TeamworkAutoTeilEins.States;

public class Maintenance : ICarState
{
    private AVehicle vehicle;
    public Maintenance(AVehicle vehicle)
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