using System;
using System.IO;
using System.Text.RegularExpressions;
using _10_Calc_Modul.Interfaces;

namespace _10_Calc_Modul
{
    internal class ScanDirectory : Calculator, IScanDirectory
    {
        public string PathDir { get; set; }
        
        #region Constructor
        internal ScanDirectory(string pathDir)
        {
            PathDir = pathDir;
        }
        #endregion

        #region MethodScan
        public string Scan(string pathDirectory)
        {
            var str = "";
            var files = Directory.GetFiles(pathDirectory);
            var pathFiles = pathDirectory + files;
            foreach (var fileName in files)
            {
                if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
                {
                    File.Delete(pathDirectory + fileName);
                }
                str = File.ReadAllText(fileName);
                GetRes(str);
            }
            
            return str;
        }
        #endregion

        public string GetRes(string str)
        {
            var pattern = "";
            var tempStr = str.ToCharArray();
            foreach (var x in tempStr)
            {
                if (!Regex.IsMatch(x.ToString(), @"\d") && !Regex.IsMatch(x.ToString(), @"\s") &&
                    !Regex.IsMatch(x.ToString(), @"[*/+-=]")) break;
                str += x.ToString();
                if (Regex.IsMatch(x.ToString(), @"(\d+)"))
                {
                    if (pattern.Contains(@"\d+") || !pattern.Contains(@"([*/+-])"))
                    {
                        pattern = @"(\d+)";
                    }
                    if (pattern.Contains(@"(\d+)\s+([*/+-])\s") && Regex.IsMatch(x.ToString(), @"(\d+)"))
                    {
                        pattern = @"(\d+)\s+([*/+-])\s+(\d+)";
                    }
                    else
                    {
                        pattern += @"(\d+)";
                    }
                }
                if (Regex.IsMatch(str, @"(\d+)\s+([*/+-])\s+(\d+)"))
                {
                    var res = GetResult(pattern, str);
                    str = res.ToString();
                    pattern = @"(\d+)";
                }
                else if (Regex.IsMatch(x.ToString(), @"([*/+-])"))
                {
                    pattern += @"([*/+-])";
                }
                else if (Regex.IsMatch(x.ToString(), @"[=]"))
                {
                    pattern = " ";
                }
            }
            return str;
        }
    }
}