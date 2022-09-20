using ManejoPresupuesto.Validaciones;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Presupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [PrimeraLetraMayus]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas", AdditionalFields = nameof(Id))]
        //[StringLength(maximumLength: 50, MinimumLength = 8, ErrorMessage = "La longitud del campo {0} debe de estar estre {2} y {1}.")]
        [Display(Name = "Nombre del tipo cuenta")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

    }
}
