using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrocinioZoneProyecto
{
    public class ZonaPatrocinio
    {
        public double Tamanio { get; set; }
        public bool EstadoReservado { get; set; }

        public Ubicacion Ubicacion { get; set; }

        //Posibles Metodos:
        //actualizarPrecio()
        //reservar()

    }
}
