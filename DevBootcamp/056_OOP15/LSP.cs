// Liskov Substitution Principle (LSP)
// Example: Subtypes must be substitutable for their base types without altering the correctness of the program.
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException();
    }
}

// After LSP (Adheres to LSP)
public abstract class Bird
{
    public abstract void Move();
}

public class Sparrow : Bird
{
    public override void Move()
    {
        Console.WriteLine("Flying");
    }
}

public class Ostrich : Bird
{
    public override void Move()
    {
        Console.WriteLine("Running");
    }
}
