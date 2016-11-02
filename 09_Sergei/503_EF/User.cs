using System.ComponentModel.DataAnnotations;

namespace _503_EF
{
    class User
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set;}
        public string SName { get; set;}
        public int Age { get; set; }
    }
}
