using Microsoft.AspNetCore.Mvc;

namespace TP05SalaDeEscape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult Creditos()
    {
        return View("Creditos");
    }
     public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
    public IActionResult Comenzar()
    {
        int estadoJuego = Escape.getEstadoJuego();
        if (estadoJuego == 1)
        {
            return View ("Habitacion1");
        }
        
        return View();
    }

    
    public IActionResult Habitacion(int Sala, string Clave)
    {
        if (Escape.getEstadoJuego() != Sala)
        {
            return View("Habitacion"+Escape.getEstadoJuego());
        }
        if (Escape.resolverSala(Sala, Clave))
        {
            if (Sala == 5)
            {
                return View("Victoria");
            }
            else
            {
                return View("Habitacion" + Escape.getEstadoJuego());
            }
        }
        else{
            ViewBag.Error = "La clave es incorrecta. Vuelva a intentarlo";
            return View("Habitacion" + Escape.getEstadoJuego());
        }
    }
}
