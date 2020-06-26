using System.ComponentModel;

namespace CoreTestWebApp.Models
{
    public class Student
    {
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Cognome")]
        public string LastName { get; set; }    
    }
}