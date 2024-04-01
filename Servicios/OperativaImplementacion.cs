using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Ficheros.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void insertarTexto()
        {
            string ruta = "C:\\Users\\csi23-iloposa\\Desktop\\Archivo.txt";
           

            Console.WriteLine("Indique el numero de linea ");
            int numeroLinea=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la posicion ");
            int numeroPosicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique el texto a insertar");
            string texto=Console.ReadLine();
            //Guardar todo el fichero en un array 
            string[] lineas = File.ReadAllLines(ruta);
            //Seleccionar una linea especifica
            string linea = lineas[numeroLinea-1];
            //Insertar texto en una posicion especifica
            string  nuevoTexto = linea.Insert(numeroPosicion, texto);
            //Insertar el nuevo texto al array 
            lineas[numeroLinea - 1] = nuevoTexto;
            //Sobreescribir el fichero
            File.WriteAllLines(ruta, lineas);



            /*         string ficheroFinal="";

                        for ( int i = 0; i < lineas.Length; i++)
                        {
                            ficheroFinal = ficheroFinal  + lineas[i]+"\n";
                        }
                        Console.WriteLine(ficheroFinal);*/



        }

        public void modificarLinea()
        {
            string ruta = "C:\\Users\\csi23-iloposa\\Desktop\\Archivo.txt";

            Console.WriteLine("Indique el numero de linea ");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique el texto");
            string texto = Console.ReadLine();

            string[] lineas = File.ReadAllLines(ruta);

            lineas[numeroLinea-1]=texto;

            File.WriteAllLines (ruta, lineas);


        }
    }
}
