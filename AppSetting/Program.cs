using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSetting
{    class Program
    {
        static void Main(string[] args)
        {
            string ip = GetAppSetting("ip", "127.0.0.1");
            Console.WriteLine(ip);
            var maxRecords = GetAppSettingGeneric("maxrecords", 10.1);
            Console.WriteLine(maxRecords);
        }

        static string GetAppSetting(string k, string defVal)
        {
            var v = System.Configuration.ConfigurationManager.AppSettings[k];
            if (v != null)
                return v;
            return defVal;
        }

        static T GetAppSettingGeneric<T>(string k, T defVal){
            string v = System.Configuration.ConfigurationManager.AppSettings[k];
            if(v != null)
                return (T)Convert.ChangeType(v,typeof(T));
            return defVal;
        }


    }
}
