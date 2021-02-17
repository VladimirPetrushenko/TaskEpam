using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            OneSubject steelWire = new OneSubject("Стальной провод", new Material("Сталь", 7850),0.03);
            Console.WriteLine(steelWire);
            steelWire.Material = new Material("Медь", 8500);
            //steelWire.Material.Name = "Медь";
            //steelWire.Material.Density = 8500;
            Console.WriteLine(steelWire.GetMass());
        }
    }
    class Material 
    {
        private string name;
        private double density;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public double Density {
            get { return density; }
            set { density = value; }
        }
        public Material() 
        {
        
        }

        public Material(string name, double density) 
        {
            this.name = name;
            this.density = density;
        }
        public override string ToString()
        {
            return name + ";" + density;
        }
    }
    class OneSubject
    {
        private string name;
        private Material material;
        private double volume;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Material Material
        {
            get { return material; }
            set { material = value; }
        }
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public OneSubject() 
        {
        
        }
        public OneSubject(string name, Material material, double volume) 
        {
            this.name = name;
            this.material = material;
            this.volume = volume;
        }
        public double GetMass() 
        {
            return material.Density * volume;
        }
        public override string ToString()
        {
            return name + ";" + material + ";" + volume + ";" + GetMass();
        }
    }
}
