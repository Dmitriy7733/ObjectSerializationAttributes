
using ObjectSerializationAttributes;
class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();
        //ApplyIniConfigurations(myObject); 

        Console.WriteLine($"Property1: {myObject.Property1}");
        Console.WriteLine($"Property2: {myObject.Property2}");
        Console.WriteLine($"Property3: {myObject.Property3}");

        Console.ReadLine();
    }
}