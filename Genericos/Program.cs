using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {          
            MuestraNombre<Perro>(new Perro("panfilo"), new Perro("galleta"));
            Console.ReadKey();
        }


        public static void MuestraNombre<Tipo>(params Tipo[] Objeto) where Tipo : ElementoConNombre
        {
            foreach (var o in Objeto)
                Console.WriteLine("la mascota se ll " + o.RetornaNombre());
            //Console.WriteLine("la mascota se llama " + Objeto[0].RetornaNombre() + "/n");
            //Console.WriteLine("el mueble se llama " + Objeto[1].RetornaNombre() + "/n");
        }
    }
    public interface ElementoConNombre
    {
        string RetornaNombre();
    }

    public class Mueble : ElementoConNombre
    {

        public string RetornaNombre()
        {
            return "Nombre del mueble";
        }
    }

    public class Perro : ElementoConNombre
    {
        string Nombre;
        public Perro(string _nombre)
        {
            Nombre = _nombre;
        }
        public string RetornaNombre()
        {
            return Nombre;
        }
    }

    public class Gato : ElementoConNombre
    {
        string Nombre;
        public Gato(string _nombre)
        {
            Nombre = _nombre;
        }
        public string RetornaNombre()
        {
            return Nombre;
        }
    }
}
