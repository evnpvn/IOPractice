using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the current folder name that we are in and assign it to a string variable
            string currentDirectory = Directory.GetCurrentDirectory();

            //Initializes new DirectoryInfo object and pass it the currentDirectory name as a parameter for construction
            //We did this so that we could use DirectoryInfo's property of FullName below
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);

            Console.WriteLine(directory.FullName);

            //created a string variable for the filename. Path.Combine method combines a number of strings into a Filepath
            //We're using this method to append \data.txt to the directory. We could have done it with just a string but this is a bestpractice
            string fileName = Path.Combine(directory.FullName, "data.txt");

            //initializing a new instance of FileInfo object against our fully qualified fileName
            //allows us to use the exists property in the if statement to check if the file exists before using it.
            FileInfo file = new FileInfo(fileName);

            Console.WriteLine(fileName);
            Console.WriteLine(file.FullName);

            if(file.Exists)
            {
                //Created a new StreamReader instance and passed it the File's FullName.
                //Changed the Console's default stream to read from the file.
                //Read the file's text to the Console, and passed that to the Console to write to the console.
                //wrapped it all in a using block because we want to remove the file from memory after this block since we are done with it.
                using (StreamReader reader = new StreamReader(file.FullName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());
                }
            }
        }
    }
}
