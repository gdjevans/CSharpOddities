// Single Responsibility Principle (SRP)
//Example: A class should have only one reason to change, meaning it should have only one job.
public class UserService
{
    public void RegisterUser(string username, string password)
    {
        // Register user logic
    }

    public void SendWelcomeEmail(string email)
    {
        // Email sending logic
    }

    public void GenerateUserReport(int userId)
    {
        // Report generation logic
    }
}

// After SRP (Adheres to SRP)
public class UserService
{
    public void RegisterUser(string username, string password)
    {
        // Register user logic
    }
}

public class EmailService
{
    public void SendWelcomeEmail(string email)
    {
        // Email sending logic
    }
}

public class ReportService
{
    public void GenerateUserReport(int userId)
    {
        // Report generation logic
    }
}
