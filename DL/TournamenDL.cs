using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace DL
{
    internal class TournamenDL
    {
        private static List<tournament> tour = new List<tournament>();

        internal static List<tournament> Tour { get => tour; set => tour = value; }
        public static void addTouramentsTList(tournament t)
        {
            Tour.Add(t);
        }
        public static void storeTournamentInFile()
        {
            string path = "Tournament.txt";
            StreamWriter sw = new StreamWriter(path, false);
            for (int i = 0; i < tour.Count; i++)
            {
                sw.WriteLine(tour[i].Name + "," + tour[i].StartDate + "," + tour[i].StartMonth);
            }
            sw.Flush();
            sw.Close();
        }
        public static bool loadTournamentFromFile(string path)
        {
            if (File.Exists(path))
            {

                StreamReader sr = new StreamReader(path);
                string line = "";
                while (!sr.EndOfStream)
                {
                    tournament t = new tournament();
                    line = sr.ReadLine();
                    t.Name = teamsDL.parsing(line, 1);
                    t.StartDate = int.Parse(teamsDL.parsing(line, 2));
                    t.StartMonth = int.Parse(teamsDL.parsing(line, 3));
                    tour.Add(t);
                }
                sr.Close();
                return true;
            }
            return false;
        }
        public static void deleteTournament(tournament tournament)
        {
            for(int i=0;i<Tour.Count;i++)
            {
                if(Tour[i] == tournament)
                {
                    tour.RemoveAt(i);
                }
            }
        }
    }
}
