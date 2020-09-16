using System;
using System.Diagnostics.Tracing;
using System.Threading;
namespace Villkor_och_loopar
{

    /// <summary>
    
       
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0; // Antalet tävlande
            int winNumber = 0;

            int hourTime, minuteTime, secondTime;
            int goalTime;

            int bestHour = 0, bestMinute = 0, bestSecond = 0;
            int bestTime = 0;

            bool isRunning = true; // Bool för loop.

            while (isRunning)
            {
                Thread.Sleep(1000);
                Console.Clear();

                Console.Write("\n\tAnge ett startnummer för den tävlande: ");
                var startNumber = int.Parse(Console.ReadLine());

                if (startNumber <= 0)
                {
                    isRunning = false;
                    continue;
                }

                counter++; // Antalet tävlande.
             
                // Mata in timma för start / minut för start / sekund för start
                Console.WriteLine("\nAnge timme för starttid (0-23): ");
                var startHour = int.Parse(Console.ReadLine());
                Console.WriteLine("\nAnge minut för starttid(0-59): ");
                var startMinute = int.Parse(Console.ReadLine());
                Console.WriteLine("\nAnge sekund för starttid(0-59): ");
                var startSecond = int.Parse(Console.ReadLine());

                // Mata in timma för mål / minut för mål / sekund för mål
                Console.WriteLine("\nAnge timme för mål(0-23): ");
                var goalHour = int.Parse(Console.ReadLine());
                Console.WriteLine("\nAnge minut för mål(0-59): ");
                var goalMinute = int.Parse(Console.ReadLine());
                Console.WriteLine("\nAnge sekund för mål(0-59): ");
                var goalSecond = int.Parse(Console.ReadLine());

                int startInSeconds = (startHour * 3600) + (startMinute * 60) + startSecond; // Starttid på dygnet i sekunder
                int goalInSeconds = (goalHour * 3600) + (goalMinute * 60) + goalSecond; // Måltid på dygnet i sekunder

                if (startInSeconds > goalInSeconds) // Om midnatt passeras
                {
                    goalInSeconds = (86400 + goalInSeconds);
                }

                goalTime = goalInSeconds - startInSeconds;

                hourTime = (goalTime / 3600);
                minuteTime = (goalTime % 3600) / 60;
                secondTime = (goalTime % 60);

                Console.WriteLine($"\nTimmar: {hourTime}" +
                                  $"\nMinuter: {minuteTime} " +
                                  $"\nSekunder {secondTime}");
                

                if (goalTime < bestTime || counter == 1)
                {
                    bestTime = goalTime;
                    winNumber = startNumber;
                    bestHour = hourTime;
                    bestMinute = minuteTime;
                    bestSecond = secondTime;
                }

            }

            if (winNumber == 0)
            {
                Console.Clear();
                Console.WriteLine("\nInga tävlande!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\nAntal tävlande: {counter}");
                Console.WriteLine($"\nVinnaren är: {winNumber}");
                Console.WriteLine($"\nVinnande sluttid är: {bestHour} Timmar {bestMinute} Minuter {bestSecond} Sekunder.");
            }

            Console.ReadLine();

        }
    }
}

