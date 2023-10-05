using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        
        public int Id {  get; set; }

        [Required(ErrorMessage = "Il nome della pizza è obbligatorio")]
        [MaxLength(50, ErrorMessage ="Il nome è troppo lungo, nessuno leggerà un nuome del genere")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La descrizione è obbligatoria")]
        [ValidazioniPersonalizzate.ValidationString]
        [MaxLength(200, ErrorMessage = "La descrizione è troppo lunga, nessuno leggerà una descrizione cosi lunga")]
        public string Description { get; set; }
        public string? Pathimg { get; set; } = "/img/deafult.jpg";

        [Range(3.50, 20.99)]
        public float Price { get; set; }

        public int? CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public List<Gusto>? Gusti { get; set; }

        public Pizza() { }

        public Pizza(int id, string name, string description, string pathimg, float price) 
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Pathimg = pathimg;
            this.Price = price;
        }

    }
}
