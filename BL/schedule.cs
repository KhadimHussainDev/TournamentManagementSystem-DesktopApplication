using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL { 
    internal class schedule
    {
        private string team1Name;
        private string team2Name;
        private int date;
        private int month;
        private int year;
        private int time;
        public schedule() {
            year = 2022;
        }
        public schedule(string team1, string team2, int date, int month) {
            this.team1Name = team1;
            this.team2Name = team2;
            this.date = date;
            this.month = month;
            this.year = 2022;
            this.time = date+(month*30);

        }
        public string Team1Name { get => team1Name; set => team1Name = value; }
        public string Team2Name { get => team2Name; set => team2Name = value; }
        public int Date { get => date; set => date = value; }
        public int Month { get => month; set => month = value; }
        public int Time { get => time; set => time = value; }
        public int Year { get => year; set => year = value; }
        public static void storeScheduleInFile(schedule scheduled)
        {
            string path = "TeamSchedule.txt";
            StreamWriter sw = new StreamWriter(path, true);
            // Store Teams Schedule Data in txt File
           
                sw.WriteLine(scheduled.Team1Name + "," + scheduled.Team2Name + "," + scheduled.Date + "," + scheduled.Month + "," + scheduled.Time);
           
            sw.Flush();
            sw.Close();
        }
    }
}
