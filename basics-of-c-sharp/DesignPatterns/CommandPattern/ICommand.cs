namespace basics_of_c_sharp.DesignPatterns.CommandPattern;

// command interface
public interface ICommand
{
    void Execute();
    void Undo();
}

// receiver
public class BankAccount
{
    public decimal Balance { get; set; }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
        Console.WriteLine($"Withdrawn {amount}. New balance: {Balance}");
    }
}

// ConcreteCommand (DepositCommand)
public class DepositCommand : ICommand
{
    private readonly BankAccount _account;
    private decimal _amount;

    public DepositCommand(BankAccount account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }

    public void Execute()
    {
        _account.Deposit(_amount);
    }

    public void Undo()
    {
        _account.Withdraw(_amount);
    }
}

public class WithDrawCommand : ICommand
{
    private readonly BankAccount _account;
    private decimal _amount;

    public WithDrawCommand(BankAccount account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }

    public void Execute()
    {
        _account.Withdraw(_amount);
    }

    public void Undo()
    {
        _account.Deposit(_amount);
    }
}

// invoker

public class BankAccountManager
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteTransaction()
    {
        _command.Execute();
    }

    public void UndoTransaction()
    {
        Console.WriteLine("Undoing last transaction.");
        _command.Undo();
    }
}

// Client code
public class Program
{
    public static void Main()
    {
        BankAccount bankAccount = new();

        DepositCommand depositCommand = new (bankAccount,200);
        WithDrawCommand withDrawCommand = new (bankAccount,100);

        BankAccountManager accountManager = new();
        
        accountManager.SetCommand(depositCommand);
        accountManager.ExecuteTransaction();

        accountManager.SetCommand(withDrawCommand);
        accountManager.ExecuteTransaction();

        accountManager.UndoTransaction();

        /*
         * output
         * Deposited 200. New balance: 200
         * Withdrawn 100. New balance: 100
         * Undoing last transaction.
         * Deposited 100. New balance: 200
         */
    }
}