using ejercicio5Ficheros.Servicios;

namespace ejercicio5Ficheros.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();

            bool cerrarMenu=false;
            int opcion;

            while(!cerrarMenu)
            {
                opcion = mi.mostrarMenu();
                switch (opcion)
                {
                    case 0: 
                       cerrarMenu = true;
                        break;
                        case 1:
                        op.modificarLinea();
                        break;
                    case 2:
                        op.insertarTexto();
                        break;
                }
            }



        }
    }
}
