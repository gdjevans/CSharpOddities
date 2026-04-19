// Dependency Inversion Principle (DIP)
// Example: High-level modules should not depend on low-level modules. Both should depend on abstractions.
public class LightBulb
{
    public void TurnOn()
    {
        Console.WriteLine("LightBulb turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("LightBulb turned off");
    }
}

public class Switch
{
    private LightBulb _bulb;

    public Switch(LightBulb bulb)
    {
        _bulb = bulb;
    }

    public void Operate(bool on)
    {
        if (on)
        {
            _bulb.TurnOn();
        }
        else
        {
            _bulb.TurnOff();
        }
    }
}

// After DIP (Adheres to DIP)
public interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}

public class LightBulb : ISwitchable
{
    public void TurnOn()
    {
        Console.WriteLine("LightBulb turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("LightBulb turned off");
    }
}

public class Switch
{
    private ISwitchable _device;

    public Switch(ISwitchable device)
    {
        _device = device;
    }

    public void Operate(bool on)
    {
        if (on)
        {
            _device.TurnOn();
        }
        else
        {
            _device.TurnOff();
        }
    }
}
