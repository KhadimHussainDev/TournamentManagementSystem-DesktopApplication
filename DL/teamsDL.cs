using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
namespace DL
{
    internal class teamsDL
    {
        private static List<teams> team = new List<teams>();

        internal static List<teams> Team { get => team; set => team = value; }
        public static void addTeamToList(teams team)
        {
            Team.Add(team);
        }
        public static void sorting()
        {
            // Sort Point Table
            Team.Sort((x, y) => x.Points.CompareTo(y.Points));
            Team.Reverse();
            //team = team.OrderByDescending(o => o.points).ToList();
        }
        public static void storeTeamsInFile()
        {
            // Store Teams Data in txt File
            string path = "TeamInformation.txt";
            StreamWriter sw = new StreamWriter(path, false);
            for (int i = 0; i < team.Count; i++)
            {
                sw.Write(team[i].TeamName + "," + team[i].OwnerName + "," + team[i].CaptainName + "," + team[i].CaptainAge + "," + team[i].ViceCaptainName + "," + team[i].ViceCaptainAge+",");
                sw.WriteLine(team[i].TotalPlayedMatches + "," + team[i].WonMatches + "," + team[i].LostMatches + "," + team[i].Points);

            }
            sw.Flush();
            sw.Close();
        }
        public static bool loadTeamsFromFile(string path)
        {
            // Load Teams Data in txt File

            string line = "";

            if (File.Exists(path))
            {

                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    teams team = new teams();
                    line = sr.ReadLine();
                    team.TeamName = parsing(line, 1);
                    team.OwnerName = parsing(line, 2);
                    team.CaptainName = parsing(line, 3);
                    team.CaptainAge = int.Parse(parsing(line, 4));
                    team.ViceCaptainName = parsing(line, 5);
                    team.ViceCaptainAge = int.Parse(parsing(line, 6));
                    team.TotalPlayedMatches = int.Parse(parsing(line, 7));
                    team.WonMatches = int.Parse(parsing(line, 8));
                    team.LostMatches = int.Parse(parsing(line, 9));
                    team.Points = int.Parse(parsing(line, 10));
                    Team.Add(team);
                }
                sr.Close();
                return true;
            }
            return false;
        }
        public static string parsing(string line, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    comma++;
                }
                else if (field == comma)
                {
                    item = item + line[i];
                }
            }
            return item;
        }
        public static bool searchTeam(string name)
        {
            bool flag = false;
            for (int i = 0; i < team.Count; i++)
            {
                if (team[i].TeamName == name)
                {
                    Console.Write("TeamName\tOwner\n");

                    Console.Write(team[i].TeamName);
                    Console.Write("\t\t");
                    Console.Write(team[i].OwnerName);
                    Console.Write("\n");
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static void deleteTeamFromList(teams teams)
        {
            for(int i=0;i<team.Count; i++)
            {
                if(teams.TeamName == team[i].TeamName)
                {
                    team.RemoveAt(i);
                }
            }
        }
        
    }
}
