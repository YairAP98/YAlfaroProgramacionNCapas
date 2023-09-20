using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using ML;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Data.Entity.Core.Objects;
using DL_EF;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics.Contracts;
using System.Data.OleDb;
namespace BL
{
    public class Usuario
    {
        //Agregar
        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    //
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //todo lo que ejecute dentro de un using se libera al final
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            //query que
        //            string query = "INSERT INTO Usuario VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Direccion)";

        //            SqlCommand cmd = new SqlCommand(query, context);

        //            SqlParameter[] collection = new SqlParameter[5];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
        //            collection[3].Value = usuario.FechaNacimiento;
        //            collection[4] = new SqlParameter("@Direccion", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Direccion;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();
        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = true;
        //                result.ErrorMessage = "Error al agregar al usuario";

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}        

        ////Agregar con SP
        //public static ML.Result AddSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //todo lo que ejecute dentro de un using se libera al final
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {


        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = "UsuarioAdd";
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlParameter[] collection = new SqlParameter[6];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
        //            collection[3].Value = usuario.FechaNacimiento;
        //            collection[4] = new SqlParameter("@Direccion", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Direccion;
        //            collection[5] = new SqlParameter("@IdRol", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Direccion;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();
        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = true;
        //                result.ErrorMessage = "Error al agregar al usuario";

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}
        ////Actualizar
        //public static ML.Result Update(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //todo lo que ejecute dentro de un using se libera al final
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UPDATE USUARIO SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, FechaNacimiento = @FechaNacimiento WHERE IdUsuario = @IdUsuario";


        //            SqlCommand cmd = new SqlCommand(query, context);

        //            SqlParameter[] collection = new SqlParameter[6];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[1].Value = usuario.Nombre;
        //            collection[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoPaterno;
        //            collection[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[3].Value = usuario.ApellidoMaterno;
        //            collection[4] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
        //            collection[4].Value = usuario.FechaNacimiento;
        //            collection[5] = new SqlParameter("@Direccion", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Direccion;


        //            cmd.Parameters.AddRange(collection);

        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = true;
        //                result.ErrorMessage = "Error al Actualizar al usuario";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}  

        ////Actualiar con SP
        //public static ML.Result UpdateSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //todo lo que ejecute dentro de un using se libera al final
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {


        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = "UsuarioUdate";
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter[] collection = new SqlParameter[6];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[1].Value = usuario.Nombre;
        //            collection[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoPaterno;
        //            collection[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[3].Value = usuario.ApellidoMaterno;
        //            collection[4] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
        //            collection[4].Value = usuario.FechaNacimiento;
        //            collection[5] = new SqlParameter("@Direccion", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Direccion;
        //            collection[6] = new SqlParameter("@IdRol", SqlDbType.Int);
        //            collection[6].Value = usuario.Direccion;

        //            cmd.Parameters.AddRange(collection);

        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = true;
        //                result.ErrorMessage = "Error al agregar al usuario";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}
        ////Eliminar
        //public static ML.Result Delete(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {



        //            string query = "DELETE FROM USUARIO WHERE IdUsuario = @IdUsuario";
        //            SqlCommand cmd = new SqlCommand(query,context);
        //            cmd.CommandText = "Usuario";
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            //Se crearan parametros de SQL
        //            //Con esto se insertaran los valores
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;


        //            //Lo siguiente es pasarle el parametro
        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
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
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}

        ////Eliminar con SP
        //public static ML.Result DeleteSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {


        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = "UsuarioUpdate";
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            //Se crearan parametros de SQL
        //            //Con esto se insertaran los valores
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;


        //            //Lo siguiente es pasarle el parametro
        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();
        //            if (filasAfectadas > 0)
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
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}
        //// Obtener todos los registros
        //public static ML.Result GetAll()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT IdUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,FechaNacimiento FROM Usuario";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);




        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in tablaUsuario.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.FechaNacimiento = DateTime.Parse(row[6].ToString());
        //                    result.Objects.Add(usuario);
        //                }

        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "La tabla usuario no contiene registros";
        //            }

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}

        //// Obtener todos los registros SP
        //public static ML.Result GetAllSP()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {

        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = "UsuarioGetAll";
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);




        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in tablaUsuario.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());
        //                     usuario.Direccion = row[4].ToString();

        //                    // propiedad de navegacion 
        //                    usuario.Rol = new ML.Rol();
        //                    usuario.Rol.Nombre = row[6].ToString();
        //                    usuario.Nombre = row[1].ToString();
        //                    result.Objects.Add(usuario);
        //                }

        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "La tabla usuario no contiene registros";
        //            }

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}

        ////Obtener Solo 1 Registro 
        //public static ML.Result GetById(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT IdUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,FechaNacimiento, Direccion FROM Usuario WHERE IdUsuario = @IdUsuario";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            cmd.Parameters.AddRange(collection);


        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);

        //            //Lo siguiente es pasarle el parametro

        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                DataRow row = tablaUsuario.Rows[0];


        //                usuario.IdUsuario = int.Parse(row[0].ToString());
        //                usuario.Nombre = row[1].ToString();
        //                usuario.ApellidoPaterno = row[2].ToString();
        //                usuario.ApellidoMaterno = row[3].ToString();
        //                usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());
        //                usuario.Direccion = row[5].ToString();
        //                // propiedad de navegacion 
        //                usuario.Rol = new ML.Rol();
        //                usuario.Rol.Nombre = row[6].ToString();
        //                usuario.Nombre = row[1].ToString();


        //                result.Object = usuario;
        //                result.Correct = true;



        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No existe el registro";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}
        ////Obtener Solo 1 Registro SP
        //public static ML.Result GetByIdSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        //Todo lo que se eje cute dnetro de using se libera al final, los recursos
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT IdUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,EstaturaEnCentimetros,Genero,FechaDeNacimiento FROM USUARIO WHERE IdUsuario = @IdUsuario";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            cmd.Parameters.AddRange(collection);


        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);

        //            //Lo siguiente es pasarle el parametro

        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                DataRow row = tablaUsuario.Rows[0];


        //                usuario.IdUsuario = int.Parse(row[0].ToString());
        //                usuario.Nombre = row[1].ToString();
        //                usuario.ApellidoPaterno = row[2].ToString();
        //                usuario.ApellidoMaterno = row[3].ToString();
        //                 usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());
        //                 usuario.Direccion = row[5].ToString();
        //                // propiedad de navegacion 
        //                usuario.Rol = new ML.Rol();
        //                usuario.Rol.Nombre = row[6].ToString();
        //                usuario.Nombre = row[7].ToString();
        //                result.Objects.Add(usuario);
        //                result.Object = usuario;
        //                result.Correct = true;



        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No existe el registro";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}
        /////EntityFramework ADD
        /////
        public static ML.Result AddEF(ML.Usuario usuario)
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
                    int filasAfectadas = context.UsuarioAdd(
                        usuario.UserName,
                        usuario.Nombre,
                        usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno,
                        usuario.Email,
                        usuario.Password,
                        usuario.Sexo,
                        usuario.Telefono,
                        usuario.Celular,
                        usuario.FechaNacimiento,
                        usuario.CURP,
                        usuario.Rol.IdRol,
                        usuario.Imagen,
                        usuario.Direccion.Calle,
                        usuario.Direccion.NumeroInterior,
                        usuario.Direccion.NumeroExterior,
                        usuario.Direccion.Colonia.IdColonia,
                        filasAfe);

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
        public static ML.Result UpdateEP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                ObjectParameter filasAfec = new ObjectParameter("FilasAfectadas", typeof(int));
                ObjectParameter mensaje = new ObjectParameter("Mensaje", typeof(string));
                //todo lo que ejecute dentro de un using se libera al final
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    int filasAfectadas = context.UsuarioUpdate(
                        usuario.UserName,
                        usuario.Nombre,
                        usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno,
                        usuario.Email,
                        usuario.Password,
                        usuario.Sexo,
                        usuario.Telefono,
                        usuario.Celular,
                        usuario.FechaNacimiento,
                        usuario.CURP,
                        usuario.Rol.IdRol,
                        usuario.Imagen,
                        usuario.Direccion.Calle,
                        usuario.Direccion.NumeroInterior,
                        usuario.Direccion.NumeroExterior,
                        usuario.Direccion.Colonia.IdColonia,
                        usuario.IdUsuario,filasAfec
                   
                        
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
        public static ML.Result GetAllEF( ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                //Todo lo que se ejecute dnetro de using se libera al final, los recursos
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {

                    var tablaUsuarios = context.UsuarioGetAll(usuario.Nombre, usuario.ApellidoPaterno).ToList();
                    result.Objects = new List<object>();
                    ML.Usuario usuarioObj = new ML.Usuario();

                    if (tablaUsuarios != null)
                    {

                        foreach (var obj in tablaUsuarios)
                        {
                            ML.Usuario usuarioObject = new ML.Usuario();
                            usuarioObject.IdUsuario = obj.IdUsuario;
                            usuarioObject.Nombre = obj.NombreUsuario;
                            usuarioObject.ApellidoPaterno = obj.ApellidoPaterno;
                            usuarioObject.ApellidoMaterno = obj.ApellidoMaterno;
                            usuarioObject.Email = obj.Email;
                            usuarioObject.Password = obj.password;
                            usuarioObject.Sexo = obj.Sexo;
                            usuarioObject.Telefono = obj.Telefono;
                            usuarioObject.Celular = obj.Celular;
                            usuarioObject.FechaNacimiento = obj.FechaNacimiento;
                            usuarioObject.CURP = obj.CURP;
                            usuarioObject.Rol = new ML.Rol();
                            usuarioObject.Rol.IdRol = obj.IdRol.Value;
                            usuarioObject.Status = obj.Status;
                            usuarioObject.Rol.NombreRol = obj.NombreRol;
                            usuarioObject.Imagen = obj.Imagen;
                            usuarioObject.Direccion = new ML.Direccion();
                            usuarioObject.Direccion.Colonia = new ML.Colonia();
                            usuarioObject.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuarioObject.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuarioObject.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuarioObject.Direccion.Calle = obj.Calle;
                            usuarioObject.Direccion.NumeroInterior = obj.NumeroInterior;
                            usuarioObject.Direccion.NumeroExterior = obj.NumeroExterior;
                            usuarioObject.Direccion.Colonia.IdColonia = obj.IdColonia;
                            usuarioObject.Direccion.Colonia.Nombre = obj.NombreColonia;
                            usuarioObject.Direccion.Colonia.Municipio.IdMunicipio = obj.IdMunicipio;
                            usuarioObject.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;
                            usuarioObject.Direccion.Colonia.Municipio.Estado.IdEstado = obj.IdEstado;
                            usuarioObject.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;
                            usuarioObject.Direccion.Colonia.Municipio.Estado.Pais.IdPais = obj.IdPais;
                            usuarioObject.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.NombrePais;


                            result.Objects.Add(usuarioObject);


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
        public static ML.Result GetByIdEF(int IdUsuario)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var registro = context.UsuarioGetById(IdUsuario).FirstOrDefault();
                    if (registro != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = registro.IdUsuario;
                        usuario.UserName = registro.UserName;
                        usuario.Nombre = registro.NombreUsuario;
                        usuario.ApellidoPaterno = registro.ApellidoMaterno;
                        usuario.ApellidoPaterno = registro.ApellidoMaterno;
                        usuario.Email = registro.Email;
                        usuario.Password = registro.password;
                        usuario.Sexo = registro.Sexo;
                        usuario.Telefono = registro.Telefono;
                        usuario.Celular = registro.Celular;
                        usuario.FechaNacimiento = registro.FechaNacimiento;
                        usuario.CURP = registro.CURP;
                        usuario.Status = registro.Status;
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol = registro.IdRol.Value;
                        usuario.Imagen = registro.Imagen;
                        usuario.Direccion = new ML.Direccion();
                        usuario.Direccion.Colonia = new ML.Colonia();   
                        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        usuario.Direccion.Calle = registro.Calle;
                        usuario.Direccion.NumeroInterior = registro.NumeroInterior;
                        usuario.Direccion.NumeroExterior = registro.NumeroExterior;
                        usuario.Direccion.Colonia.IdColonia = registro.IdColonia;
                        usuario.Direccion.Colonia.Municipio.IdMunicipio = registro.IdMunicipio;
                        usuario.Direccion.Colonia.Municipio.Estado.IdEstado = registro.IdEstado;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = registro.IdPais;
                        result.Object = usuario;

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

        public static ML.Result ChangeStatus(int IdUsuario, bool Status)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var rowsAffetted = context.UsuarioChangeStatus(IdUsuario, Status);

                    if (rowsAffetted > 0)
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
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result GetByEmail(string email)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var registro = context.UsuarioGetByEmail(email).FirstOrDefault();
                    if (registro != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();
                        usuario.Email = registro.Email;
                        usuario.Password = registro.password;
                        result.Object = usuario;

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
        public static ML.Result LeerExcel(string connectionString)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (OleDbConnection context = new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM [Sheet1$]";
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;


                        DataTable tableUsuario = new DataTable();

                        da.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.UserName = row[0].ToString();
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Email = row[4].ToString();
                                usuario.Password = row[5].ToString();
                                usuario.Sexo = row[6].ToString();
                                usuario.Telefono = row[7].ToString();
                                usuario.Celular = row[8].ToString();
                                usuario.FechaNacimiento = DateTime.Parse( row[9].ToString());
                                usuario.CURP = row[10].ToString();
                                usuario.Rol  = new ML.Rol();
                                usuario.Rol.IdRol = int.Parse(row[11].ToString());
                                usuario.Imagen = row[12].ToString();
                                usuario.Direccion = new ML.Direccion();
                                usuario.Direccion.Calle = row[13].ToString();
                                usuario.Direccion.NumeroInterior = row[14].ToString();
                                usuario.Direccion.NumeroExterior = row[15].ToString();
                                usuario.Direccion.Colonia= new ML.Colonia();   
                                usuario.Direccion.Colonia.IdColonia = int.Parse(row[16].ToString());
                                result.Objects.Add(usuario);
                            }
                            result.Correct = true;

                        }

                        result.Object = tableUsuario;

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "No existen registros en el excel";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }
        public static ML.Result ValidarExcel(List<object> usuarios)
        {
            ML.Result result = new ML.Result();

            try
            {
                result.Objects = new List<object>(); //almacena los registros incompletos
                int i = 1; //guarda el numero de la fila
                foreach (ML.Usuario usuario in usuarios)
                {
                    ML.ErrorExcel error = new ML.ErrorExcel();
                    error.IdRegistro = i++;

                    if (usuario.Nombre == "")
                    {
                        error.Mensaje += "Ingresar el nombre  ";
                    }
                    if (usuario.ApellidoPaterno == "")
                    {
                        error.Mensaje += "Ingresar el Apellido paterno  ";
                    }
                    if (usuario.ApellidoMaterno == "")
                    {
                        error.Mensaje += "Ingresar el Apellido materno  ";
                    }
                    if (usuario.FechaNacimiento == null)
                    {
                        error.Mensaje += "Ingresa la fecha de nacimiento ";
                    }
                   
                    if (usuario.UserName == null)
                    {
                        error.Mensaje += "Ingresa el nombre de usuario ";
                    }
                    if (usuario.Email == null)
                    {
                        error.Mensaje += "Ingresa el email ";
                    }
                    if (usuario.Password == null)
                    {
                        error.Mensaje += "Ingresa la contraseña ";
                    }
                    if (usuario.Sexo == null)
                    {
                        error.Mensaje += "Ingresa el sexo ";
                    }
                    if (usuario.Telefono == null)
                    {
                        error.Mensaje += "Ingresa el telefono ";
                    }
                    if (usuario.Celular == null)
                    {
                        error.Mensaje += "Ingresa el celular ";
                    }
                    if (usuario.CURP == null)
                    {
                        error.Mensaje += "Ingresa la CURP";
                    }
                   
                    if (usuario.Direccion.Calle == null)
                    {
                        error.Mensaje += "Ingresa la calle ";
                    }
                    if (usuario.Direccion.NumeroInterior == null)
                    {
                        error.Mensaje += "Ingresa el numero interior ";
                    }
                    if (usuario.Direccion.NumeroExterior == null)
                    {
                        error.Mensaje += "Ingresa el numero exterior";
                    }

                    if (error.Mensaje != null)
                    {
                        result.Objects.Add(error);
                    }


                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }
        ///LINQ
        ///
        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            //
            ML.Result result = new ML.Result();
            try
            {
                //contexto de
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    DL_EF.Usuario usuarioLinq = new DL_EF.Usuario();

                    usuarioLinq.UserName = usuario.UserName;
                    usuarioLinq.Nombre = usuario.Nombre;
                    usuarioLinq.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioLinq.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioLinq.Email = usuario.Email;
                    usuarioLinq.Password = usuario.Password;
                    usuarioLinq.Sexo = usuario.Sexo;
                    usuarioLinq.Telefono = usuario.Telefono;
                    usuarioLinq.Celular = usuario.Celular;
                    usuarioLinq.FechaNacimiento = usuario.FechaNacimiento;
                    usuarioLinq.CURP = usuario.CURP;
                    usuarioLinq.IdRol = usuario.Rol.IdRol;

                    context.Usuarios.Add(usuarioLinq);
                    int filasAfectadas = context.SaveChanges();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Error al agregar al usuario";

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
        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            ML.Direccion direccion = new ML.Direccion();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    // Recuperar el usuario que deseas actualizar según su IdUsuario
                    var usuarioExistente = context.Usuarios.FirstOrDefault(u => u.IdUsuario == usuario.IdUsuario);

                    if (usuarioExistente != null)
                    {
                        // Actualizar las propiedades del usuario existente con los valores proporcionados
                        usuarioExistente.UserName = usuario.UserName;
                        usuarioExistente.Nombre = usuario.Nombre;
                        usuarioExistente.ApellidoPaterno = usuario.ApellidoPaterno;
                        usuarioExistente.ApellidoMaterno = usuario.ApellidoMaterno;
                        usuarioExistente.Email = usuario.Email;
                        usuarioExistente.Password = usuario.Password;
                        usuarioExistente.Sexo = usuario.Sexo;
                        usuarioExistente.Telefono = usuario.Telefono;
                        usuarioExistente.Celular = usuario.Celular;
                        usuarioExistente.FechaNacimiento = usuario.FechaNacimiento;
                        usuarioExistente.CURP = usuario.CURP;
                        usuarioExistente.IdRol = usuario.Rol.IdRol;
                        usuarioExistente.Imagen = usuario.Imagen;

                        // Guardar los cambios en la base de datos
                        context.SaveChanges();

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Usuario no encontrado. No se puede actualizar.";
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
        public static ML.Result DeleteLINQ(int IdUsuario)
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
        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var usuariosLINQ = (from objUsuario in context.Usuarios
                                        join Rol in context.Rols on objUsuario.IdRol equals Rol.IdRol
                                        select new
                                        {
                                            IdUsuario = objUsuario.IdUsuario,
                                            NombreUsuario = objUsuario.Nombre,
                                            ApellidoPaterno = objUsuario.ApellidoPaterno,
                                            ApellidoMaterno = objUsuario.ApellidoMaterno,
                                            FechaNacimineto = objUsuario.FechaNacimiento,
                                            IdRol = Rol.IdRol,
                                            NombreRol = Rol.Nombre,
                                            UserName = objUsuario.UserName,
                                            Email = objUsuario.Email,
                                            contraseña = objUsuario.Password,
                                            Sexo = objUsuario.Sexo,
                                            Telefono = objUsuario.Telefono,
                                            Celular = objUsuario.Celular,
                                            CURP = objUsuario.CURP
                                        }).ToList();

                    result.Objects = new List<object>();
                    if (usuariosLINQ != null && usuariosLINQ.ToList().Count > 0)
                    {

                        foreach (var obj in usuariosLINQ)
                        {
                            ML.Usuario usuario1 = new ML.Usuario();


                            usuario1.Nombre = obj.NombreUsuario;
                            usuario1.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario1.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario1.FechaNacimiento = obj.FechaNacimineto;
                            usuario1.Rol = new ML.Rol();
                            usuario1.Rol.IdRol = obj.IdRol;
                            usuario1.Rol.NombreRol = obj.NombreRol;
                            usuario1.UserName = obj.UserName;
                            usuario1.Email = obj.Email;
                            usuario1.Password = obj.contraseña;
                            usuario1.Sexo = obj.Sexo;
                            usuario1.Telefono = obj.Telefono;
                            usuario1.Celular = obj.Celular;
                            usuario1.CURP = obj.CURP;
                            result.Objects.Add(usuario1);
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
        public static ML.Result GetByIdLINQ(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //Todo lo que se eje cute dnetro de using se libera al final, los recursos
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var usuariosLINQ = (from objUsuario in context.Usuarios
                                        join Rol in context.Rols on objUsuario.IdRol equals Rol.IdRol
                                        where objUsuario.IdUsuario == IdUsuario
                                        select new
                                        {
                                            IdUsuario = objUsuario.IdUsuario,
                                            NombreUsuario = objUsuario.Nombre,
                                            ApellidoPaterno = objUsuario.ApellidoPaterno,
                                            ApellidoMaterno = objUsuario.ApellidoMaterno,
                                            FechaNacimineto = objUsuario.FechaNacimiento,
                                            IdRol = Rol.IdRol,
                                            NombreRol = Rol.Nombre,
                                            UserName = objUsuario.UserName,
                                            Email = objUsuario.Email,
                                            contraseña = objUsuario.Password,
                                            Sexo = objUsuario.Sexo,
                                            Telefono = objUsuario.Telefono,
                                            Celular = objUsuario.Celular,
                                            CURP = objUsuario.CURP
                                        }).Single();

                    result.Objects = new List<object>();
                    if (usuariosLINQ != null)
                    {


                        ML.Usuario usuario1 = new ML.Usuario();
                        usuario1.Nombre = usuariosLINQ.NombreUsuario;
                        usuario1.ApellidoPaterno = usuariosLINQ.ApellidoPaterno;
                        usuario1.ApellidoMaterno = usuariosLINQ.ApellidoMaterno;
                        usuario1.FechaNacimiento = usuariosLINQ.FechaNacimineto;
                        usuario1.Rol = new ML.Rol();
                        usuario1.Rol.IdRol = usuariosLINQ.IdRol;
                        usuario1.Rol.NombreRol = usuariosLINQ.NombreRol;
                        usuario1.UserName = usuariosLINQ.UserName;
                        usuario1.Email = usuariosLINQ.Email;
                        usuario1.Password = usuariosLINQ.contraseña;
                        usuario1.Sexo = usuariosLINQ.Sexo;
                        usuario1.Telefono = usuariosLINQ.Telefono;
                        usuario1.Celular = usuariosLINQ.Celular;
                        usuario1.CURP = usuariosLINQ.CURP;
                        result.Object = usuario1;

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



    }

}

