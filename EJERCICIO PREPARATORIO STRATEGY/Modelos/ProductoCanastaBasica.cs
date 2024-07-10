using EJERCICIO_PREPARATORIO_STRATEGY.Interfaces;

namespace EJERCICIO_PREPARATORIO_STRATEGY.Modelos
{
    internal class ProductoCanastaBasica : IProceso
    {
        public string nombre { get; set; }
        public double precio { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }

        public ProductoCanastaBasica(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.impuesto = 0;
        }

        public void ejecutar()
        {
            total = precio;
        }
    }
}
