using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Census_Programming_Puzzle
{
    class Program
    {
        static void Main()
        {
            int[] CensusData = {18897109, 12828837, 9461105, 6371773, 5965343, 5946800, 5582170,
                                5564635, 5268860, 4552402, 4335391, 4296250, 4224851, 4192887,
                                3439809, 3279833, 3095313, 2812896, 2783243, 2710489, 2543482,
                                2356285, 2226009, 2149127, 2142508, 2134411 };


            BitArray bitArray = new BitArray(CensusData);

            BitArray goal = new BitArray(100000000);
            
            foreach(var bit in goal)
                Console.WriteLine(bit);
        }

        
    }
}
