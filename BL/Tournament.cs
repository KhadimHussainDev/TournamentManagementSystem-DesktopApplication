using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    internal class tournament
    {
        private string name;
        private int startingDate;
        private int startingMonth;
        private int startingYear;   
        public tournament() {
            StartingYear = 2022;
        }
        public tournament(tournament t)
        {
            this.Name = t.Name;
            this.StartDate = t.StartDate;  
            this.StartMonth = t.StartMonth;
        }
        public tournament(string name,int date,int month)
        {
            this.Name = name;
            this.StartDate = date;
            this.StartMonth= month;
            StartingYear = 2022;

        }
        public string Name { get => name; set => name = value; }
        public int StartDate { get => startingDate; set => startingDate = value; }
        public int StartMonth { get => startingMonth; set => startingMonth = value; }
        public int StartingYear { get => startingYear; set => startingYear = value; }
        public static void storeTournamentInFile(tournament tour)
        {
            string path = "Tournament.txt";
            StreamWriter sw = new StreamWriter(path, true);
            
                sw.WriteLine(tour.Name + "," + tour.StartDate + "," + tour.StartMonth);
            
            sw.Flush();
            sw.Close();
        }
    }
}
