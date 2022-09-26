namespace ProcessorNih
{
    class Processor
    {
        public string merk;
        public string tipe;
    }
    class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }
    class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
    class Corei3 : Intel
    {
        public Corei3()
        {
            tipe = "Core i3";
        }
    }
    class Corei5 : Intel
    {
        public Corei5()
        {
            tipe = "Core i5";
        }
    }
    class Corei7 : Intel
    {
        public Corei7()
        {
            tipe = "Core i7";
        }
    }
    class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "Rayzen";
        }
    }
    class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "Athlon";
        }
    }
}