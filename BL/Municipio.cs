using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Municipio
    {
        public static ML.Result GetByIdEstado(int idEstado)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.YAlfaroProgramacionNCapasEntities3 context = new DL_EF.YAlfaroProgramacionNCapasEntities3())
                {
                    var query = context.MunicipioGetByIdEstado(idEstado).ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Municipio municipio = new ML.Municipio();
                            municipio.Nombre = obj.Nombre;
                            municipio.IdMunicipio = obj.IdMunicipio;
                            result.Objects.Add(municipio);
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