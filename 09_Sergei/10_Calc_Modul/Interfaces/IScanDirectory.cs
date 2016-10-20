namespace _10_Calc_Modul.Interfaces
{
    internal interface IScanDirectory
    {
        string PathDir { get; set; }
        string Scan(string pathFile);
        
    }
}
