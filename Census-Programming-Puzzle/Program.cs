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
            
            //List<int> Test = new List<int>() { 4, 5, 6, 7 };
            //List<int> TestResults = new List<int>();
            //var Total = 0;
            //var testNum = 0;
            //while(Total != 17)
            //{
            //    List<int> testResults = new List<int>();
            //    Total = 0;
            //    if((testNum & Test[0b0000_0001]) > 0)
            //    {
            //        Total += Test[0];
            //        testResults.Add(Test[0]);
            //    }
            //    if ((testNum & Test[0b0000_0010]) > 0)
            //    {
            //        Total += Test[1];
            //        testResults.Add(Test[1]);
            //    }
            //    if ((testNum & 0b0000_0011) > 0)
            //    {
            //        Total += Test[2];
            //        testResults.Add(Test[2]);
            //    }
            //    if((testNum & 0b0000_1000) > 0)
            //    {
            //        Total += Test[3];
            //        testResults.Add(Test[3]);
            //    }
            //    testNum++;
            //    if(Total == 17)
            //    {
            //        foreach (var test in testResults)
            //            TestResults.Add(test);
            //    }
            //}
            //foreach(var result in TestResults)
            //{
            //    Console.WriteLine(result);
            //}
            List<int> CensusData = new List<int>(){ 18897109, 12828837, 9461105, 6371773, 
                                                    5965343, 5946800, 5582170, 5564635, 5268860, 
                                                    4552402, 4335391, 4296250, 4224851, 4192887, 
                                                    3439809, 3279833, 3095313, 2812896, 2783243, 
                                                    2710489, 2543482, 2356285, 2226009, 2149127, 
                                                    2142508, 2134411 };

            List<int> Results = new List<int>();
            var Total = 0;
            var testNum = 0;

            while(Total != 100000000)
            {
                Total = 0;
                List<int> results = new List<int>();
                if ((testNum & 0b0000_0000_0000_0000_0000_0000_0001) > 0)
                {
                    Total += CensusData[0];
                    results.Add(CensusData[0]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0000_0000_0010) > 0)
                {
                    Total += CensusData[1];
                    results.Add(CensusData[1]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0000_0000_0100) > 0)
                {
                    Total += CensusData[2];
                    results.Add(CensusData[2]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0000_0000_1000) > 0)
                {
                    Total += CensusData[3];
                    results.Add(CensusData[3]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0000_0001_0000) > 0)
                {
                    Total += CensusData[4];
                    results.Add(CensusData[4]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0000_0010_0000) > 0)
                {
                    Total += CensusData[5];
                    results.Add(CensusData[5]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0000_0100_0000) > 0)
                {
                    Total += CensusData[6];
                    results.Add(CensusData[6]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0000_1000_0000) > 0)
                {
                    Total += CensusData[7];
                    results.Add(CensusData[7]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0001_0000_0000) > 0)
                {
                    Total += CensusData[8];
                    results.Add(CensusData[8]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0010_0000_0000) > 0)
                {
                    Total += CensusData[9];
                    results.Add(CensusData[9]);
                }
                if ((testNum & 0b0000_0000_0000_0000_0100_0000_0000) > 0)
                {
                    Total += CensusData[10];
                    results.Add(CensusData[10]);
                }
                if ((testNum & 0b0000_0000_0000_0000_1000_0000_0000) > 0)
                {
                    Total += CensusData[11];
                    results.Add(CensusData[11]);
                }
                if ((testNum & 0b0000_0000_0000_0001_0000_0000_0000) > 0)
                {
                    Total += CensusData[12];
                    results.Add(CensusData[12]);
                }
                if ((testNum & 0b0000_0000_0000_0010_0000_0000_0000) > 0)
                {
                    Total += CensusData[13];
                    results.Add(CensusData[13]);
                }
                if ((testNum & 0b0000_0000_0000_0100_0000_0000_0000) > 0)
                {
                    Total += CensusData[14];
                    results.Add(CensusData[14]);
                }
                if ((testNum & 0b0000_0000_0000_1000_0000_0000_0000) > 0)
                {
                    Total += CensusData[15];
                    results.Add(CensusData[15]);
                }
                if ((testNum & 0b0000_0000_0001_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[16];
                    results.Add(CensusData[16]);
                }
                if ((testNum & 0b0000_0000_0010_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[17];
                    results.Add(CensusData[17]);
                }
                if ((testNum & 0b0000_0000_0100_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[18];
                    results.Add(CensusData[18]);
                }
                if ((testNum & 0b0000_0000_1000_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[19];
                    results.Add(CensusData[19]);
                }
                if ((testNum & 0b0000_0001_0000_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[20];
                    results.Add(CensusData[20]);
                }
                if ((testNum & 0b0000_0010_0000_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[21];
                    results.Add(CensusData[21]);
                }
                if ((testNum & 0b0000_0100_0000_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[22];
                    results.Add(CensusData[22]);
                }
                if ((testNum & 0b0000_1000_0000_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[23];
                    results.Add(CensusData[23]);
                }
                if ((testNum & 0b0001_0000_0000_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[24];
                    results.Add(CensusData[24]);
                }
                if ((testNum & 0b0010_0000_0000_0000_0000_0000_0000) > 0)
                {
                    Total += CensusData[25];
                    results.Add(CensusData[25]);
                }

                if (Total == 100000000)
                    foreach (var result in results)
                        Results.Add(result);

                testNum++;

            }
            foreach (var result in Results)
                Console.WriteLine($"{result} ");

            Console.WriteLine($"There are {Results.Count} items.");

        }

        
    }
}
