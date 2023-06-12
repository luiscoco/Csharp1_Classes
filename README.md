# Csharp1_classes

In C#, classes are used to define objects that encapsulate data and behavior. They serve as blueprints or templates for creating instances, which are specific objects based on the class definition. Classes in C# can have fields, properties, methods, and events. Here's an explanation of each component:

Fields: Fields are variables that hold data specific to an instance of the class. They define the state of the object. You can declare fields within a class to represent its characteristics.

Properties: Properties provide a way to encapsulate fields and control access to them. They define the public interface of the class. Properties typically have a get accessor to retrieve the value and a set accessor to modify the value.

Methods: Methods contain executable code that defines the behavior of the class. They perform actions and can manipulate the object's state. Methods can have parameters and return values.

Events: Events enable communication between objects. They allow one object to notify others when a particular action or state change occurs. Events follow the publisher-subscriber pattern.

Now, let's see some code samples that demonstrate the usage of classes in C#:

```csharp
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
    protected virtual void OnEngineStarted(EventArgs e)
    {
        EngineStarted?.Invoke(this, e);
    }
}

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
        Console.WriteLine("Engine started event received.");
    }
}
```

In the example above, we defined a Car class with fields (make, model, and year), properties (Make, Model, and Year), a method (StartEngine()), and an event (EngineStarted). We then created an instance of the Car class and demonstrated how to access its properties, invoke the method, and subscribe to the event.

