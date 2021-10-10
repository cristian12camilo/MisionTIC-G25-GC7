using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones; // creamos la lista de estaciones
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>() // se esta generando una constructor, inicializando la lista // debe conicir con las creadas en las entidades
            {
                new Estaciones{id=1,nombre="Norte",direccion= "CalleNorte",coord_x= 10,coord_y= 4,Tipo= "Norte"},
                new Estaciones{id=2,nombre="Sur",direccion= "CalleSur",coord_x= 90,coord_y= 16,Tipo= "Sur"},
                new Estaciones{id=3,nombre="Occidente",direccion= "CalleOcc",coord_x= 15,coord_y= 24,Tipo= "Occidente"}
 
            };
        }                     
                  
         
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;  // realizamos un metodo llamado toda la lista.
        }
 
        public Estaciones GetEstacionesWithId(int id){    
            return estaciones.SingleOrDefault(b => b.id == id);
        }


        public Estaciones Update(Estaciones newEstacion){  // metodo para actualizar. 
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstacion.id);
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.coord_x = newEstacion.coord_x;
                estacion.coord_y = newEstacion.coord_y;
                estacion.Tipo= newEstacion.Tipo;
            }
        return estacion;
        }




    }
}