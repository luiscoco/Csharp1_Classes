// Usage example
class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.Year = 2020;

        myCar.StartEngine(); // Output: Engine started.

        // Event subscription
        myCar.EngineStarted += MyCar_EngineStarted;

        // Raise the event
        myCar.OnEngineStarted(EventArgs.Empty);
    }

    private static void MyCar_EngineStarted(object sender, EventArgs e)
    {
        Console.WriteLine("Luis Engine started event received.");
    }
}

// Example class representing a car
public class Car
{
    // Fields
    private string make;
    private string model;
    private int year;

    // Properties
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Method
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    // Event
    public event EventHandler EngineStarted;

    // Method to raise the EngineStarted event
    public virtual void OnEngineStarted(EventArgs e)
    {
        EngineStarted?.Invoke(this, e);
    }
}

