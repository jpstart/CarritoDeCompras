using System;
namespace CarritoDeCompras
{
    public class Impresora
    {
        public Impresora()
        {
        }

        public void ImprimirDatosCliente(Cliente cliente)
        {
            
            Console.WriteLine(cliente.Apellidos + cliente.Nombres);

            //return cliente.Nombres + " " + cliente.Apellidos;
            
        }
    }
}
