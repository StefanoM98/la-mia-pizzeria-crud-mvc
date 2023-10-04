using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage= "Il nome della categoria è obbligatorio")]
        [StringLength(50, ErrorMessage ="Il nome della categoria è troppo lungo")]
        public string Name { get; set; }

        public List<Pizza>? Pizze { get; set; }

        public Categoria()
        {
        }
    }
}
