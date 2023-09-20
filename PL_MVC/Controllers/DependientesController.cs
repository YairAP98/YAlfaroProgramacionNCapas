﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class DependientesController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Result resultEmpleados = BL.Empleado.GetAll();
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empleados = new List<object>();
            if (resultEmpleados.Correct)
            {
                empleado.Empleados = resultEmpleados.Objects;
            }
            else
            {
                ViewBag.Message = resultEmpleados.ErrorMessage;
            }

            return View(empleado);
        }

        public ActionResult GetDependiente(string NumeroEmpleado)
        {
            ML.Result result = BL.Dependiente.GetByNumeroempleado(NumeroEmpleado);
            ML.Dependiente dependiente = new ML.Dependiente();
            dependiente.Dependientes = result.Objects;
            return View(dependiente);
        }
    }
}