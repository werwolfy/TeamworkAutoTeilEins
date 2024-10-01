namespace TeamworkAutoTeilEins;

public abstract class AVehicle
{
    public string? Model { get; set; }
    public int Speed { get; set; }
    public ICarState? CurentState { get; set; }
    public IDriveStrategy? DriveMode { get; set; }

    public abstract void GetCarAccelerate();
    public abstract void GetTruckAccelerate();
    public abstract void GetMotorcycleAccelerate();
    public abstract void GetCarBreak();
    public abstract void GetTruckBreak();
    public abstract void GetMotorcycleBreak();


    public void ChangeState(ICarState state)
    {
        CurentState = state;
    }
    
    
    
    public void ChangeStrategy(IDriveStrategy strategy)
    {
        DriveMode = strategy;
    }

    public int Accelerate()
    {
        throw new NotImplementedException();
    }

    public int Break()
    {
        throw new NotImplementedException();
    }
}
  