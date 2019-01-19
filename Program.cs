using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SoccerStats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            DirectoryInfo directory = new DirectoryInfo(currentDirectory);

            string fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            List<GameResult> fileContents = ReadSoccerResults(fileName);

            fileName = Path.Combine(directory.FullName, "players.json");
            List<Player> players = DeserializePlayers(fileName);

            foreach(Player player in players)
            {
                Console.WriteLine(player.Team);
            }
        }

        public static string ReadFile(string fileName)
        {   
            using (StreamReader reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }   
    
        public static List<GameResult> ReadSoccerResults(string fileName)
        {
            List<GameResult> soccerResults = new List<GameResult>();

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
                    }

                    gameResult.TeamName = values[1];

                    HomeOrAway homeOrAway;
                    if (Enum.TryParse(values[2], out homeOrAway))
                    {
                        gameResult.HomeOrAway = homeOrAway;
                    }

                    int parseInts;
                    if(Int32.TryParse(values[3], out parseInts))
                    {
                        gameResult.Goals = parseInts;
                    }

                    if(Int32.TryParse(values[4], out parseInts))
                    {
                        gameResult.GoalAttempts = parseInts;
                    }

                    if(Int32.TryParse(values[5], out parseInts))
                    {
                        gameResult.ShotsOnGoal = parseInts;
                    }

                    if(Int32.TryParse(values[6], out parseInts))
                    {
                        gameResult.ShotsOffGoal = parseInts;
                    }

                    double possessionPercent;
                    if(double.TryParse(values[7], out possessionPercent))
                    {
                        gameResult.PossessionPercent = possessionPercent;
                    }

                    soccerResults.Add(gameResult);
                }
            }

            return soccerResults;
        }
    
        public static List<Player> DeserializePlayers(string fileName)
        {
            List<Player> players = new List<Player>();

            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader(fileName))
            using (JsonTextReader jsonReader = new JsonTextReader(reader))
            {
                players = serializer.Deserialize<List<Player>>(jsonReader);
            }
            
            return players;
        }

    }
}