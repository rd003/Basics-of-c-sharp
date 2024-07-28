namespace basics_of_c_sharp.DesignPatterns.FactoryMethod;


// creator
public abstract class NotificationCreator
{
    protected abstract INotification CreateNotification();

    public void Notify(string message)
    {
        INotification notification = CreateNotification();
        notification.Send(message);
    }
}


// Product
public interface INotification
{
    void Send(string message);
}

// Concrete Product

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent..\n msg: {message}");
    }
}

// Concrete Product

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sms sent..\n msg: {message}");
    }
}

// Concrete Product

public class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push notification sent..\n msg: {message}");
    }
}

// concrete creator
public class EmailNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}

// concrete creator
public class SmsNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}

// concrete creator
public class PushNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new PushNotification();
    }
}

// Notification test

public class NotificationTest
{
    public static void Main()
    {
        NotificationCreator creator;

        creator = new EmailNotificationCreator();
        creator.Notify("Hello");

        creator = new SmsNotificationCreator();
        creator.Notify("Hello again");

        Console.ReadLine();

    }
}