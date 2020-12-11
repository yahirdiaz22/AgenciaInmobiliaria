using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaInmobiliaria
{
    class  Inmueble
    {//Atributo
      public string TipoInmueble;

      public string Ubicacion;

      public double Precio;

      public int Area;

       public string Dormitorio;
        //Propiedades set y get / modoficadores de acceso
        public string TipoInmueble1 { get => TipoInmueble; set => TipoInmueble = value; }
        public string Ubicacion1 { get => Ubicacion; set => Ubicacion = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
        public int Area1 { get => Area; set => Area = value; }
        public string Dormitorio1 { get => Dormitorio; set => Dormitorio = value; }

        //Metodos
        public void Registrar()
        {
            Console.WriteLine(TipoInmueble +" registrada correctamente");
        }
        public void Vender()
        {

            Console.WriteLine(TipoInmueble1 + " ha sido vendida por el precio de: " + Precio + " $ ");
        }
        public void Alquilar()
        {
            Console.WriteLine(TipoInmueble1 + " ha sido alquilada por el precio de: " + Precio + " $ ");
        }
        public void VerDatos() {
            Console.WriteLine(TipoInmueble+"/n");
        }

        //constructor de parametros
        public Inmueble(string tipo, double precio) { 
        
            TipoInmueble1 = tipo;
            Precio1 = precio;
        }
        //constructor por defecto- Vacio
        public Inmueble()
        { 
        }
    }
}