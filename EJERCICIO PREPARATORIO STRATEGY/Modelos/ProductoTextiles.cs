using EJERCICIO_PREPARATORIO_STRATEGY.Interfaces;

namespace EJERCICIO_PREPARATORIO_STRATEGY.Modelos
{
    internal class ProductoTextiles : IProceso, IAplicarImpuesto
    {
        public string nombre { get; set; }
        public string color { get; set; }
        public string tipoTela { get; set; }
        public double precio { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }

        public ProductoTextiles(string nombre, string color, string tipoTela, double precio)
        {
            this.nombre = nombre;
            this.color = color;
            this.tipoTela = tipoTela;
            this.precio = precio;
            this.impuesto = 10;
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
