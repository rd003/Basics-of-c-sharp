namespace basics_of_c_sharp.DesignPatterns.ObserverPattern;

public interface ISubject
{
   int State { get; set; }
   void Attach(IMyObserver observer);
   void Detach(IMyObserver observer);
   void NotifyObservers();
}

public interface IMyObserver
{
    void Update(ISubject subject);
}
public class Subject : ISubject
{
    private List<IMyObserver> _observers= new List<IMyObserver>();

    private int _state;
    public int State { get { return _state; }
        set
        {
            _state = value;
            NotifyObservers();
        }
    }

    public void Attach(IMyObserver observer) => _observers.Add(observer);

    public void Detach(IMyObserver observer) => _observers.Remove(observer);

    public void NotifyObservers()
    {
       foreach(var observer in _observers)
        {
            observer.Update(this); 
        }
    }
}

public class Observer1 : IMyObserver
{
    private readonly ISubject _subject;
    public Observer1(ISubject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }
    public void Update(ISubject subject)
    {
        Console.WriteLine($"observer 1: state:{subject.State}");
    }
}

public class Observer2 : IMyObserver
{
    private readonly ISubject _subject;
    public Observer2(ISubject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }
    public void Update(ISubject subject)
    {
        Console.WriteLine($"observer 2: state:{subject.State}");
    }
}

public class Program
{
    public static void Main()
    {
        Subject subject = new Subject();

        Observer1 observer1 = new Observer1(subject);
        Observer2 observer2 = new Observer2(subject);

        subject.State = 1;
        subject.State = 2;

        subject.Detach(observer1);
        subject.State = 4;
    }
}
