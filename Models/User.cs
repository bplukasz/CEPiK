
using System.ComponentModel.DataAnnotations;

namespace CEPiK.Models
{
    public class CepikContext
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę użytkownika !")]
        [Display(Name = "Nazwa uzytkownika")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Wprowadź hasło")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        public string Name { get; set; }
    }
}
