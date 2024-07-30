namespace basics_of_c_sharp.DesignPatterns.ObserverPattern;


public class Clock
{
    private List<IClockObserver> observers = new List<IClockObserver>();

    private DateTime currentTime;

    public void SetTime(DateTime time)
    {
        currentTime = time;
        NotifyObservers();
    }

    public void RegisterObserver(IClockObserver observer)
    {
        observers.Add(observer);
    }

    public void UnregisterObserver(IClockObserver observer)
    {
        observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach(IClockObserver observer in observers)
        {
            observer.Update(currentTime);
        }
    }
}

public interface IClockObserver
{
    public void Update(DateTime time);
}

public class DigitalClock : IClockObserver
{
    public void Update(DateTime time)
    {
        Console.WriteLine($"Digital Clock : {time.ToString("hh:mm:ss tt")}");
    }
}

public class AnalogClock : IClockObserver
{
    public void Update(DateTime time)
    {
        Console.WriteLine($"Analog Clock : {time.ToString("hh:mm:ss tt")}");
    }
}


public class ClockTest
{
    public static void Main()
    {
        Clock clock = new Clock();
        
        DigitalClock digitalClock = new DigitalClock();
        clock.RegisterObserver(digitalClock);

        AnalogClock analogClock = new AnalogClock();
        clock.RegisterObserver(analogClock);

        clock.SetTime(DateTime.Now);
        clock.SetTime(DateTime.Now.AddSeconds(12));

        clock.UnregisterObserver(digitalClock);
        clock.SetTime(DateTime.Now.AddSeconds(15));

        Console.ReadLine();
    }
}

