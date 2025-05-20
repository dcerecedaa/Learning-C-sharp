using System;

namespace GestionSmartphones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Smartphone objects
            Smartphone smartphone1 = new Smartphone();
            Smartphone smartphone2 = new Smartphone("Samsung", "Galaxy S21", 128, true, 799.99);

            // Displaying information of the smartphones
            Console.WriteLine($"Smartphone 1 info: {smartphone1.getInfoSmartphone()}");
            Console.WriteLine($"Smartphone 2 info: {smartphone2.getInfoSmartphone()}");

            // Applying discount to smartphone 2
            smartphone2.aplicarDescuento(20);

            // Displaying updated information after applying the discount
            Console.WriteLine($"Smartphone 2 new price: {smartphone2.getPrecio()} euros");

            // Checking 5G connectivity
            Console.WriteLine($"Smartphone 2: {smartphone2.tieneConectividad5G()}");
        }
    }

    class Smartphone
    {
        // Class fields
        private string marca;
        private string modelo;
        private int almacenamiento;
        private bool tiene5G;
        private double precio;

        // Default constructor
        public Smartphone()
        {
            marca = "Generic";
            modelo = "ModelX";
            almacenamiento = 64;
            tiene5G = false;
            precio = 299.99;
        }

        // Constructor with parameters
        public Smartphone(string marca, string modelo, int almacenamiento, bool tiene5G, double precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.almacenamiento = almacenamiento;
            this.tiene5G = tiene5G;
            this.precio = precio;
        }

        // Public methods
        public string getInfoSmartphone()
        {
            return $"Brand: {marca}, Model: {modelo}, Storage: {almacenamiento}GB, 5G: {tiene5G}, Price: {precio:F2} euros";
        }

        public void aplicarDescuento(double porcentaje)
        {
            try
            {
                if (porcentaje > 0 && porcentaje <= 100)
                {
                    precio -= precio * (porcentaje / 100);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error applying discount: " + e.Message);
            }
        }

        public string tieneConectividad5G()
        {
            return tiene5G ? "This smartphone supports 5G connectivity." : "This smartphone does not support 5G connectivity.";
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double nuevoPrecio)
        {

            if (nuevoPrecio > 0)
            {

                precio = nuevoPrecio;
            }
            else
            {
                Console.WriteLine("Invalid price. Price must be greater than 0.");

            }
        }
    }
}
