using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Valley_Of_Despair
{
    public interface IASCIIable
    {
        public static void MainMenuArt()
        {
            string environment = Environment.CurrentDirectory;
            string fileName = "ValleyOfDespair.txt";
            string filePath = Path.Combine(environment, fileName);
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Critical Error, please restart.");
            }
        }
        public static void GameOver()
        {
            string environment = Environment.CurrentDirectory;
            string fileName = "GameOver.txt";
            string filePath = Path.Combine(environment, fileName);
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Critical Error, please restart.");
            }
        }
    }
}
