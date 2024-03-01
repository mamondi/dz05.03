using System;

class Plane
{
    public string planeName;    
    public string manufacturer;
    public int year;
    public string planeType;

    public Plane(){}

    public Plane(string planeName, string manufacturer, int year, string planeType)
    {
        this.planeName = planeName;
        this.manufacturer = manufacturer;
        this.year = year;
        this.planeType = planeType;
    }

    public void SetData(string planeName, string manufacturer, int year, string planeType)
    {
        this.planeName = planeName;
        this.manufacturer = manufacturer;
        this.year = year;
        this.planeType = planeType;
    }

    public void GetData()
    {
        Console.WriteLine("Plane name: {0}", planeName);
        Console.WriteLine("Manufacturer: {0}", manufacturer);
        Console.WriteLine("Year: {0}", year);
        Console.WriteLine("Plane type: {0}", planeType);
    }

    public void GetPlaneType()
    {
        Console.WriteLine("Plane type: {0}", planeType);
    }

    public void GetPlaneName()
    {
        Console.WriteLine("Plane name: {0}", planeName);
    }

    public void GetManufacturer()
    {
        Console.WriteLine("Manufacturer: {0}", manufacturer);
    }

    public void GetYear()
    {
        Console.WriteLine("Year: {0}", year);
    }

    public void SetPlaneType(string planeType)
    {
        this.planeType = planeType;
    }

    public void SetPlaneName(string planeName)
    {
        this.planeName = planeName;
    }

    public void SetManufacturer(string manufacturer)
    {
        this.manufacturer = manufacturer;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane();
        plane.SetData("Boeing 747", "Boeing", 1969, "Passenger");
        plane.GetData();
    }
}