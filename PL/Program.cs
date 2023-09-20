using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, que operacion deseas hacer? \n " +
                "1:Altas \n " +
                "2:Actualizaciones \n " +
                "3:Bajas \n " +
                "4:Visualizar todos los datos \n " +
                "5:Visualizar por Id \n " +
                "6:Salir");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                switch (x)
                {
                    case 1:
                        PL.Usuario.Add();
                        break;
                    case 2:
                        PL.Usuario.Update();
                        break;
                    case 3:
                        PL.Usuario.Delete();
                        break;
                    case 4:
                        PL.Usuario.GetAll();
                        break;
                    case 5:
                        PL.Usuario.GetById();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                }

            }
            else
            {
                Console.WriteLine("Escribe un numeroque sea mayor a 0");
            }


            //PL.Usuario.Add();
            // PL.Usuario.Update();
            //PL.Usuario.Delete();
            //PL.Usuario.GetAll();
           // PL.Usuario.GetById();
            Console.ReadKey();
        }
    }
}