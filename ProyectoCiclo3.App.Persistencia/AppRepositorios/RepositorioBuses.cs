using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> buses; // creamos la lista de buses
 
    public RepositorioBuses()
        {
            buses= new List<Buses>() // se esta generando una constructor, inicializando la lista // debe conicir con las creadas en las entidades
            {
                new Buses{id=1,marca="Audi",modelo= 2020,kilometraje= 100000,numero_asientos= 4,placa= "POP678"},
                new Buses{id=2,marca="Toyota",modelo= 2021,kilometraje= 90000,numero_asientos= 16,placa= "OIU859"},
                new Buses{id=3,marca="Mazda",modelo= 2000,kilometraje= 150000,numero_asientos= 24,placa= "YUH859"}
 
            };
        }
 
        public IEnumerable<Buses> GetAll()
        {
            return buses;  // realizamos un metodo llamado toda la lista.
        }
 
        public Buses GetBusWithId(int id){
            return buses.SingleOrDefault(b => b.id == id);
        }


        public Buses Update(Buses newBus){  // metodo para actualizar. 
            var bus= buses.SingleOrDefault(b => b.id == newBus.id);
            if(bus != null){
                bus.marca = newBus.marca;
                bus.modelo = newBus.modelo;
                bus.kilometraje = newBus.kilometraje;
                bus.numero_asientos = newBus.numero_asientos;
                bus.placa= newBus.placa;
            }
        return bus;
        }

        //Creamos el metodo de eliminar

        public Buses Delete(int id)
        {
        var bus= buses.SingleOrDefault(b => b.id == id);
        buses.Remove(bus);
        return bus;
        }





    }
}
