namespace TeamworkAutoTeilEins;

public class AVehicle
{
    public string? Model { get; set; }
    public int Speed { get; set; }
    public ICarState? CurentState { get; set; }
    public IDriveStrategy? DriveMode { get; set; }

    public int Accelerate()
    {
        throw new NotImplementedException();
    }

    public int Break()
    {
        throw new NotImplementedException();
    }
}
  