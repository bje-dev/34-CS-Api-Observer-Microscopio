using API_Microscopio.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Microscopio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HabitanteController : ControllerBase
    {
        public static Random random = new Random();

        [HttpGet]
        [Route("habitante")]
        public IActionResult GetHabitante() {

            Habitante _habitante = default;

            var nombre = new string[] { "Colembolos", "Acaros", "Tardigrados", "Nematodos", "Rotiferos", "Amebas", "Ciliados", "Flagelados", "Microalgas", "Hongos", "Bacterias" };
            var color = new string[] { "Solido", "Traslucido" };
            var tamaño = random.Next(10, 100);
            var tipo = new string[] { "Fauna", "Flora" };

            _habitante = new Habitante();

            _habitante.Nombre = nombre[random.Next(nombre.Length)];
            _habitante.Color = color[random.Next(color.Length)];
            _habitante.Tamaño = tamaño;
            _habitante.Tipo = tipo[random.Next(tipo.Length)];

        return Ok(_habitante);
        
        }




    }
}
