using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Dependiente
    {

        public static ML.Result GetAll(string numeroEmpleado)
        {
            {
                ML.Result result = new ML.Result();

                try
                {
                    //Todo lo que se ejecute dnetro de using se libera al final, los recursos
                    using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                    {

                        var tablaUsuarios = context.GetAllDependiente().ToList();
                        result.Objects = new List<object>();
                        ML.Usuario usuarioObj = new ML.Usuario();

                        if (tablaUsuarios != null)
                        {

                            foreach (var obj in tablaUsuarios)
                            {
                                ML.Dependiente dependienteObject = new ML.Dependiente();
                                dependienteObject.idDependiente = obj.IdDependiente;
                                dependienteObject.Nombre = obj.Nombre;
                                dependienteObject.ApellidoPaterno = obj.ApellidoPaterno;
                                dependienteObject.ApellidoMaterno = obj.ApellidoMaterno;
                                dependienteObject.FechaNacimiento = obj.FechaNacimiento.Value;
                                dependienteObject.EstadoCivil = obj.EstadoCivil;
                                dependienteObject.Genero = obj.Genero;
                                dependienteObject.Telefono = obj.Telefono;
                                dependienteObject.RFC = obj.RFC;
                                result.Objects.Add(dependienteObject);


                            }

                            result.Correct = true;

                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "La tabla dependientes no contiene registros";
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
        }

        public static ML.Result GetByNumeroempleado(string numeroEmpleado)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var registro = context.GetByIdDependiente(numeroEmpleado).FirstOrDefault();
                    if (registro != null)
                    {

                        ML.Dependiente dependiente = new ML.Dependiente();
                        dependiente.idDependiente = registro.IdDependiente;
                        dependiente.Nombre = registro.Nombre;
                        dependiente.ApellidoPaterno = registro.ApellidoPaterno;
                        dependiente.ApellidoMaterno = registro.ApellidoMaterno;
                        dependiente.FechaNacimiento = registro.FechaNacimiento.Value;
                        dependiente.EstadoCivil = registro.EstadoCivil;
                        dependiente.Genero = registro.Genero;
                        dependiente.Telefono = registro.Telefono;   
                        dependiente.RFC = registro.RFC;
                    
                        result.Object = dependiente;

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

        public static ML.Result Delete(int idDependiente)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {




                    int filasAfectadas = context.DeleteDependienteById(idDependiente);
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

        public static ML.Result Update(ML.Dependiente dependiente)
        {
            ML.Result result = new ML.Result();
            try
            {
                ObjectParameter filasAfec = new ObjectParameter("FilasAfectadas", typeof(int));
                ObjectParameter mensaje = new ObjectParameter("Mensaje", typeof(string));
                //todo lo que ejecute dentro de un using se libera al final
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    int filasAfectadas = context.UpdateDependiente(
                        dependiente.idDependiente,
                        dependiente.Nombre,
                        dependiente.ApellidoPaterno,
                        dependiente.ApellidoMaterno,
                        dependiente.FechaNacimiento,
                        dependiente.EstadoCivil,
                        dependiente.Genero,
                        dependiente.Telefono,
                        dependiente.RFC
                

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
    }
}