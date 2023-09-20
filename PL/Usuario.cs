using ML;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el USERNAME del nuevo usuario");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingresa el NOMBRE del nuevo usuario");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el APELLIDO PATERNO materno del nuevo usuario");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el APELLIDO MATERNO del nuevo usuario");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el EMAIL del nuevo usuario");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingresa el PASSWORD del nuevo usuario");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingresa el SEXO del nuevo usuario");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingresa el TELEFONO del nuevo usuario");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingresa el CELULAR del nuevo usuario");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingresa la FECHA DE NACIMIENTO  del nuevo usuario");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa EL CURP  del nuevo usuario");
            usuario.CURP = Console.ReadLine();
            Console.WriteLine("Ingresa el  numero de ID ROL del nuevo usuario");
            //instanciando por primera y unica vez la propiedad de navegacion 
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());

            // ML.Result result = BL.Usuario.Add(usuario);
            // ML.Result result = BL.Usuario.AddSP(usuario);
           //  ML.Result result = BL.Usuario.AddEF(usuario);
           ML.Result result = BL.Usuario.AddLINQ(usuario);

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
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el ID del usuario que deseas ACTUALIZAR");
            int IdUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa nuevo USER NAME");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo  NOMBRE ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo APELIIDO PATERNO");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo APELIIDO MATERNO");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo EMAIL");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo PASSWORD");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo  SEXO");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo TELEFONO");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo CELULAR");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo FECHA DE NACIMIENTO ");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el nuevo CURP ");
            usuario.CURP = Console.ReadLine();
            //instanciando por primera y unica vez la propiedad de navegacion 
            Console.WriteLine("Ingresa el nuevo rol que deseas actualizar");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());
            usuario.IdUsuario = IdUsuario;



            //ML.Result result = BL.Usuario.Update(usuario);
            //ML.Result result = BL.Usuario.UpdateSP(usuario);
            ML.Result result = BL.Usuario.UpdateEP(usuario);
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
            int IdUsuario = int.Parse(Console.ReadLine());


            ML.Usuario usuario = new ML.Usuario();

            usuario.IdUsuario = IdUsuario;

            //  ML.Result result = BL.Usuario.Delete(usuario);
            // ML.Result result = BL.Usuario.DeleteSP(usuario);
           // ML.Result result = BL.Usuario.DeleteEF( IdUsuario);
            ML.Result result = BL.Usuario.DeleteLINQ(IdUsuario);

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

            ML.Result result   = new ML.Result();
            // ML.Result result = BL.Usuario.GetAll();
           // ML.Result result = BL.Usuario.GetAllSP();
            //ML.Result result = BL.Usuario.GetAllEF();
           // ML.Result result = BL.Usuario.GetAllLINQ();
           
            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("El id del usuario es: " + usuario.IdUsuario);
                    Console.WriteLine("El nombre del usuario es: " + usuario.UserName);
                    Console.WriteLine("El Apellido Paterno del usuario es: " + usuario.Nombre);
                    Console.WriteLine("El Apellido Materno del usuario es: " + usuario.ApellidoPaterno);
                    Console.WriteLine("La fecha de nacimiento  del usuario es: " + usuario.ApellidoPaterno);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.ApellidoMaterno);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.Email);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.Password);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.Sexo);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.Telefono);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.Celular);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.FechaNacimiento);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.CURP);
                    Console.WriteLine("La direccion  del usuario es: " + usuario.Rol.IdRol);
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
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el ID del usuario para buscarlo");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            // ML.Result result = BL.Usuario.GetById(usuario);
            //ML.Result result = BL.Usuario.GetByIdSP(usuario);
            ML.Result result = BL.Usuario.GetByIdEF(usuario.IdUsuario);
            //ML.Result result = BL.Usuario.GetByIdLINQ(usuario);



            if (result.Correct)
            {

                Console.WriteLine("El id del usuario es: " + usuario.IdUsuario);
                Console.WriteLine("El nombre del usuario es: " + usuario.UserName);
                Console.WriteLine("El Apellido Paterno del usuario es: " + usuario.Nombre);
                Console.WriteLine("El Apellido Materno del usuario es: " + usuario.ApellidoPaterno);
                Console.WriteLine("La fecha de nacimiento  del usuario es: " + usuario.ApellidoPaterno);
                Console.WriteLine("La direccion  del usuario es: " + usuario.ApellidoMaterno);
                Console.WriteLine("La direccion  del usuario es: " + usuario.Email);
                Console.WriteLine("La direccion  del usuario es: " + usuario.Password);
                Console.WriteLine("La direccion  del usuario es: " + usuario.Sexo);
                Console.WriteLine("La direccion  del usuario es: " + usuario.Telefono);
                Console.WriteLine("La direccion  del usuario es: " + usuario.Celular);
                Console.WriteLine("La direccion  del usuario es: " + usuario.FechaNacimiento);
                Console.WriteLine("La direccion  del usuario es: " + usuario.CURP);
                Console.WriteLine("La direccion  del usuario es: " + usuario.Rol.IdRol);
                Console.WriteLine("*-*-*-**-");


            }
            else
            {
                Console.WriteLine("Error al mostrar" + result.ErrorMessage);
            }

        }


    }
}