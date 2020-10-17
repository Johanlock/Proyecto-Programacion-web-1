using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_RRHH_Servicios_.Services;

namespace Proyecto_RRHH.Controllers
{
    public class EmpleadosController : Controller
    {
        Servicios_Empleados sv = new Servicios_Empleados();

        public IActionResult Index()
        {
            var Model = sv.ConsultaGeneral();
            return View(Model);
        }
        public IActionResult Details(int id)
        {
            var Model = sv.ConsultaPorCodigo(id);
            return View(Model);
        }
    }
}
