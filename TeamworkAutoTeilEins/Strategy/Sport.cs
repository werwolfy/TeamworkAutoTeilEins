namespace TeamworkAutoTeilEins.Strategy;

public class Sport : IDriveStrategy
{
    private AVehicle vehicle;

    public Sport(AVehicle vehicle)
    {
        this.vehicle = vehicle;
    }
    public void Drive()
    {
        vehicle.DriveMode = this;
        throw new NotImplementedException();
    }
}