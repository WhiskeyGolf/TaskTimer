using System;

namespace TaskTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var timer = new Timer(60);
            timer.Start();
        }
    }
}