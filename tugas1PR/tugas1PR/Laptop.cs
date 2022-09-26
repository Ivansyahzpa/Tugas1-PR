using ProcessorNih;
using VgaNih;

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}
class ASUS : Laptop
{
    public ASUS()
    {
        merk = "ASUS";
    }
}
class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}
class ROG : ASUS
{
    public ROG()
    {
        tipe = "ROG";
    }
}
class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class Swift : ACER
{
    public Swift()
    {
        tipe = "Swift";
    }
}
class Predator : ACER
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}
class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}