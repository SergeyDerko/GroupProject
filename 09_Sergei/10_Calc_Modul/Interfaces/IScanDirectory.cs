namespace _10_Calc_Modul.Interfaces
{
    internal interface IScanDirectory
    {
        string PathDir { get; set; }
        string PathResult { get; set;}
        void Scan(string _pathDirectory);
        string DataProcessing(string _str);
    }
}
