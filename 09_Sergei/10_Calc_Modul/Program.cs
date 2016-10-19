namespace _10_Calc_Modul
{
    internal class Program
    {
        private static void Main(/*string[] args*/)
        {
            Calculator calc = new Calculator();
            string[] args = {"21 * 22 + 6 =","23 - 7 =","5 + 5 =","30 / 5 ="};
            calc.Calc(args); 
        }

    }

}
