﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rol
    {
        public static ML.Result GetAll()
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var query = context.RolGetAll().ToList();
                    if (query != null)
                    {

                        result.Objects = new List<object>();
                        foreach (var registro in query)
                        {
                            ML.Rol rol = new ML.Rol();
                            rol.IdRol = registro.IdRol;
                            rol.NombreRol = registro.Nombre;
                            result.Objects.Add(rol);
                        }
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
    }
}