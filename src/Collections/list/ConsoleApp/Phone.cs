using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

internal class Phone
{
    public string Model { get; private set; }
    public bool IsRunning { get; private set; }

    private Battery phoneBattery;

    public int BatteryLevel
    {
        get
        {
            return phoneBattery.BatteryLevel;
        }
    }

    public Phone(string model, Battery myBattery) // Constructor (is a method), which is called when an object is created
    {
        Model = model;
        IsRunning = false;
        phoneBattery = myBattery;
    }

    public void PowerOn() // First method
    {
        if (phoneBattery.BatteryLevel > 0)
        {
            IsRunning = true;
            Console.WriteLine($"{Model} has been turned on.");
        }
        else
            Console.WriteLine("The battery is flat. The phone cannot be turned on.");
    }

    public void PowerOff()
    {
        if (IsRunning)
        {
            IsRunning = false;
            Console.WriteLine($"{Model} has been turned off.");
        }
        else
            Console.WriteLine($"{Model} is already turned off.");
    }
}

class Battery
{
    public int BatteryLevel { get; set; }
    public Battery(int initialBattery)
    {
        BatteryLevel = initialBattery;
    }
}