using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_U2.Models
{
    public class Datos
    {

        private static List<Productos> objetos = new List<Productos>();

        public static IEnumerable<Productos> Objetos => objetos;

        public static void AgregarProducto(Productos objeto)
        {
            objetos.Add(objeto);
        }
        
        public static void EliminarProducto(Productos objeto)
        {
            objetos.Remove(objeto);
        }
    }
}
