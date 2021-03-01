using System;
using System.Diagnostics;
using System.Threading;

namespace TaskTimer
{
    public class Timer
    {
        private float duration;
        private Stopwatch stopwatch;
        public Timer(int durationInMinutes)
        {
            duration = durationInMinutes * 60000;
        }
        
        public void Start()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("################################");
            for (int row = 1; row < 2; row++)
            {
                Console.SetCursorPosition(0, row);
                Console.Write("#                              #");
            }

            Console.SetCursorPosition(0, 2);
            Console.Write("################################");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            Run();
            Console.ReadKey();
        }

        private void Run()
        {
            while (UserInput.ReadInput() != UserInputEnum.TimerToggle)
            {
                Console.SetCursorPosition(2, 1);
                Console.Write("Running Time: " + $"{Math.Floor(stopwatch.Elapsed.TotalMinutes)}:{stopwatch.Elapsed.ToString("ss\\.ff")}");
                Thread.Sleep(100);
            }
        }

    }
}