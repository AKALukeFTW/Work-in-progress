using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Text_Based_RPG_2
{
    internal class Dungeon_Exterior
    {

        public static void Next_Level_Dungeon_Exterior()
        {
            Console.Clear();
            Console.WriteLine("You travel along the exterior of the dungeon, the towering wall looming menecingly overhead, banners fluttering in the strong mountain winds.");
            Console.WriteLine("You can either (1) make your way towards the main gate, that you notice is only guarded by one guard. This path, however, could make you are" + 
                "a target of any archers that might be waiting on the wall, or (2) make your way towards the steps, taking you to the top of the wall, providing you with a vantage over the grounds" +
                "and likely allowing you to deal with any archers that might impeed your escape.");

            string input = Console.ReadLine().ToLower();

            //make you way towards the gate
            if (input == "1")
            {

            }

            //make your way towards the steps - takes you to the top of the wall
            else if (input == "2")
            {


            }


        }







    }
}
