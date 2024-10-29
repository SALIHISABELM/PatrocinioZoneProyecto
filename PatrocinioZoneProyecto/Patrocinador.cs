using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrocinioZoneProyecto
{
    public class Patrocinador : Usuario
    {
        List<Club> sponsoreados = new List<Club>();

public Patrocinador(String id, String nombre ,double presupuesto ,String  Email ) : base(id)
        {
        Nombre = nombre;
        Presupuesto = presupuesto;
        Email = email;

        }
        public String Nombre { get; set; }
        public String Email { get; set; }
        //public String password { get; set; }
        public string Id { get; set; }
        public double presupuesto {  get; set; }



        //Posibles Metodos:
        //buscarClubes()
        //hacerOferta()
        //negociar()

    }
}
