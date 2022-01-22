using System;
using System.Linq;

namespace CarritoDeCompras
{
    class MainClass
    {
        public static void Main(string[] args)
        {           
            StockProductos stock = new StockProductos();
            stock.CrearProductos();
            stock.ImprimirStockProductos();
            stock.BuscarProducto();
            stock.OrdernarMenorMayor();
            stock.MaxAlto();


            ClienteSinRegistro cliente = new ClienteSinRegistro();
            cliente.Apellidos = "Zambrano Zambrano";
            cliente.Nombres = "Michael Jackson";
            cliente.Email = "michael@web.com";
            cliente.Cedula = "1112223334";
            cliente.Contrasena = "mzambrano";

            Empresa empresa = new Empresa();
            empresa.RazonSocial = "Amazon";
            empresa.Direccion = "California";

            CabeceraFactura cabeceraCarrito = new CabeceraFactura();
            cabeceraCarrito.ClienteCabecera = cliente;
            cabeceraCarrito.EmpresaCabecera = empresa;


        }
    





        /*
1)	Utilizando expresiones lambda o linq cree un método en la clase program.cs que permita devuelva los items agregados a la factura ordenados por precio de menor a mayor. (1 Punto)
2)	Utilizando expresiones lambda o linq cree un método en la clase program.cs que permita calcular el subtotal de los items agregados a la factura. (2 Puntos)
3)	Utilizando expresiones lambda o linq cree un método en la clase program.cs que permita la búsqueda de un producto en particular de la colección de datos factura.Detalle y al encontrarlo devuelva ese producto. (1 Punto)
4)	Utilizando expresiones lambda o linq realice un método que devuelva la cantidad de productos que se están facturando en la colección de datos factura.Detalle. (1P)
5)	Utilizando expresiones lambda o linq realice un método que devuelva el producto cuyo precio sea el mas alto en la colección de datos factura.Detalle. (1P)
         */
    }
}
