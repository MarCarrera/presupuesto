using System.ComponentModel.DataAnnotations;

namespace Presupuesto.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "El campp {0} es requerido.")]
        [EmailAddress(ErrorMessage ="El campo debe ser un correo electronico valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campp {0} es requerido.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
