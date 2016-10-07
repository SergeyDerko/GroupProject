namespace _09_10_Class.Helper
{
    public class Base : IBaseInterface
    {
        public void ToSomeString()
        {
            
        }


        public string Name { get; set; }
        public string SName { get; set; }
        public string Age { get; set; }
    }

    public interface IBaseInterface
    {
        string Name { get; set; }
        string SName { get; set; }
        string Age { get; set; }
    }

}
