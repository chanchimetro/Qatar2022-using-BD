using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP6_Ayala_LopezAbraham.Models;

namespace TP6_Ayala_LopezAbraham.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        @ViewBag.ListaEquipos = BD.ListarEquipos();
        return View();
    }
    public IActionResult VerDetalleEquipo(int IdEquipo)
    {
        @ViewBag.Equipo=BD.VerInfoEquipo(IdEquipo);
        @ViewBag.ListaJugadores=BD.ListarJugadores(IdEquipo);
        return View();
    }
    public IActionResult VerDetalleJugador(int IdJugador)
    {
        @ViewBag.DetalleJugador=BD.VerInfoJugador(IdJugador);
        return View();
    }
    public IActionResult AgregarJugador(int IdEquipo)
    {
        @ViewBag.IdEquipo=IdEquipo;
        return View();
    }

    [HttpPost] 
    public IActionResult GuardarJugador(Jugador Jug, IFormFile Retrato)
    {
        int resultado = BD.AgregarJugador(Jug);
        return View("DetalleEquipo(Jug.IdEquipo)");
    }

    public IActionResult EliminarJugador(Jugador Jug)
    {
        int resultado = BD.EliminarJugador(Jug.IdJugador);
        return View("DetalleEquipo(Jug.IdEquipo)");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
