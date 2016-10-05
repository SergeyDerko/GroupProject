namespace _07_prg.Helper
{
    interface IBasaInterface
    {
        string Name { get; set; }
        string Sname { get; set; }
        int Age { get; set; }
    }
    public class Baseclass : IBasaInterface
    {
        public string Name { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
}