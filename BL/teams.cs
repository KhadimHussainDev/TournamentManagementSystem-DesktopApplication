using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    internal class teams
    {
        private string teamName;
        private string ownerName;
        private string captainName;
        private int captainAge;
        private string viceCaptainName;
        private int viceCaptainAge;
        private int totalPlayedMatches;
        private int wonMatches;
        private int lostMatches;
        private int points;
        public teams(string teamName, string ownerName, string captainName, int captainAge, string viceCaptainName, int viceCapainAge)
        {
            this.teamName = teamName;
            this.ownerName = ownerName;
            this.captainName = captainName;
            this.captainAge = captainAge;
            this.viceCaptainName = viceCaptainName;
            this.viceCaptainAge = viceCapainAge;
        }
        public teams()
        {

        }
        public teams(teams team)
        {
            this.TeamName = team.TeamName;
            this.OwnerName = team.OwnerName;
            this.CaptainName = team.CaptainName;
            this.CaptainAge = team.CaptainAge;
            this.TotalPlayedMatches = team.TotalPlayedMatches;
            this.WonMatches = team.WonMatches;
            this.LostMatches = team.LostMatches;
            this.Points = team.Points;
        }

        public string TeamName { get => teamName; set => teamName = value; }
        public string OwnerName { get => ownerName; set => ownerName = value; }
        public string CaptainName { get => captainName; set => captainName = value; }
        public int CaptainAge { get => captainAge; set => captainAge = value; }
        public string ViceCaptainName { get => viceCaptainName; set => viceCaptainName = value; }
        public int ViceCaptainAge { get => viceCaptainAge; set => viceCaptainAge = value; }
        public int TotalPlayedMatches { get => totalPlayedMatches; set => totalPlayedMatches = value; }
        public int WonMatches { get => wonMatches; set => wonMatches = value; }
        public int LostMatches { get => lostMatches; set => lostMatches = value; }
        public int Points { get => points; set => points = value; }
        public static void storeTeamsInFile(teams team)
        {
            // Store Teams Data in txt File
            string path = "TeamInformation.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.Write(team.TeamName + "," + team.OwnerName + "," + team.CaptainName + "," + team.CaptainAge + "," + team.ViceCaptainName + "," + team.ViceCaptainAge+",");
            sw.WriteLine(team.TotalPlayedMatches + "," + team.WonMatches + "," + team.LostMatches + "," + team.Points);
            sw.Flush();
            sw.Close();
        }
    }
}
