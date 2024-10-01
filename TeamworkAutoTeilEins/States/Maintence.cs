namespace TeamworkAutoTeilEins.States;

public class Maintence : ICarState
{
    private AVehicle vehicle;
    public Maintence(AVehicle vehicle)
    {
        this.vehicle = vehicle;
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