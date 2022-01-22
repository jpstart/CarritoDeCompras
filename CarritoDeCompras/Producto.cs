using System;
namespace CarritoDeCompras
{
    //Clase se convierte en abstracta, no se pueden crear instancias de esta clase
    public class Producto
    {
        public Producto()
        {
        }

        /// <summary>
        /// Indica el identificador del producto, es un valor único
        /// </summary>
        public int Identificador { get; set; }

        /// <summary>
        /// Indica el nombre o descripcion del producto
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Indica el precio del producto. Ej.: 10,00
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Indica la cantidad de productos que existe en la tienda
        /// </summary>
        public int Existencia { get; set; }

        /// <summary>
        /// Indica la categoria a la que pertenece el producto
        /// </summary>
        public string Categoria { get; set; }

        
        

    }
}
