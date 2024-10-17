//Project to implement the following goals using single level inheritance:
//a)Name, Price, Processor, Ram and hard drive should be defined in base class as constant.
//b)You need to inherit these functionalities in your program and print the details.
//c)All the laptops should have different name , prices . processor, ram and hard drive.

using System;
class LaptopBase {
    protected const string name = "Base Laptop";
    protected const double price = 100000;
    protected const string processor = "Intel i5";
    protected const string RAM = "8GB";
    protected const string harddrive = "256 GB";
}
class Laptop : LaptopBase {
    public void Print(string name, double price,string pro,string ram,string hd)
    {
        Console.WriteLine("Name=" + name + " price:" + price + " processor:" + pro + " ram:" + ram + " hard drive:" + hd);
    }

}
class Program
{
    public static void Main(string[] args)
    {
        Laptop l1 = new Laptop();
        l1.Print("Lap A",30000,"intel i5","4 GB","128 GB");
        Laptop l2= new Laptop();
        l2.Print("Lap B", 700000, "intel i9", "32 GB", " 1 TB");
        Console.ReadKey();
    }
}


