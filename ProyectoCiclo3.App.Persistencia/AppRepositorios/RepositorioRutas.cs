using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas; // creamos la lista de rutas
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>() // se esta generando una constructor, inicializando la lista // debe conicir con las creadas en las entidades
            {
                new Rutas{id=1,origen=10,destino= 20,tiempo_estimado= 4},
                new Rutas{id=2,origen=20,destino= 40,tiempo_estimado= 16},
                new Rutas{id=3,origen=30,destino= 60,tiempo_estimado= 24}
 
            };
        }     
        

        public IEnumerable<Rutas> GetAll()
        {
            return rutas;  // realizamos un metodo llamado toda la lista.
        }
 
        public Rutas GetBusWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }


        public Rutas Update(Rutas newRuta){  // metodo para actualizar. 
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
                
            }
        return ruta;
        }




    }
}