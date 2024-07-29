using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MinLength(5,ErrorMessage ="Length should be more than 5")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MinLength(5, ErrorMessage = "Length should be more than 5")]
        public string Lastname { get; set; }
        public int Point { get; set; }

    }
}
