using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {
        public List<object> Usuarios;

        public int IdUsuario { get; set; }
       
        public string UserName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido Paterno es obligatorio")]
        [DisplayName("Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [DisplayName("Apellido Materno")]
        public string ApellidoMaterno { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]

        public string Email { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [Range (8,20)]
        public string Password  { get; set; }
        public string Sexo { get; set; }
        [Range(10, 12)]
        public string Telefono { get; set; }

        public string Imagen { get; set; }
        [RegularExpression(@"^\d{2}-\d{2}-\d{2}-\d{2}-\d{2}$", ErrorMessage = "El formato del número de seguro social no es válido")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DisplayName("Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        [StringLength(18, MinimumLength = 18, ErrorMessage = "El nombre debe tener 18 caracteres")]
        [Required]
        public string CURP { get; set; }
        public bool Status { get; set; }

        //Propiedad de Navegacion

        public ML.Rol Rol { get; set; }
        public ML.Direccion Direccion { get; set; }
       public ML.Aseguradora Aseguradora { get; set;}
       public ML.Dependiente Dependiente { get; set;}

    }
}