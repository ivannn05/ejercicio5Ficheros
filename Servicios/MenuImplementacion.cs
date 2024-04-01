using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Ficheros.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opc;

            Console.WriteLine("Selecciones una opcion:");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Modificar una línea específica");
            Console.WriteLine("2.Insertar texto en una posición específica de una línea");
              opc=Convert.ToInt32(Console.ReadLine());

            return opc;
        }
    }
}
