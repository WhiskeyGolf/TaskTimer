using System;

namespace TaskTimer
{
    public static class UserInput
    {
        public static UserInputEnum ReadInput()
        {
            if (Console.KeyAvailable)
            {
                var keyPressed = Console.ReadKey(true);
                switch(keyPressed.Key)
                {
                    case ConsoleKey.Spacebar:
                        return UserInputEnum.TimerToggle;
                }
            }

            return UserInputEnum.None;
        }
    }
}