using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Text_Based_RPG_2
{
    internal class Level_Dungeon_Cells
    {


        //encounters




        public static void NextLevel_Dungeon_Interior()
        {
            Console.WriteLine("You wander down the dimly lit corridor, head down as the lost souls stare blanky at you from their cells as you pass on by");
            Console.WriteLine("You come to a corssroads. You can either 1) open the door right in front of you, from which you hear coming the faint murmor of voices, 2) " +
                "go to your left, down a similar corridor to the one which you have just wandered, but where the wailing and screams " +
                "are louder than whence you have come.");

            string input = Console.ReadLine().ToLower();
           
            //go throught the door
            //this can also be where you can choose your equiptment.
            //it would also be cool to have a menu that you an achivate by pressing (m)enu, and where you can change your loudout.
            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("You open the door slowly and with great care. You steal a glimpse into the room and see two guards sitting by the hearth, backs turned to you.");
                Console.WriteLine("As you enter the room you see an equiptment rack. You make your way over to grab yourself a weapon. You notice that guards are unarmed" + 
                    "You harry towards them, weapon overhead ready to strike.");
                Console.WriteLine("As you get closer you see what you thought were two men are infact one, a double headed ogre!");
                Encounters.GoThroughTheDoor();
            }


            //go to the left
            else if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("You continue wandering down the corridor, the wailing intensifies. As you near the door from whence the screams are coming a shrill voice from the cell to your right whispers" +
                    "psss...let me out or else I'll call the guards.");
                Console.WriteLine("You decide to (1) press onwards, hoping to the Gods that you can escape before the guards find you, (2) open the cell with the guard's key, releasing this poor wretch.");
                Console.ReadKey();

                //decide not the release prisoner
                
                if (input == "1")
                {
                    //the below Console.WriteLine wont execute, I only get the encounter
                    Console.Clear();
                    Console.WriteLine("You decide to leave this wretch to their fate. As you turn the corner you hear a faint sob.");
                    Console.WriteLine("You find an open cell, window juttering to and fro. You approach. As you enter the room you hear the door close behind you.");
                    Console.WriteLine("You're pushed against the wall. As you look up you barely manage to doge as the guard attempts to slice you in two...You stand to face them");
                    Console.ReadKey();
                    Encounters.FirstEncounter_Wretched_Soul();
                    Console.WriteLine("You muster all your remaining strenght you lower yourself to the nearest landing.");
                    Dungeon_Exterior.Next_Level_Dungeon_Exterior();
                }
                
                //release prisoner
                else if (input == "2")
                {
                    int boon = 10;
                    Console.Clear();
                    Console.WriteLine("As soon as you open the cell the wretch inside jumps over you and ruces down the corrdior.");
                    Console.WriteLine("May the God's preserve you! It shouts as it turns the corder.");
                    Program.currentPlayer.health += boon;
                    Console.WriteLine("The noise that you have caused appears to have been notices, for as soon as you turn back around a guard appers out the adjacent cell...You must now face them");
                    Console.ReadKey();
                    Encounters.FirstEncounter_Wretched_Soul();
                    Console.WriteLine("You stand over the guard as you drive the blade of your sword between thier eyes. As you do, their skull explodes over the floor.");
                    Console.WriteLine("You find an open cell, window juttering to and fro. You muster all your remaining strenght you lower yourself to the nearest landing.");
                    Dungeon_Exterior.Next_Level_Dungeon_Exterior();
                }

                
            }





        }




















    }
}
