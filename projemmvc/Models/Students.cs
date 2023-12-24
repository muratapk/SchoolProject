using System.ComponentModel.DataAnnotations;

namespace projemmvc.Models
{
    public class Students
    {
        [Key]
        public int Student_Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClassRoom_Id { get; set; }
        public virtual ClassRoom? ClassRoom { get; set; }
    }
}
