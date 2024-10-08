﻿using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Validaciones
{
    public class PrimeraLetraMayusAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(Object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var primeraletra = value.ToString()[0].ToString();

            if (primeraletra != primeraletra.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayuscula.");
            }
            return ValidationResult.Success;
        }
    }
}
