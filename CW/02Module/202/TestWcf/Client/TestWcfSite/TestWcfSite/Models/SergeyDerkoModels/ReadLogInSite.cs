using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using TestWcfCommon;

namespace TestWcfSite.Models.SergeyDerkoModels
{
    public class ReadLogInSite
    {
       // public string ReadLogInServise = Read();

        public string Read()
        {
            string path = Logger.Dir + "\\" + Logger.Prefix + DateTime.Now.Date.ToString(@"\-yyyy\-MM\-dd") + ".txt";
            Stream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader streamReader = new StreamReader(stream, Encoding.Default);
            string str = streamReader.ReadToEnd();
            return str;
        }
    }
}