using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoreTestWebApp.Models
{
    public class Student
    {
        [DisplayName("Nome")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Cognome")]
        [Required]
        public string LastName { get; set; }

        public long StudentId { get; set; } 

        [DisplayName("Codice Fiscale")]
        [Required]
        public string CF { get; set; } 

        // classe/facoltà
    }
}

// matricola- MTTM4242033I1