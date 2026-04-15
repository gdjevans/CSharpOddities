using System;

// Event publisher class
public class EventPublisher
{
    // Define an event using EventHandler delegate
    public event EventHandler<string> MyEvent;
    // Method to trigger the event
    public void TriggerEvent(string message)
    {
        // Check if there are subscribers to the event
        if (MyEvent != null)
        {
            // Invoke the event with the message
            MyEvent(this, message);
        }
    }
}
// Event subscriber class
public class EventSubscriber
{
    // Constructor to subscribe to the event
    public EventSubscriber(EventPublisher publisher)
    {
        // Subscribe to the event by adding a handler method
        publisher.MyEvent += HandleEvent;
    }
    // Event handler method
    private void HandleEvent(object sender, string message)
    {
        Console.WriteLine("Event received: " + message);
    }
}

// Main method to demonstrate usage
public class Program
{
    public static void Main()
    {
        // Create an instance of the event publisher
        EventPublisher publisher = new EventPublisher();

        // Create an instance of the event subscriber
        EventSubscriber subscriber = new EventSubscriber(publisher);

        // Trigger the event with a message
        publisher.TriggerEvent("Hello from the event!");

        // Output:
        // Event received: Hello from the event!
    }
}
