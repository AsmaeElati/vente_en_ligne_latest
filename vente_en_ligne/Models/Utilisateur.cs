using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace vente_en_ligne.Models
{
    public class Utilisateur
    {
        

        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Veuillez saisir une adresse e-mail valide.")]
      
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(\+[0-9]{1,3})?[0-9]{10,15}$", ErrorMessage = "Veuillez saisir un numéro de téléphone valide.")]
        public string Tel { get; set; }
    }
}
