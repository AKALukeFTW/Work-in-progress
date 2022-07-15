using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace New_Text_Based_RPG_2
{
    class Program
    {
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;

        //the below is the order that the program will execute.
        static void Main(string[] args)
        {
            Start(); 
            NextLevel_Escape(); // levels (dungeon interior and exterior)
            NextLevel_Castle();

            /*----while (mainLoop)
            {
                Encounters.randomEncounter();
            }------*/
        }

        static void Start()
        {
            Console.WriteLine("Welcome to the Marauder's Capstone...Prepare yourself for the ultimate challange.");
            Console.WriteLine("Please enter your name");
            currentPlayer.name = Console.ReadLine();
            if (currentPlayer.name == "")
                Console.WriteLine("You're memory is clouded, you cannot remember your name.");
            else
                Console.WriteLine("You remember your name is " + currentPlayer.name);
            Console.WriteLine("You're memory is clouded. You have not the faintest clue where you are, " +
                "nor what could have contrived to bring you to this dark, dingy mountian dungeon.");
            Console.WriteLine("You hear a faint laugh echoing through the air. As you turn your head you see a masked figure standing menacingly behind you.");
            Console.WriteLine("You look down and see that the heavy leather straps fastening you the chair appear worn and old.");
            Console.WriteLine("As you struggle with all your might and managed to pull free of your bonds you notice your captor making their way towards you. You free yourself. You now turn to face your captor.");
            Console.ReadKey();
            Encounters.FirstEncounter_Wretched_Soul();

            // maybe make the encounters in this file, and not a separate class - could maybe make it more messy but will at least likely make it execute in order
        }
        static void NextLevel_Escape()
        {
            //the below actually works. Idk if I want to make any random encounters, maybe I can set up and in game timer that makes random encounters occure every so often in between new areas of the game.
            Console.WriteLine("As you stand over the stop where you're captor breathed their last you hear a faint spraping of metal and a unintelligable mumble. They're coming.");
            Console.WriteLine("You decide (1) to steady yourself to face the jailmaster, (2) to bust open the window to your cell and climb down the to the belcony below");
            string input = Console.ReadLine().ToLower();


            //interior branch
            if (input == "1")  //battle Guard
            {
                Encounters.SecondEnounter_Guard_2();
                Level_Dungeon_Cells.NextLevel_Dungeon_Interior();
            }
           
            
            //exterior branch
            else if (input == "2") // flea to balcony and battle Jailmaster
            {
                Console.WriteLine("As the Jailmaster makes their way towards the door you franticly try to bust open your cell window. As the door to your cell opens you give one " +
                     "final shove and the fall out of the window onto the balcony below.");
                Console.WriteLine("You look up and see the Jailmaster gazing down to you. You muster all your remaining strenght you lower yourself to the nearest landing. As your feet hit the ground you see +" +
                    "a guard standing by the entrance to the dungeon. You freeze still as they notice you.");
                Encounters.ThirdEncounter_Jailmaster();
                Dungeon_Exterior.Next_Level_Dungeon_Exterior();
            }

        }

        static void NextLevel_Castle()
        {
        Console.WriteLine("You open the door to the castle and see a dragon.");

        }


    }
}