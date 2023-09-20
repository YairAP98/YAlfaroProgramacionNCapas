using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aseguradora
    {
        public static ML.Result AddEF(ML.Aseguradora aseguradora)
        {
            //
            ML.Result result = new ML.Result();
            try
            {
                //contexto de
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    ObjectParameter filasAfe = new ObjectParameter("FilasAfectadas", typeof(int));
                    ObjectParameter mensaje = new ObjectParameter("Mensaje", typeof(string));
                    //int filasAfectadas = context.usu;  //context.us
                    int filasAfectadas = context.AseguradoraAdd(
                        aseguradora.Nombre,
                        aseguradora.FechaCreacion,
                        aseguradora.FechaModificacion,
                       aseguradora.IdAseguradora);

                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }


            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result UpdateEP(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            ML.Usuario usuario = new ML.Usuario();
            try
            {
                ObjectParameter filasAfec = new ObjectParameter("FilasAfectadas", typeof(int));
                ObjectParameter mensaje = new ObjectParameter("Mensaje", typeof(string));
                //todo lo que ejecute dentro de un using se libera al final
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    int filasAfectadas = context.AseguradoraAdd(
                       aseguradora.Nombre,
                       aseguradora.FechaCreacion,
                       aseguradora.FechaModificacion,
                       usuario.IdUsuario

                        );
                    ;

                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Error al Actualizar al usuario";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result DeleteEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {




                    int filasAfectadas = context.UsuarioDelete(IdUsuario);
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }


            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }
        public static ML.Result GetAllEF()/// revisar este metodo 
        {
            ML.Result result = new ML.Result();

            try
            {
                //Todo lo que se ejecute dnetro de using se libera al final, los recursos
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {

                    var tablaAseguradora = context.AseguradorasGetAll().ToList();
                    result.Objects = new List<object>();


                    if (tablaAseguradora != null)
                    {

                        foreach (var obj in tablaAseguradora)
                        {
                            // ML.Usuario usuario = new ML.Usuario();
                            ML.Aseguradora aseguradora = new ML.Aseguradora();

                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion;
                            aseguradora.FechaModificacion = obj.FechaModificacion.Value;
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;

                            result.Objects.Add(aseguradora);


                        }

                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "La tabla usuario no contiene registros";
                    }

                }


            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }
        public static ML.Result GetByIdEF(int IdAseguradora)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var registro = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();
                    if (registro != null)
                    {


                        ML.Aseguradora aseguradora = new ML.Aseguradora();



                        aseguradora.IdAseguradora = registro.IdAseguradora;
                        aseguradora.Nombre = registro.Nombre;
                        aseguradora.FechaCreacion = registro.FechaCreacion;
                        aseguradora.FechaModificacion = registro.FechaModificacion.Value;
                        aseguradora.Usuario.IdUsuario = registro.IdUsuario;
                        result.Object = aseguradora;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        //public static ML.Result ChangeStatus(int IdUsuario, bool Status)
        //{

        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
        //        {
        //            var rowsAffetted = context.UsuarioChangeStatus(IdUsuario, Status);

        //            if (rowsAffetted > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

    }
}
