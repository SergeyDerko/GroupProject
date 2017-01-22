using System;
using System.IO;
using TestWcfCommon;

namespace TestWcfSite
{
    public class StartLoger
    {
        public static void Init()
        { 
            
            Logger.Level = Config.Get.Log.Level; //при неотстроенном конфиге =  null
            
            try
            {
                Logger.Dir = Config.Get.Log.Dir;
                if (!Directory.Exists(Logger.Dir))
                {
                    Directory.CreateDirectory(Logger.Dir);
                }
            }
            catch
            {
            }

            Logger.Prefix = Config.Get.Log.Prefix;
            Logger.Start();

            Logger.Write(Level.Info, "Обращение к сайту");
    

        }
        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            const string method = "UnhandledExceptionHandler";
            var ex = (Exception)args.ExceptionObject;
            if (ex == null)
            {
                Logger.Error(method, "Undefined error!");
            }
            else
            {
                Logger.Exception(method, ex);
            }
        }
    }
}