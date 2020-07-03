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

        public int StudentId { get; set; }
        public string CF { get; set; }
    }
}