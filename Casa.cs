using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaInmobiliaria
{
    //Herencia
    class Casa : Inmueble
    {
        //Atributos propios
        //metodos Propios

        public Casa(string tipo, double precio)
        {
            TipoInmueble1 = tipo;
            Precio1 = precio;
        }
        public Casa(string tipo){
                TipoInmueble1 = tipo;

            }
        }
    } 