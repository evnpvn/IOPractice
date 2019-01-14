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

            //StreamReader instantiated to read the SoccerGameResults file 
            using (StreamReader reader = new StreamReader(fileName))
            {
                //line variable created to contain each line of the file
                string line = "";

                //To read the header fields
                reader.ReadLine();

                //while Readline is assinging a value to line variable that is not null
                while((line = reader.ReadLine()) != null)
                {
                    //split the string line up by each field and assign it to the value variable
                    string[] values = line.Split(',');

                    //instantiate a new gameResult object so we can use the new property
                    GameResult gameResult = new GameResult();
                    //create a variable for gameDate.
                    DateTime gameDate;
                    //Try to parse the first string variable in the values string array
                    //assign the parsed value to the gameDate variable
                    if(DateTime.TryParse(values[0], out gameDate))
                    {
                        //if all that worked then take the parsed gameDate and set it
                        //to the GameDate property on the gameResult object
                        gameResult.GameDate = gameDate;
                        Console.WriteLine(gameDate);
                    }
                    soccerResults.Add(values);
                }
                
            }

            return soccerResults;
            
        }
    }
}