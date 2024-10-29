using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrocinioZoneProyecto
{
    public abstract class Usuario
    {
        
public string Id { get; set; }
        
        public Usuario(string id)
        {
            Id = id;
        }
        

        //Posibles Métodos abstractos
        //login();
        //logout();
        //actualizarPerfil();
        //mostrarInformacion();
        //getters();
    }
}
