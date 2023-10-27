namespace BasicsOfCsharp;
public interface IAirConditioner
{
    void Operate();
}

public class CoolingManager : IAirConditioner
{
    private readonly double _temprature;
    public CoolingManager(double temprature)
    {
        _temprature = temprature;
    }
    public void Operate()
    {
        Console.WriteLine($"temprateure: {_temprature}");
    }
}

public class WarmingManager : IAirConditioner
{
    private readonly double _temprature;
    public WarmingManager(double temprature)
    {
        _temprature = temprature;
    }
    public void Operate()
    {
        Console.WriteLine($"temprateure: {_temprature}");
    }
}

public abstract class AirConditionerFactory
{
    public abstract IAirConditioner Create(double temprateure);
}

public class CoolingFactory : AirConditionerFactory
{
    public override IAirConditioner Create(double temprateure)
    {
        IAirConditioner obj = new CoolingManager(temprateure);
        return obj;
    }
}

public class WarmingFactory : AirConditionerFactory
{
    public override IAirConditioner Create(double temprateure)
    {
        return new WarmingManager(temprateure);
    }
}


public class AirConditioner
{
    private readonly Dictionary<Actions, AirConditionerFactory> _factories;
    public AirConditioner()
    {
        _factories = new Dictionary<Actions, AirConditionerFactory>();
        foreach (Actions action in Enum.GetValues(typeof(Actions)))
        {
            // var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(Actions), action) + "Factory"));
            // var factoryTypeName = "FactoryMethod." + Enum.GetName(typeof(Actions), action) + "Factory"; //FactoryMethod.CoolingFactory
            var factoryTypeName = "BasicsOfCsharp." + Enum.GetName(typeof(Actions), action) + "Factory";
            var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType(factoryTypeName));
            _factories.Add(action, factory);
        }

        // _factories = new Dictionary<Actions, AirConditionerFactory>
        // {
        //     { Actions.Cooling, new CoolingFactory() },
        //     { Actions.Warming, new WarmingFactory() }
        // };
    }


    public IAirConditioner ExecuteCreation(Actions action, double temprateure) =>
    _factories[action].Create(temprateure);

}
