using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios; // se esta realizando una importación 
using ProyectoCiclo3.App.Dominio; // se esta realizando una importación 

// las importaciones se utilizar para poder utilizar los objetos. 
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListBusModel : PageModel
    {
       
        private readonly RepositorioBuses repositorioBuses;

        [BindProperty] //Adicionamos la siguiente línea para crear el botón Eliminar
        public Buses Bus {get;set;}

        public IEnumerable<Buses> Buses {get;set;}
 
        public ListBusModel(RepositorioBuses repositorioBuses)
        {
            this.repositorioBuses=repositorioBuses;
        }
    
        public void OnGet()
        {
            Buses=repositorioBuses.GetAll();
        }

    // A continuación creamos un metodo que se llama Onpost ya que se creo un formulario Post para el boton eliminar
        public IActionResult OnPost()
        {
            if(Bus.id>0)
            {
            Bus = repositorioBuses.Delete(Bus.id);
            }
            return RedirectToPage("./List");
        }



    }
}

