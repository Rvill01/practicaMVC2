using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using practicaMVC2.Models;

namespace practicaMVC2.Controllers
{
    public class EquiposController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;
        public EquiposController(equiposDbContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }

        public IActionResult Index()
        {
            var listaDeEquipos = (from mi in _equiposDbContext.tipo_equipo select mi).ToList();
            ViewData["listadoDeEquipos"] = new SelectList(listaDeEquipos, "id_tipo_equipo", "descripcion");

            var listaDeMarcas = (from m in _equiposDbContext.marcas
                                 select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(listaDeMarcas, "id_marcas", "nombre_marca");

            var estadoEquipo = (from m in _equiposDbContext.estados_equipo
                                 select m).ToList();
            ViewData["listEquipado"] = new SelectList(estadoEquipo, "id_estados_equipo", "estado");

            var listadoEquipos = (from e in _equiposDbContext.equipos
                                 join m in _equiposDbContext.marcas
                                 on e.marca_id equals m.id_marcas
                                 select new
                                 {
                                     nombre = e.nombre,
                                     descripcion = e.descripcion,
                                     marca_id = e.marca_id,
                                     marca_nombre = m.nombre_marca,
                                 }).ToList();
            ViewData["listadoEquipo"] = listadoEquipos;
            return View();
        }
        public IActionResult CrearEquipos(equipos nuevoEquipo) 
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
