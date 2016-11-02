using System.ComponentModel.DataAnnotations;

namespace _503_EF
{
    internal class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }
    }
}