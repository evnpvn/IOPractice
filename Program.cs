using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            DirectoryInfo directory = new DirectoryInfo(currentDirectory);

            string fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");

            List<string[]> fileContents = ReadSoccerResults(fileName);
        }

        public static string ReadFile(string fileName)
        {   
            using (StreamReader reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }

        }   
    
        public static List<string[]> ReadSoccerResults(string fileName)
        {
            List<string[]> soccerResults = new List<string[]>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = "";
                while((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    soccerResults.Add(values);
                }
                
            }

            return soccerResults;
            
        }
    }
}