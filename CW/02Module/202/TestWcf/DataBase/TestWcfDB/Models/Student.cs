using System.ComponentModel.DataAnnotations;

namespace TestWcfDB.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Programlanguage  { get; set; }
    }
    
}
