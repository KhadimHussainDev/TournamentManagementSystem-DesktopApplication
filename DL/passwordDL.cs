using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace DL
{
    internal class passwordDL
    {
        private static logInfo log = new logInfo();

        internal static logInfo Log { get => log; set => log = value; }
        public static bool loadPassword(string path)
        {
           
            StreamReader sr = new StreamReader(path);
            if (File.Exists(path))
            {

                logInfo l = new logInfo();
            string line = "";
            line = sr.ReadLine();
            l.Username = teamsDL.parsing(line, 1);
            l.Password = teamsDL.parsing(line, 2);

            sr.Close();
            if (l.Username != "\0")
            {
                log = l;
            }
                return true;
            }
            return false;
        }
        public static void storePassword()
        {
           
            string path = "Password.txt";
            StreamWriter sw = new StreamWriter(path, false);
            sw.WriteLine(log.Username + "," + log.Password);
            sw.Flush();
            sw.Close();
        }

    }
}
