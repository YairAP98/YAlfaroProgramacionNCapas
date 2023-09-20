using BL;
using ML;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class MostrarUsuariosController : Controller
    {
        //Traer a todos los Usuarios 
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Nombre = "";
            usuario.ApellidoPaterno = "";
            ML.Result result = BL.Usuario.GetAllEF(usuario);
            usuario.Usuarios = result.Objects;
            return View(usuario);
        }
        [HttpPost]
        public ActionResult GetAll(ML.Usuario usuario)
        {
            if (usuario.Nombre == null)
            {
                usuario.Nombre = "";
            }
            if (usuario.ApellidoPaterno == null)
            {
                usuario.ApellidoPaterno = "";
            }

            ML.Result result = BL.Usuario.GetAllEF(usuario);
            usuario = new ML.Usuario();
            usuario.Usuarios = result.Objects;
            return View(usuario);
        }

        //Insertar infromacion del formulario para Agregar en la DB
        [HttpPost] // recibe informacion 
        public ActionResult Form(ML.Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                HttpPostedFileBase file = Request.Files["Imagen"];
                if (file.ContentLength > 0)
                {
                    usuario.Imagen = ConvertirABase64(file);
                }
                if (usuario.IdUsuario == 0) //ADD
                {
                    ML.Result result = BL.Usuario.AddEF(usuario);
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
                    ML.Result result = BL.Usuario.AddEF(usuario);
                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Se ha completado la actulización";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error" + result.ErrorMessage;
                    }
                }

            }
            else
            {
                ML.Result resultRol = BL.Rol.GetAll();
                ML.Result resultPais = BL.Pais.GetAll();


                usuario.Rol.Roles = resultRol.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                usuario.Direccion.Colonia.Colonias = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.IdColonia).Objects;
                usuario.Direccion.Colonia.Municipio.Municipios = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio).Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Estados = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.Estado.IdEstado).Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais).Objects;
                return PartialView(usuario);
            }
            return PartialView(usuario);
        }

        //Muestra el fomulario VACIO
        [HttpGet] // manda la vista 
        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            ML.Result resultRol = BL.Rol.GetAll();
            ML.Result resultPais = BL.Pais.GetAll();
            // ML.Result resultAseguradoras = BL.Aseguradora.GetAllEF();

            if (IdUsuario != null) // actualizar 
            {

                ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value);
                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.Rol.Roles = resultRol.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Estados = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais).Objects;
                    usuario.Direccion.Colonia.Municipio.Municipios = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado).Objects;
                    usuario.Direccion.Colonia.Colonias = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio).Objects;
                    // usuario.Rol = new ML.Rol();


                }
            }
            else //add
            {


                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects; //pase mi lista de paises
                usuario.Rol.Roles = resultRol.Objects;
                //  usuario.Aseguradora.Aseguradoras = resultAseguradoras.Objects;
            }


            return View(usuario);//tarer la vista y mostrarla
        }

        [HttpGet] // manda la vista 
        //Eliminar Usuario 
        public ActionResult Delete(int IdUsuario)
        {

            ML.Result result = BL.Usuario.DeleteEF(IdUsuario);
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


        public JsonResult EstadoGetByIdPais(int IdPais)
        {
            ML.Result result = BL.Estado.GetByIdPais(IdPais);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
        public JsonResult MunicipioGetByIdEstado(int IdEstado)
        {
            ML.Result result = BL.Municipio.GetByIdEstado(IdEstado);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ColoniaGetByIdMunicipio(int IdMunicipio)
        {
            ML.Result result = BL.Colonia.GetByIdMunicipio(IdMunicipio);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ChangeStatus(int IdUsuario, bool Status)
        {
            ML.Result result = BL.Usuario.ChangeStatus(IdUsuario, Status);
            return Json(null);
        }
        //convertir de Imagen a Base 64
        public string ConvertirABase64(HttpPostedFileBase Foto)
        {
            //
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Foto.InputStream);
            byte[] data = reader.ReadBytes((int)Foto.ContentLength);
            string imagen = Convert.ToBase64String(data);
            return imagen;
        }
        [HttpGet]
        //manda vista
        public ActionResult Login()
        {

            return View();


        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {


            ML.Result result = BL.Usuario.GetByEmail(email);
            if (result.Correct)
            {
                var data = (ML.Usuario)result.Object;
                if (password == data.Password)
                {
                    //validacion de la contrasena
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ViewBag.Login = true;
                    ViewBag.Password = "La contrasena es incorrecta";
                    return PartialView("modal");
                }
            }
            else
            {
                ViewBag.Login = true;
                ViewBag.Mensaje = "El email es incorrecto";
                return PartialView("modal");

            }

        }

    }
}


