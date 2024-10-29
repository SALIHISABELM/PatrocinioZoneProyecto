using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrocinioZoneProyecto
{
    public class Club : Usuario
    {
        List<ZonaPatrocinio> zonas = new List<ZonaPatrocinio>();
      
        public String Nombre { get; set; }
        public String Email { get; set; }
        //public String password { get; set; }
        public Deporte Deporte { get; set; }
        public Club(string id, string nombre, Deporte Deporte, string Email) : base(id)


        //Posible Metodo publicarOferta(double precio):void
        
    }
}
