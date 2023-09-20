using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public  class Empleado
    {

        public static ML.Result GetAll()
        {
            {
                ML.Result result = new ML.Result();

                try
                {
                    //Todo lo que se ejecute dnetro de using se libera al final, los recursos
                    using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                    {

                        var tablaUsuarios = context.GetAllEmpleado().ToList();
                        result.Objects = new List<object>();
                        ML.Usuario usuarioObj = new ML.Usuario();

                        if (tablaUsuarios != null)
                        {

                            foreach (var obj in tablaUsuarios)
                            {
                                ML.Empleado empleadoObject = new ML.Empleado();
                                empleadoObject.NumeroEmpleado = obj.Numeroempleado;
                                empleadoObject.RFC = obj.RFC;
                                empleadoObject.Nombre = obj.Nombre;
                                empleadoObject.ApellidoPaterno = obj.ApellidoPaterno;
                                empleadoObject.ApellidoMaterno = obj.ApellidoMaterno;
                                empleadoObject.Email = obj.Email;
                                empleadoObject.Telefono = obj.Telefono;
                                empleadoObject.FechaIngreso = obj.FechaIngreso.Value;
                                empleadoObject.NSS = obj.NSS;
                                empleadoObject.FechaIngreso = obj.FechaIngreso.Value;
                                empleadoObject.Foto = obj.Foto.ToString();
                                                             
                                result.Objects.Add(empleadoObject);


                            }

                            result.Correct = true;

                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "La tabla de Empleados no contiene registros";
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

        public static ML.Result GetById(string numeroEmpleado)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var registro = context.GetEmpleadoById(numeroEmpleado).FirstOrDefault();
                    if (registro != null)
                    {

                        ML.Empleado empleado = new ML.Empleado();
                        empleado.NumeroEmpleado = registro.Numeroempleado;
                        empleado.RFC = registro.RFC;
                        empleado.Nombre = registro.Nombre;
                        empleado.ApellidoPaterno = registro.ApellidoPaterno;
                        empleado.ApellidoMaterno = registro.ApellidoMaterno;
                        empleado.Email = registro.Email;
                        empleado.Telefono = registro.Telefono;
                        empleado.Fechanacimiento = registro.FechaNacimiento.Value;
                        empleado.NSS = registro.NSS;    
                        empleado.FechaIngreso = registro.FechaIngreso.Value;    
                        empleado.Foto = registro.Foto.ToString();                    
                        result.Object = empleado;

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

        public static ML.Result Delete(string numeroEmpleado)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {




                    int filasAfectadas = context.DeleteEmpleado(numeroEmpleado);
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

        public static ML.Result Update(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();
            ML.Empresa empresa = new ML.Empresa();
            try
            {

                ObjectParameter filasAfec = new ObjectParameter("FilasAfectadas", typeof(int));
                ObjectParameter mensaje = new ObjectParameter("Mensaje", typeof(string));
                //todo lo que ejecute dentro de un using se libera al final
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    int filasAfectadas = context.UpdateEmpleado(
                        empleado.NumeroEmpleado,
                        empleado.RFC,
                        empleado.Nombre,
                        empleado.ApellidoPaterno,
                        empleado.ApellidoMaterno,
                        empleado.Email,
                        empleado.Telefono,
                        empleado.Fechanacimiento,
                        empleado.NSS,
                        empleado.FechaIngreso,
                        empleado.Foto,
                        empresa.IdEmpresa
                        
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
