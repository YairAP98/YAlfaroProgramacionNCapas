using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {

        public static void Add()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            //instanciando por primera y unica vez la propiedad de navegacion 
            //usuario.Rol = new ML.Rol();
            //usuario.Rol.IdRol = int.Parse(Console.ReadLine());

            // ML.Result result = BL.Usuario.Add(usuario);
            // ML.Result result = BL.Usuario.AddSP(usuario);
            //  ML.Result result = BL.Usuario.AddEF(usuario);
            ML.Result result = BL.Aseguradora.AddEF(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("Usuario agregado exitosamente");
            }
            else
            {
                Console.WriteLine("Usuario no agregado " + result.ErrorMessage);
            }

        }

        //Agregar
        public static void Update()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

          
            //instanciando por primera y unica vez la propiedad de navegacion 
            //Console.WriteLine("Ingresa el nuevo rol que deseas actualizar");
            //usuario.Rol = new ML.Rol();
            //usuario.Rol.IdRol = int.Parse(Console.ReadLine());
            //usuario.IdUsuario = IdUsuario;



            //ML.Result result = BL.Usuario.Update(usuario);
            //ML.Result result = BL.Usuario.UpdateSP(usuario);
            ML.Result result = BL.Aseguradora.UpdateEP(aseguradora);
            // ML.Result result = BL.Usuario.UpdateLINQ(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Usuario actualizado");
            }
            else
            {
                Console.WriteLine("Usuario NO ACTUALIZADO " + result.ErrorMessage);
            }


            Console.WriteLine(result);
            Console.ReadKey();
        }//Actualizar
        public static void Delete()
        {
            Console.WriteLine("Ingresa el ID del usuario que deseas ELIMINAR");
            int IdAseguradora = int.Parse(Console.ReadLine());


            ML.Aseguradora aseguradora = new ML.Aseguradora();

          //  usuario.IdUsuario = IdUsuario;

            //  ML.Result result = BL.Usuario.Delete(usuario);
            // ML.Result result = BL.Usuario.DeleteSP(usuario);
            // ML.Result result = BL.Usuario.DeleteEF( IdUsuario);
            ML.Result result = BL.Aseguradora.DeleteEF(IdAseguradora);

            if (result.Correct)
            {
                Console.WriteLine("Usuario ELIMINADO exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar el ususario " + result.ErrorMessage);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }//Eliminar
        public static void GetAll() //Obtener todos los registros
        {
            // ML.Result result = BL.Usuario.GetAll();
            //ML.Result result = BL.Usuario.GetAllSP();
            ML.Result result = BL.Aseguradora.GetAllEF();
            // ML.Result result = BL.Usuario.GetAllLINQ();

            if (result.Correct)
            {
                foreach (ML.Aseguradora aseguradora in result.Objects)
                {
                    //Console.WriteLine("El id del usuario es: " + usuario.IdUsuario);
                    //Console.WriteLine("El nombre del usuario es: " + usuario.UserName);
                    //Console.WriteLine("El Apellido Paterno del usuario es: " + usuario.Nombre);
                    //Console.WriteLine("El Apellido Materno del usuario es: " + usuario.ApellidoPaterno);
                    //Console.WriteLine("La fecha de nacimiento  del usuario es: " + usuario.ApellidoPaterno);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.ApellidoMaterno);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.Email);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.Password);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.Sexo);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.Telefono);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.Celular);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.FechaNacimiento);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.CURP);
                    //Console.WriteLine("La direccion  del usuario es: " + usuario.Rol.IdRol);
                }
            }
            else
            {
                Console.WriteLine("Error " + result.ErrorMessage);
            }
        }
        //Obtener solo un registro por medio del Id
        public static void GetById()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingresa el ID del usuario para buscarlo");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            // ML.Result result = BL.Usuario.GetById(usuario);
            //ML.Result result = BL.Usuario.GetByIdSP(usuario);
            ML.Result result = BL.Usuario.GetByIdEF(aseguradora.IdAseguradora);
            //ML.Result result = BL.Usuario.GetByIdLINQ(usuario);



            if (result.Correct)
            {

                //Console.WriteLine("El id del usuario es: " + usuario.IdUsuario);
                //Console.WriteLine("El nombre del usuario es: " + usuario.UserName);
                //Console.WriteLine("El Apellido Paterno del usuario es: " + usuario.Nombre);
                //Console.WriteLine("El Apellido Materno del usuario es: " + usuario.ApellidoPaterno);
                //Console.WriteLine("La fecha de nacimiento  del usuario es: " + usuario.ApellidoPaterno);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.ApellidoMaterno);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.Email);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.Password);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.Sexo);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.Telefono);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.Celular);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.FechaNacimiento);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.CURP);
                //Console.WriteLine("La direccion  del usuario es: " + usuario.Rol.IdRol);
                //Console.WriteLine("*-*-*-**-");


            }
            else
            {
                Console.WriteLine("Error al mostrar" + result.ErrorMessage);
            }

        }

    }
}
