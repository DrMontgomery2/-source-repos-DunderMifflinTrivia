using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DunderMifflinTrivia
{
    class GameControl
    {

        private string GameGraphic = @"
______                 _            ___  ____  __  __ _ _         _____    _       _       
|  _  \               | |           |  \/  (_)/ _|/ _| (_)       |_   _|  (_)     (_)      
| | | |_   _ _ __   __| | ___ _ __  | .  . |_| |_| |_| |_ _ __     | |_ __ ___   ___  __ _ 
| | | | | | | '_ \ / _` |/ _ \ '__| | |\/| | |  _|  _| | | '_ \    | | '__| \ \ / / |/ _` |
| |/ /| |_| | | | | (_| |  __/ |    | |  | | | | | | | | | | | |   | | |  | |\ V /| | (_| |
|___/  \__,_|_| |_|\__,_|\___|_|    \_|  |_/_|_| |_| |_|_|_| |_|   \_/_|  |_| \_/ |_|\__,_|

";
        //properties/fields that can be used in the methods.
        private string GameWelcome = "THE DUNDER MIFFLIN TRIVIA GAME";
        private string GameDescription = "This is your chance to win the heralded Dundie Award";
        private Players ActivePlayer;
        private DMKnowledge PamAndJim; // is a specific instance of DMKnowledge.
        private DMKnowledge DwightSchrute; // is a specific instance of DMKnowledge.
        private DMKnowledge MichaelScott; // is a specific instance of DMKnowledge.
        private DMKnowledge StanleyAttack;
        private DMKnowledge RoyFight;
        private DMKnowledge KevinFootware;
        private DMKnowledge CreedLSD;
        private DMKnowledge PamsFirstDate;
        private DMKnowledge MeridithPhD;
        private DMKnowledge DwightCPR;

        public GameControl()//constructor
        {
            string firstBornBoy = "TRUE OR FALSE: Both Pam and Angela wanted to name their male child Phillip.";
            PamAndJim = new DMKnowledge(firstBornBoy,"true");
            
            string dwightSchruteTrivia = "TRUE OR FALSE: Dwight Schrute is a trained karate master.";
            DwightSchrute = new DMKnowledge(dwightSchruteTrivia, "true");

            string michaelScottFacts = "TRUE OR FALSE: Michael Scott's club name is Date Mike";
            MichaelScott = new DMKnowledge(michaelScottFacts, "true");

            string stanleyheart = "TRUE OR FALSE: Stanley had a heart attack after a fire drill.";
            StanleyAttack = new DMKnowledge(stanleyheart, "true");

            string royFightJim = "TRUE OR FALSE: Pam's boyfriend Roy beat up Jim for kissing her.";
            RoyFight = new DMKnowledge(royFightJim, "false");

            string kevinsfeet = "TRUE OR FALSE: Kevin wore Kleenex boxes on his feet to Pam and Jim's wedding";
            KevinFootware = new DMKnowledge(kevinsfeet, "true");

            string creedDrugs = "TRUE OR FALSE: In the final season, Creed was arrested for selling weapons grade LSD in the 60s.";
            CreedLSD = new DMKnowledge(creedDrugs, "true");

            string pamCartoon = "TRUE OR FALSE: After Jim moved away Pam's first date was with a local cartoonist for the Scranton Times.";
            PamsFirstDate = new DMKnowledge(pamCartoon, "true");

            string meridithsmart = "TRUE OR FALSE: In the final season, the PBS crew revealed Merideth Palmer was a PhD student.";
            MeridithPhD = new DMKnowledge(meridithsmart, "true");

            string dwightLector = "TRUE OR FALSE: In a CPR class, Dwight determined the CPR dummy couldn't be saved so he cut the face off.";
            DwightCPR = new DMKnowledge(dwightLector, "true");



        }


        public void PlayGame()//starts the game
        {
            Title = GameWelcome;//places the title of game in the top corner of the game. (Console Title)
            WriteLine(GameGraphic);
            WriteLine($"WELCOME TO {GameWelcome}");
            WriteLine(GameDescription);
            WriteLine("\nPlease enter your name");//allows the user to input text and it is stored in the playerNamer string.
            string playerName = ReadLine(); //program will read whatever the user types.
            ActivePlayer = new Players(playerName);//creates an instance of a new player (instantiation) player name is passed in from the player class.
            WriteLine($"\nWelcome to Dunder Mifflin {ActivePlayer.Name}");
            //Add scoring method in next iteration. WriteLine($"\nYour starting score in the race for the Dundie is {ActivePlayer.Score}");// we can use fields from the player class that we made public.

            PamAndJim.AskTheQuestion();//prints out the questions
           
            DwightSchrute.AskTheQuestion();//prints out the questions

            MichaelScott.AskTheQuestion();//prints out the questions

            StanleyAttack.AskTheQuestion();

            RoyFight.AskTheQuestion();

            KevinFootware.AskTheQuestion();

            CreedLSD.AskTheQuestion();

            PamsFirstDate.AskTheQuestion();

            MeridithPhD.AskTheQuestion();

            DwightCPR.AskTheQuestion();

            WriteLine("Press any key to continue...");
            ReadKey();//keeps window open.


        }

    }
}
