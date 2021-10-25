using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Examen_U2.Models
{
    public class Productos
    {
        [Required(ErrorMessage ="El campo Codigo Prodcuto no se debe de dejar vacio")]
        public int CodigoProducto { get; set; }

        [Required(ErrorMessage = "El campo Nombre Producto no se debe de dejar vacio")]
        public string NombreProducto { get; set; }

        [Required(ErrorMessage = "El campo Productos en Existencia  no se debe de dejar vacio")]
        public int ProductosEnExistencia { get; set; }

        public int Precio { get; set; }

       



      








    }
}
