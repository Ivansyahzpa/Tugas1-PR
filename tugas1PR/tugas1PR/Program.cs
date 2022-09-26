using ProcessorNih;
using VgaNih;

namespace Tugas1PR
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Jawaban Pertanyaan");

            Laptop laptop1 = new Vivobook();
            Laptop laptop2 = new IdeaPad();
            Predator predator = new Predator();

            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();
            laptop2.vga = new VgaNih.AMD();
            laptop2.processor = new Ryzen();
            predator.vga = new VgaNih.AMD();
            predator.processor = new Corei7();

            ////Pertanyaan nomor 1
            //Console.WriteLine("Pertanyaan Nomor 1");
            //laptop2.LaptopDimatikan();
            //laptop2.LaptopDinyalakan();

            ////Pertanyaan nomor 2
            //Console.WriteLine("Pertanyaan Nomor 2");
            //laptop1.Ngoding();

            ////Pertanyaan nomor 3
            //Console.WriteLine("Pertanyaan Nomor 3");
            //Console.WriteLine("Spesifikasi Laptop 1 \n" + "Merk Vga : " + laptop1.vga.merk + "\n" + "Merk Processor : " + laptop1.processor.merk + "\n" + "Tipe Processor : " + laptop1.processor.tipe);

            ////Pertanyaan nomor 4
            //Console.WriteLine("Pertanyaan Nomor 4");
            //predator.BermainGame();

            ////Pertanyaan nomor 5
            //Console.WriteLine("Pertanyaan Nomor 5");
            //ACER acer = new Predator();
            //acer.BermainGame();
        }
    }
}