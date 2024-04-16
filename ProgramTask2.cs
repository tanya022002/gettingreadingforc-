
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Task 1: Generics and Data Handling
        DataHandler<int> intDataHandler = new DataHandler<int>();
        intDataHandler.AddData(10);
        intDataHandler.AddData(20);
        int retrievedData = intDataHandler.RetrieveData(1);
        Console.WriteLine($"Retrieved data: {retrievedData}");

        // Task 2: Interfaces and Devices
        DeviceController tvController = new DeviceController("TV");
        tvController.Activate();

        // Task 3: Abstract Classes and Vehicles
        Car myCar = new Car();
        Bike myBike = new Bike();

        myCar.StartEngine();
        myCar.Accelerate();

        myBike.StartEngine();
        myBike.Accelerate();
    }
}

// Task 1: Generics and Data Handling
public class DataHandler<T>
{
    private List<T> data = new List<T>();

    public void AddData(T item)
    {
        data.Add(item);
    }

    public T RetrieveData(int index)
    {
        if (index >= 0 && index < data.Count)
        {
            return data[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of range.");
        }
    }
}

// Task 2: Interfaces and Devices
public interface IDevice
{
    void Activate();
}

public class DeviceController : IDevice
{
    private string deviceType;

    public DeviceController(string deviceType)
    {
        this.deviceType = deviceType;
    }

    public void Activate()
    {
        Console.WriteLine($"The {deviceType} is now active.");
    }
}

// Task 3: Abstract Classes and Vehicles
public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void Accelerate();
}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Car is accelerating.");
    }
}

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Bike is pedaling.");
    }
}
