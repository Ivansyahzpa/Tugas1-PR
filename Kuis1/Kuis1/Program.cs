using System.Xml.Linq;

class Shape
{
    public int Sisi;
    public int Dimensi;
    public string Luas;
    public string Volume;
}
class TwoDimensionalShape : Shape
{
    public TwoDimensionalShape()
    {
        Dimensi = 2;
        Luas = "Punya Luas";
    }
    public virtual void HitungLuas()
    {
        Console.WriteLine("Menghitung Luas Bangun Datar");
    }
}
class ThreeDimensionalShape : Shape
{
    public ThreeDimensionalShape()
    {
        Dimensi = 3;
        Volume = "Punya Volume";
    }
    public virtual void HitungVolume()
    {
        Console.WriteLine("Menghitung Volume Bangun Ruang");
    }
}
class Circle : TwoDimensionalShape
{
    public Circle()
    {
        Sisi = 1;
        Luas = "Punya Luas";
    }
    public override void HitungLuas()
    {
        Console.WriteLine("Lingkaran Punya Luas 616 cm persegi");
    }
}
class square : TwoDimensionalShape
{
    public square()
    {
        Sisi = 4;
        Luas = "Punya Luas";
    }
    public override void HitungLuas()
    {
        Console.WriteLine("Persegi Punya Luas 36 cm persegi");
    }
}
class Triangle : TwoDimensionalShape
{
    public Triangle()
    {
        Sisi = 3;
        Luas = "Punya Luas";
    }
    public override void HitungLuas()
    {
        Console.WriteLine("Segitiga Punya Luas 16 cm Persegi");
    }
    private int Alas = 6;
    public int getPanggilAlas()
    {
        return Alas;
    }
}
class Sphere : ThreeDimensionalShape
{
    public Sphere()
    {
        Sisi = 1;
        Volume = "Punya Volume";
    }
}
class Cube : ThreeDimensionalShape
{
    public Cube()
    {
        Sisi = 6;
        Volume = "Punya Volume";
    }
    public override void HitungVolume()
    {
        Console.WriteLine("Kubus Punya Volume 36 cm kubik");
    }
}
class Tetrahedron : ThreeDimensionalShape
{
    public Tetrahedron()
    {
        Sisi = 4;
        Volume = "Punya Volume";
    }
}
class Program
{
    static void Main(string[] args)
    {
        TwoDimensionalShape BangunDatar = new TwoDimensionalShape();
        BangunDatar.HitungLuas();
        TwoDimensionalShape Lingkaran = new Circle();
        Lingkaran.HitungLuas();
        TwoDimensionalShape Persegi = new square();
        Persegi.HitungLuas();
        TwoDimensionalShape Segitiga = new Triangle();
        Triangle segiTiga = new Triangle();
        Console.WriteLine("Memiliki Alas : "+ segiTiga.getPanggilAlas());
        Segitiga.HitungLuas();
        ThreeDimensionalShape BangunRuang = new ThreeDimensionalShape();
        BangunRuang.HitungVolume();
        ThreeDimensionalShape Kubus = new Cube();
        Kubus.HitungVolume();
        Console.WriteLine();
    }
}