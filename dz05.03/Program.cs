using System;

class WebSite
{
    public string name;
    public string address;
    public string description;
    public string ipAddress;

    public string getName()
    {
        return name;
    }

    public string getAddress()
    {
        return address;
    }

    public string getDescription()
    {
        return description;
    }

    public string getIpAddress()
    {
        return ipAddress;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setAddress(string address)
    {
        this.address = address;
    }

    public void setDescription(string description)
    {
        this.description = description;
    }

    public void setIpAddress(string ipAddress)
    {
        this.ipAddress = ipAddress;
    }

    public void printInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Description: " + description);
        Console.WriteLine("IP Address: " + ipAddress);
    }

    public WebSite(string name, string address, string description, string ipAddress)
    {
        this.name = name;
        this.address = address;
        this.description = description;
        this.ipAddress = ipAddress;
    }
}

class Program
{
    static void Main()
    {
        WebSite site = new WebSite("Google", "www.google.com", "Search engine", "");
        site.printInfo();
    }
}