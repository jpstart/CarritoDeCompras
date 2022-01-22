using System;
namespace CarritoDeCompras
{
    public class Cliente
    {
        public Cliente()
        {
        }
        /// <summary>
        /// Es un valor único que identifica al cliente
        /// </summary>
        public string Cedula { get; set; }

        /// <summary>
        /// Indica los nombres del cliente
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Indica los apellidos del cliente
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Indica el correo electrónico del cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Indica la contraseña del cliente
        /// </summary>
        public string Contrasena { get; set; }
    }
}
