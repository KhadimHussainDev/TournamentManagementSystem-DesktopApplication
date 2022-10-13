using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace DL
{
    internal class scheduleDL
    {
        private static List<schedule> scheduled = new List<schedule>();

        internal static List<schedule> Scheduled { get => scheduled; set => scheduled = value; }
        public static void matchSchedule()
        {
            // Sort Matches with respect to Date
            Scheduled.Sort((x, y) => x.Time.CompareTo(y.Time));

        }
        public static void addintoList(schedule s)
        {
            scheduled.Add(s);
        }
        public static void deleteScheduleFromList(schedule schedule) {
            for(int i=0;i<scheduleDL.scheduled.Count;i++)
            {
                if (scheduleDL.scheduled[i] == schedule)
                {
                    Scheduled.RemoveAt(i);
                }
            }
        }
        public static void storeScheduleInFile()
        {
            string path = "TeamSchedule.txt";
            StreamWriter sw = new StreamWriter(path, false);
            // Store Teams Schedule Data in txt File
            for (int i = 0; i < scheduled.Count; i++)
            {
                sw.WriteLine(scheduled[i].Team1Name + "," + scheduled[i].Team2Name + "," + scheduled[i].Date + "," + scheduled[i].Month + "," + scheduled[i].Time);
            }
            sw.Flush();
            sw.Close();
        }
      public  static bool loadScheduleFromFile(string path)
        {
            // Load Teams Schedule Data in txt File
            if (File.Exists(path))
            {

            StreamReader sw = new StreamReader(path);
            string line = "";

            while (!sw.EndOfStream)
            {
                schedule s = new schedule();
                line = sw.ReadLine();
                s.Team1Name = teamsDL.parsing(line, 1);
                s.Team2Name = teamsDL.parsing(line, 2);
                s.Date = int.Parse(teamsDL.parsing(line, 3));
                s.Month = int.Parse(teamsDL.parsing(line, 4));
                s.Time = int.Parse(teamsDL.parsing(line, 5));
                scheduled.Add(s);
            }
            sw.Close();
                return true;
            }
            return false;
        }
    }
}
