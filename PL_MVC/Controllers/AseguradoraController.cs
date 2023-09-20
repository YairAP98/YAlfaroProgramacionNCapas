using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        //Traer a todos los Usuarios 
        public ActionResult GetAll()
        {
            ML.Result result = BL.Aseguradora.GetAllEF();
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Aseguradoras = result.Objects;

            return View(aseguradora);
        }

        //Insertar infromacion del formulario para Agregar en la DB
        [HttpPost] // recibe informacion 
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
            //HttpPostedFileBase file = Request.Files["Imagen"];
            //if (file.ContentLength > 0)
            //{
            //    //aseguradora.Imagen = ConvertirABase64(file);
            //}
            if (aseguradora.IdAseguradora == 0) //ADD
            {
                ML.Result result = BL.Aseguradora.AddEF(aseguradora);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se ha completado el registro";
                }
                else
                {
                    ViewBag.Mensaje = "Error" + result.ErrorMessage;
                }
            }
            else //UPDATE
            {
                ML.Result result = BL.Aseguradora.AddEF(aseguradora);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se ha completado la actulización";
                }
                else
                {
                    ViewBag.Mensaje = "Error" + result.ErrorMessage;
                }
            }
            return PartialView("Modal");
        }

        //Muestra el fomulario VACIO
        [HttpGet] // manda la vista 
        public ActionResult Form(int? IdAseguradora)
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            ML.Usuario usuario = new ML.Usuario();
            
            ML.Result resultAseguradora = BL.Aseguradora.GetAllEF();
            ML.Result resultUsuario = BL.Usuario.GetAllEF(usuario);
          

            if (IdAseguradora != null  ) // actualizar 
            {

                ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora.Value);
              
                if (result.Correct)
                {
                    aseguradora = (ML.Aseguradora)result.Object;
                    

                }
            }
            else //add
            {
                aseguradora.Aseguradoras = resultAseguradora.Objects;
               
            }


            return View(aseguradora);//tarer la vista y mostrarla
        }

        [HttpGet] // manda la vista 
        //Eliminar Usuario 
        public ActionResult Delete(int IdAseguradora)
        {

            ML.Result result = BL.Aseguradora.DeleteEF(IdAseguradora);
            if (result.Correct)
            {

                ViewBag.Mensaje = "El usuarios se Elimino Satisfactoriamente";
            }

            else //add
            {
                ViewBag.Mensaje = "El usuario no se elimino" + result.ErrorMessage;
            }


            return View("Modal");//tarer la vista y mostrarla
        }

        //public IActionResult ObtenerHoraDelServidor()
        //{
        //    DateTime horaDelServidor = DateTime.Now;
        //    return (IActionResult)View(horaDelServidor);
        //}

        //public JsonResult ChangeStatus(int IdUsuario, bool Status)
        //{
        //    ML.Result result = BL.Usuario.ChangeStatus(IdUsuario, Status);
        //    return Json(null);
        //}
        ////convertir de Imagen a Base 64

    }
}