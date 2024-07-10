using EJERCICIO_PREPARATORIO_STRATEGY.DB;
using EJERCICIO_PREPARATORIO_STRATEGY.Interfaces;
using EJERCICIO_PREPARATORIO_STRATEGY.Modelos;
using EJERCICIO_PREPARATORIO_STRATEGY.Proceso;
namespace EJERCICIO_PREPARATORIO_STRATEGY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            interfaz();
        }
        public static void interfaz()
        {
            Console.WriteLine("\nRegitrar Productos\n");
            Console.WriteLine("Seleccione el tipos de producto: \n[1] Canasta basica \n[2] Textiles \n[3] Deportivos \n[4] Electronicos");
            Console.WriteLine("\nSeleccione [5] para mostrar el listado de todos los productos con el precio de venta");
            Console.Write(">> ");
            int opcion = int.Parse( Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("CANASTA BASICA\n");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Precio: ");
                    double precio = double.Parse( Console.ReadLine());

                    ProductoCanastaBasica canasta = new ProductoCanastaBasica(nombre, precio);
                    Contexto contexto = new Contexto(canasta);
                    contexto.ejecutarProcesoImpuesto();

                    DBProductos.ListaProductoCanastaBasicas.Add(canasta);
                    break;
                case 2:
                    Console.WriteLine("TEXTILES\n");
                    Console.Write("Nombre: ");
                    string nombre2 = Console.ReadLine();
                    Console.Write("Color: ");
                    string color = Console.ReadLine();
                    Console.Write("Tipo de Tela: ");
                    string tipoTela = Console.ReadLine();
                    Console.Write("Precio: ");
                    double precio2 = double.Parse(Console.ReadLine());
        
                    ProductoTextiles textiles = new ProductoTextiles(nombre2,color,tipoTela,precio2);
                    Contexto contexto2 = new Contexto(textiles);
                    contexto2.ejecutarProcesoImpuesto();

                    DBProductos.ListaProductoTextiles.Add(textiles);
                    break;

                case 3:
                    Console.WriteLine("DEPORTIVOS\n");
                    Console.Write("Nombre: ");
                    string nombre3 = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Color: ");
                    string color2 = Console.ReadLine();
                    Console.Write("Precio: ");
                    double precio3 = double.Parse(Console.ReadLine());

                    ProductoDepertivo depertivo = new ProductoDepertivo(nombre3,marca,color2,precio3);  
                    Contexto contexto3 = new Contexto(depertivo);
                    contexto3.ejecutarProcesoImpuesto();

                    DBProductos.ListaProductoDepertivo.Add(depertivo);
                    break;

                case 4:
                    Console.WriteLine("ELECTRONICOS\n");
                    Console.Write("Nombre: ");
                    string nombre4 = Console.ReadLine();
                    Console.Write("Modelo: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Precio: ");
                    double precio4 = double.Parse(Console.ReadLine());

                    ProductoElectronico electronico = new ProductoElectronico(nombre4, modelo, precio4);
                    Contexto contexto4 = new Contexto(electronico);
                    contexto4.ejecutarProcesoImpuesto();

                    DBProductos.ListaProductoElectronico.Add(electronico);
                    
                    break;
                case 5:
                    Console.WriteLine("CANASTA BASICA\n");
                    foreach (ProductoCanastaBasica producto in DBProductos.ListaProductoCanastaBasicas)
                    {
                        Console.WriteLine($"Nombre: {producto.nombre}\nPrecio: {producto.precio}\nImpuesto: {producto.impuesto}%\nTotal: {producto.total}\n");
                    }
                    Console.WriteLine("TEXTILES\n");
                    foreach(ProductoTextiles producto1 in DBProductos.ListaProductoTextiles)
                    {
                        Console.WriteLine($"Nombre: {producto1.nombre}\nColor: {producto1.color}\nTipo de tela: {producto1.tipoTela}\nPrecio: {producto1.precio}\nImpuesto: {producto1.impuesto}%\nTotal: {producto1.total}\n");
                    }
                    Console.WriteLine("DEPORTIVOS\n");
                    foreach(ProductoDepertivo producto2 in DBProductos.ListaProductoDepertivo)
                    {
                        Console.WriteLine($"Nombre: {producto2.nombre}\nMarca: {producto2.marca}\nColor: {producto2.color}\nPrecio: {producto2.precio}\nImpuesto: {producto2.impuesto}%\nTotal: {producto2.total}\n");
                    }
                    Console.WriteLine("ELECTRONICOS\n");
                    foreach (ProductoElectronico producto3 in DBProductos.ListaProductoElectronico)
                    {
                        Console.WriteLine($"Nombre: {producto3.nombre}\nModelo: {producto3.modelo}\nPrecio: {producto3.precio}\nImpuesto: {producto3.impuesto}%\nTotal: {producto3.total}\n");
                    }
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
            interfaz();
        }
    }
}
