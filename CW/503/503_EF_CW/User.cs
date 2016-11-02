using System.ComponentModel.DataAnnotations;

namespace _503_EF_CW
{
    internal class User
    {
        //[Key]
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }
    }
}