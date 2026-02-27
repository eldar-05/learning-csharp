using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Program
{
    static void Main()
    {
        ElectricBus ve = new ElectricBus();
        ve.setFuelLevel(100);
        ve.setMaxSpeed(200);
        ve.setLisencePlate("VKENVSNFKCJ-4838563");
        ve.setBatteryKWh(500);
        ve.updateLocation();


        ve.getInfo();
        Console.WriteLine(" ");

        GasolineTruck truck = new GasolineTruck();
        truck.setFuelLevel(50);
        truck.setMaxSpeed(150);
        truck.setLisencePlate("VKENVSNFKCJ-41982379865");
        truck.setCargoCapacity(10000);

        truck.getInfo();
        Console.ReadLine();
    }
}

abstract class Vehicle
{
    private decimal fuelLevel;
    private int maxSpeed;
    private String lisencePlate;

    public void setFuelLevel(decimal fuelLevel)
    {
        if(fuelLevel < 0)
        {
            Console.WriteLine("Fuel level cannot be negative.");
        } else
        {
            this.fuelLevel = fuelLevel;
        }
    }

    public decimal getFuelLevel()
    {
        return fuelLevel;
    }

    public void setMaxSpeed (int maxSpeed)
    {
        this.maxSpeed = maxSpeed;
    }

    public int getMaxSpeed()
    {
        return maxSpeed;
    }

    public void setLisencePlate(String lisencePlate)
    {
        this.lisencePlate = lisencePlate;
    }

    public String getLisencePlate()
    {
        return lisencePlate;
    }

    virtual public void refuel()
    {
        Console.WriteLine("Refueling the not registered vehicle");
    }

    virtual public void getInfo()
    {
        Console.WriteLine("Fuel Level: " + fuelLevel);
        Console.WriteLine("Max Speed: " + maxSpeed);
        Console.WriteLine("Lisence Plate: " + lisencePlate);
    }
}

class ElectricBus : Vehicle
{
    private int batteryKWh;

    public void setBatteryKWh(int batteryKWh)
    {
        this.batteryKWh = batteryKWh;
    }

    public int getBatteryKWh()
    {
        return batteryKWh;
    }

    override public void refuel()
    {
        Console.WriteLine("charging the batteries");
    }

    public override void getInfo()
    {
        base.getInfo();
        Console.WriteLine("battery cap"+ batteryKWh);
    }
}

class GasolineTruck : Vehicle, GPS_Trackable
{
    private int cargoCapacity;

    public void setCargoCapacity(int cargoCapacity)
    {
        this.cargoCapacity = cargoCapacity;
    }

    public int getCargoCapacity()
    {
        return cargoCapacity;
    }

    override public void refuel()
    {
        Console.WriteLine("pooring the gasoline");
    }

    public override void getInfo()
    {
        base.getInfo();
        Console.WriteLine("Capacity cargo: " + cargoCapacity);
    }

    public void updateLocation()
    {
        Console.WriteLine("yes it's gps trackabel");
    }
}

interface GPS_Trackable
{
    public void updateLocation();
}
