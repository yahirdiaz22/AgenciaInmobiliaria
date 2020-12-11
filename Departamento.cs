using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaInmobiliaria
{
    class Departamento : Inmueble
    {
        //Atributos propios
        //metodos Propios

        public Departamento(string tipo, double precio)
        {
            TipoInmueble1 = tipo;
            Precio1 = precio;
            //Polimorfismo
            Casa Obj = new Casa("Casa de Campo");
            Casa Obj2 = new Casa("Cabaña");
            Casa Obj3 = new Casa("Mansion");
            Casa Obj4 = new Casa("Casa de Playa");
            Casa Obj5 = new Casa("Casa de Unifamiliar");
            Casa Obj6 = new Casa("Casa de Prefabricada");

            List<Inmueble> ListaCasas = new List<Inmueble>();
            ListaCasas.Add(Obj);
            ListaCasas.Add(Obj2);
            ListaCasas.Add(Obj3);
            ListaCasas.Add(Obj4);
            ListaCasas.Add(Obj5);
            ListaCasas.Add(Obj6);

            foreach(Inmueble item in ListaCasas)
            {
                item.Registrar();
            }
        }
    }
}