using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.ValidazioniPersonalizzate
{
    public class ValidationString : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string)
            {
                string inputValue =(string)value;
                if (inputValue == null || inputValue.Split(' ').Length <= 5) 
                {
                    return new ValidationResult("La descrizione deve avere minimo 5 parole!");

                }
                return ValidationResult.Success;
            }
            return new ValidationResult("Il campo inserito non è una stringa");
        }
    }
}
