using System;
using System.Collections.Generic;
using System.Linq;

namespace CarritoDeCompras
{
    public class StockProductos
    {
        public StockProductos()
        {
            this.ListaStockProductos = new List<Producto>();
        }

       public List<Producto> ListaStockProductos { get; set; }

        public void CrearProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {
               
                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" +letra + numero + i;                
                producto.Precio = numero;

                Random existencia = new Random();
                producto.Existencia = existencia.Next(100);
                this.ListaStockProductos.Add(producto);
           }
       }

        //Modificar este método
        public void ImprimirStockProductos()
        {
            //Console.WriteLine("Stock de Productos");//
            //Console.WriteLine("Identificador\tDescripción\tPrecio");
            //foreach (var item in this.ListaStockProductos)
            //{
            //      Console.WriteLine("{0}\t\t{1}\t{2}",
            //    item.Identificador, item.Descripcion, item.Precio, item.Existencia);

            //    }
            Console.WriteLine("Stock de Productos");
            var precioproducto = from ordenarprecio in this.ListaStockProductos
                                 where ordenarprecio.Precio > 0
                                 orderby ordenarprecio.Precio descending
                                 select ordenarprecio;
            Console.WriteLine("Stock de Productos");
            foreach (var precioor in precioproducto)
            {
                Console.Write("\n" + "Identificador: " + precioor.Identificador + "--> Descripción: " + precioor.Descripcion + "--> Precio : " + precioor.Precio);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        public void BuscarProducto() {
            //Añadir método que permita la búsqueda de un producto del stock de productos y devuelva ese producto.
            Console.WriteLine("Ingrese el identificador del producto a buscar: ");
            int codigoPro = 0;
            codigoPro = int.Parse(Console.ReadLine());

            var resultadoscodigo = from codigo in this.ListaStockProductos
                                   where codigo.Identificador == codigoPro
                                   select codigo;
            foreach (var item in resultadoscodigo)
            {
                Console.WriteLine("Su producto es: " + item.Descripcion + " con el precio de: " + item.Precio);
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        //Añadir método que devuelva la cantidad de productos (stock total) que hay en el local por medio de ListaStockProductos.
        public void ProductoTotal()
        {
            var stocktotal = from total in this.ListaStockProductos
                             where total.Existencia > 0
                             select total.Existencia;
            var totalstock = stocktotal.Max();
            Console.WriteLine("El stock total de la tienda es de : " + totalstock);
            Console.WriteLine("Presione paa continuar");
            Console.ReadKey();

        }

        //Añadir método que devuelva el producto cuyo precio sea el mas alto.
        public void MaxAlto()
        {
            var Max = from MaxPro in this.ListaStockProductos
                      where MaxPro.Precio > 0
                      select MaxPro.Precio;
            var MaxPrecio = Max.Max();
            Console.WriteLine("El precio del producto mas caro es de: " + MaxPrecio);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        public void OrdernarMenorMayor() {

            var resultadoscodigo = this.ListaStockProductos.OrderBy(dato => dato.Precio);
            foreach (var item in resultadoscodigo)
            {
                Console.WriteLine("Su producto es: " + item.Descripcion + " con el precio de: " + item.Precio);
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }


    }

}
