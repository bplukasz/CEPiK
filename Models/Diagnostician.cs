using System.ComponentModel.DataAnnotations;

namespace CEPiK.Models
{
    public class Diagnostician
    {
        public int DiagnosticianID { get; set; }
        [Required(ErrorMessage ="Nie podano imienia diagnostyka")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nie podano nazwiska diagnostyka")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Nie podano numeru uprawnień diagnostyka")]
        [RegularExpression(@"^[0-9]{4}", ErrorMessage = "Numer uprawnień nie zgodny z formatem (4 cyfry)")]
        public int NumberOfPremissions { get; set; }
    }
}
