using System.ComponentModel.DataAnnotations;

namespace projemmvc.Models
{
    public class ClassRoom
    {
        [Key]
        public int ClassRoom_Id { get; set; }
        public string ClassRoom_Name { get; set; }
        public virtual List<Students>Student { get; set; }
    }
}
