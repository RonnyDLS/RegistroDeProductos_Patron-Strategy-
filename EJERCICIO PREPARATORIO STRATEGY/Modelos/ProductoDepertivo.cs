using EJERCICIO_PREPARATORIO_STRATEGY.Interfaces;

namespace EJERCICIO_PREPARATORIO_STRATEGY.Modelos
{
    internal class ProductoDepertivo : IProceso, IAplicarImpuesto
    {
        public string nombre { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public double precio { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }

        public ProductoDepertivo(string nombre, string marca, string color, double precio)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.color = color;
            this.precio = precio;
            this.impuesto = 15;
        }

        public void ejecutar()
        {
            aplicarImpuesto();
        }
        public void aplicarImpuesto()
        {
            double porciento = impuesto / 100;
            double impu = precio * porciento; 
            total = impu + precio;
        }
    }
}
