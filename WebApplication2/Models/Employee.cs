using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int Gender { get; set; }
        public int Email { get; set; }
        public int Country { get; set; }

    }
}
