using System;

namespace DunderMifflinTrivia
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GameControl activeGame = new GameControl();//(right side is what calls costructor "GameControl") creates game and and storing it in the variable "activeGame"
            activeGame.PlayGame();// directs the program to the "GameControl Class" and calls on the "PlayGame" contructor to execute the code in "PlayGame" code block.
        }
    }
}
