using System.Security.AccessControl;

namespace _09_NewClass.Helper
{
    public interface IBaseInterface
    {
        string Name { get; set; }
        string SName { get; set; }
        int Age { get; set; }
    }
}