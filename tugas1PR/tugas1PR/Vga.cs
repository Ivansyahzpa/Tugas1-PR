namespace VgaNih
{
    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
}