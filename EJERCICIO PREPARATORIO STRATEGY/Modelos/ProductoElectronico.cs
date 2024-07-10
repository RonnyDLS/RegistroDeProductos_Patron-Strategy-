using EJERCICIO_PREPARATORIO_STRATEGY.Interfaces;

namespace EJERCICIO_PREPARATORIO_STRATEGY.Modelos
{
    internal class ProductoElectronico : IProceso, IAplicarImpuesto
    {
        public string nombre { get; set; }
        public string modelo { get; set; }
        public double precio { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }

        public ProductoElectronico(string nombre, string modelo, double precio)
        {
            this.nombre = nombre;
            this.modelo = modelo;
            this.precio = precio;
            this.impuesto = 20;
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
