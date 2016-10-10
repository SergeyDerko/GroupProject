namespace 07_Hierarchy
{
    internal class Program
    {
        private static void Main()
        {
            var myClass = new MyClass();
            myClass.Name = "Vasya";
            myClass.SName = "Pupkin";
            myClass.Age = 13;

            Console.WriteLine(myClass.Show());
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
