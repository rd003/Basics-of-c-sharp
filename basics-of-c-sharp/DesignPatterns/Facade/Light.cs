
namespace basics_of_c_sharp.DesignPatterns.Facade;

// Subsystem 1: Lights
public interface ILights
{
    void TurnOff();
    void TurnOn();
}

public class Lights : ILights
{
    public void TurnOn() => Console.WriteLine("Lights are ON");

    public void TurnOff() => Console.WriteLine("Lights are OFF");
}


// Subsystem 2: AirConditioner
public interface IAirConditioner
{
    void TurnOff();
    void TurnOn();
}


public class AirConditioner : IAirConditioner
{
    public void TurnOn() => Console.WriteLine("Air Conditioner is ON");

    public void TurnOff() => Console.WriteLine("Air Conditioner is OFF");
}


// Subsystem 3: SecuritySystem

public interface ISecuritySystem
{
    void Arm();
    void Disarm();
}

public class SecuritySystem : ISecuritySystem
{
    public void Arm() => Console.WriteLine("Security System is ARMED");

    public void Disarm() => Console.WriteLine("Security System is DISARMED");
}

public class HomeAutomationFacade
{
    private readonly ILights _lights;
    private readonly IAirConditioner _airConditioner;
    private readonly ISecuritySystem _securitySystem;

    public HomeAutomationFacade(ILights lights, IAirConditioner airConditioner, ISecuritySystem securitySystem)
    {
        _lights = lights;
        _airConditioner = airConditioner;
        _securitySystem = securitySystem;
    }

    public void LeaveHome()
    {
        _lights.TurnOff();
        _airConditioner.TurnOff();
        _securitySystem.Arm();
        Console.WriteLine("You have left home.");
    }

    public void EnterHome()
    {
        _lights.TurnOn();
        _airConditioner.TurnOn();
        _securitySystem.Disarm();
        Console.WriteLine("Welcome home!");
    }
}

public class FacadePatternTestDrive
{
    public static void Main(string[] args)
    {
        ILights lights = new Lights();
        IAirConditioner airConditioner = new AirConditioner();
        ISecuritySystem securitySystem = new SecuritySystem();

        HomeAutomationFacade facade = new HomeAutomationFacade(lights,airConditioner,securitySystem);

        // When leaving home
        facade.LeaveHome();

        // When entering home
        facade.EnterHome();
    }
}
