using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaInmobiliaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos objeto/Instancia
            Inmueble Casa = new Inmueble();
            Casa.TipoInmueble1 = "Casa de Campo";
            Casa.Vender();
            Casa.Area1 = 120;
            Casa.Ubicacion1 = "Avenida los rios";

            Inmueble Departamento = new Inmueble("Departamento Duplex", 3200);
            Departamento.Alquilar();
            //Crearemos un objeto/ instancia
            Casa ObjetoCasa = new Casa("Casa de Campo", 350000);
            ObjetoCasa.Vender();

            Departamento ObjDepa = new Departamento("Departametno Triplex", 5260);

            Console.ReadKey();
        }
    }
}
