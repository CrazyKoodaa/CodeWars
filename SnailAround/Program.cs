using System;
using System.Collections.Generic;
using System.Linq;

namespace SnailSolution
{
    internal class Program

    {
        public class SnailSolution
        {
            #region MyLongSolution
            /*
            public enum direction
            {
                right,
                down,
                left,
                up,
            }
            
            static int marginLeft = 0, marginTop = 0, marginRight = 0, marginBottom = 0;

            static int howManyX = 0;
            static int howManyY = 0;
            static int posX = 0;
            static int posY = 0;
            static List<int> resultList = new List<int>();
            static int[][] grid;

            //static int howManyFields = 0;
            static int howManyFieldsLeft = 0;

            public static void goDirection(direction dir)
            {
                if (dir == direction.right)
                {
                    for (int i = 0; i < howManyX - marginRight; i++)
                    {
                        resultList.Add(grid[posY][posX]);
                        howManyFieldsLeft--;
                        posX++;

                    }
                    marginTop--;
                    posY++;
                    posX--;
                }
                else if (dir == direction.down)
                {
                    for (int i = posY; i < howManyY - marginBottom; i++)
                    {
                        resultList.Add(grid[posY][posX]);
                        howManyFieldsLeft--;
                        posY++;
                    }
                    marginRight++;
                    marginRight++;
                    posX--;
                    posY--;
                }
                else if (dir == direction.left)
                {
                    for (int i = posX; i >= howManyX - marginLeft; i--)
                    {
                        resultList.Add(grid[posY][posX]);
                        howManyFieldsLeft--;
                        posX--;
                    }
                    marginLeft--;
                    posY--;
                    posX++;
                }
                else if (dir == direction.up)
                {
                    for (int i = posY; i >= howManyY - marginTop; i--)
                    {
                        resultList.Add(grid[posY][posX]);
                        howManyFieldsLeft--;
                        posY--;
                    }
                    marginBottom++;
                    posY++;
                    posX++;
                }
            
            }*/
            #endregion

            public static int[] Snail(int[][] array)
            {
                // enjoy
                
                #region MySolution
                /*
                howManyX = array[0].Length;
                howManyY = array[1].Length;
                marginLeft = howManyX;
                marginTop = howManyY;
                if (howManyX == 0 && howManyX == 0) return new int[0];

                grid = array;

                //howManyFields = array.Length;
                howManyFieldsLeft = howManyX * howManyY;


                int dir = 0;

                while (howManyFieldsLeft != 0)
                {
                    goDirection((direction)dir++);
                    if (dir == 4) dir = 0;
                }




                int[] result = resultList.ToArray();
                foreach (int i in result)
                    Console.WriteLine(i);
                return result;
                */
                #endregion MySolution

                #region MrSteboSolution
                /*
                // My Solution worked perfectly in my VS2022 within the timelimit of 12 seconds
                // don't know why this doesn't work here..
                // Kudos to MrStebo for the LINQ Version. It tool a while to understand it, 
                // but it's really genius. Taking the outer ring, then leave the inner ring as it is
                // and then recurse for the inner part so it acts like if it where the "whole" thing
                // I'll will keep this in my CheatSheat. We just can get better!

                var outside = new int[][]
                {
                    // top (left to right)
                    array[0],
                    // right (top to bottom)
                    array.Skip(1).Take(array.Length - 2).Select(x => x[x.Length - 1]).ToArray(),
                    // bottom (right to left)
                    array.Length > 1 ? array.Last().Reverse().ToArray() : new int[] {},
                    // left (bottom to top)
                    array.Skip(1).Take(array.Length - 2).Reverse().Select(x => x[0]).ToArray()
                };

                // Get the inside to recursively pass back into this Snail method
                var inside = array
                  .Skip(1)
                  .Take(array.Length - 2)
                  .Select(x => x.Skip(1).Take(x.Length - 2).ToArray())
                  .ToArray();

                // Return a flattened array
                return outside
                  .SelectMany(x => x)
                  .Concat(inside.Length > 0 ? Snail(inside) : new int[] { })
                  .ToArray();
                */
                #endregion 


                #region NoThanksssSolution
                if(array[0].Length == 0)return new int[0];
                List<int> list = new List<int>();
                for (int i = 0 , z = array.Length - 1; i <= z; i++, z--)
                {
                    for (int j = i; j <= z; j++)
                    {
                        list.Add(array[i][j]);
                    }

                    for (int j = i+1; j <= z; j++)
                    {
                        list.Add(array[j][z]);
                    }

                    for (int j = z-1; j >= i ; j--)
                    {
                        list.Add(array[z][j]);
                    }
                    for (int j = z - 1; j > i; j--)
                    {
                        list.Add(array[j][i]);
                    }
                }

                return list.ToArray();


                #endregion

        }

    }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] array =
            {
                new []{1, 2, 3, 4, 5},
                new []{6, 7, 8, 9, 10},
                new []{11, 12, 13, 14, 15 },
                new []{16, 17, 18, 19, 20},
                new []{21, 22, 23, 24, 25},
            };

            int[][] array2 =
            {
                new [] {685,414,519,247,574,949,631,717,154,307,201,955,9,11,3,186,763,772,320,824,947},
                new [] {712,494,359,39,80,744,271,492,107,447,598,77,430,684,174,734,252,906,512,523,56},
                new [] {246,488,2,246,972,762,74,786,597,763,636,534,730,973,920,161,209,494,205,360,226},
                new [] {246,488,2,246,972,762,74,786,597,763,636,534,730,973,920,161,209,494,205,360,226},
                new [] {47,861,604,878,579,327,830,452,511,866,809,302,891,467,6,358,793,109,983,198,706},
                new [] {510,685,962,543,701,711,254,574,43,413,307,163,831,199,627,398,368,393,435,244,334},
                new [] {87,897,828,232,839,507,914,804,417,386,223,163,520,537,177,642,336,879,617,577,879},
                new [] {468,454,502,140,61,268,379,960,425,716,548,954,373,424,788,135,311,862,204,340,771},
                new [] {627,27,84,1000,311,663,451,757,33,515,819,668,456,619,443,326,93,779,240,535,844},
                new [] {992,670,675,209,148,113,389,507,25,17,413,237,108,841,427,419,140,750,606,929,203},
                new [] {392,201,730,287,918,806,345,810,219,84,965,805,927,635,358,409,791,163,550,62,250},
                new [] {9,499,406,431,348,778,17,907,953,29,634,607,641,601,469,946,923,231,308,45,698 } ,
                new [] {807,934,449,432,182,207,70,10,349,588,57,867,954,384,703,325,856,570,28,329,903},
                new [] {266,55,331,199,286,35,889,464,869,933,242,18,552,202,566,958,1000,167,572,948,898},
                new [] {604,442,578,740,688,217,767,621,67,661,281,716,796,541,879,118,234,896,172,181,546},
                new [] {481,655,815,850,402,182,138,367,857,403,456,382,5,662,613,754,459,599,819,123,843},
                new [] {802,272,962,302,757,662,687,841,767,272,400,767,353,124,788,764,891,286,35,630,255},
                new [] {211,258,825,335,791,880,266,365,775,298,354,59,703,679,383,854,548,646,521,451,527},
                new [] {90,132,57,615,653,539,826,991,569,313,784,494,589,592,15,137,968,966,782,421,476},
                new [] {993,974,47,709,650,445,405,910,344,640,515,179,728,121,126,769,720,138,342,441,375},
                new [] {206, 985, 571, 566, 115, 87, 369, 718, 580, 680, 739, 31, 51, 98, 159, 11, 907, 4, 94, 422, 81 },
                new [] {226,673,269,315,862,472,889,369,248,828,441,981,102,787,990,476,143,536,359,37,193},
            };

            var r2 = new[] { 685, 414, 519, 247, 574, 949, 631, 717, 154, 307, 201, 955, 9, 11, 3, 186, 763, 772, 320, 824, 947, 56, 226, 706, 334, 879, 771, 844, 203, 250, 698, 903, 898, 546, 843, 255, 527, 476, 375, 81, 193, 37, 359, 536, 143, 476, 990, 787, 102, 981, 441, 828, 248, 369, 889, 472, 862, 315, 269, 673, 226, 206, 993, 90, 211, 802, 481, 604, 266, 807, 9, 392, 992, 627, 468, 87, 510, 47, 246, 712, 494, 359, 39, 80, 744, 271, 492, 107, 447, 598, 77, 430, 684, 174, 734, 252, 906, 512, 523, 360, 198, 244, 577, 340, 535, 929, 62, 45, 329, 948, 181, 123, 630, 451, 421, 441, 422, 94, 4, 907, 11, 159, 98, 51, 31, 739, 680, 580, 718, 369, 87, 115, 566, 571, 985, 974, 132, 258, 272, 655, 442, 55, 934, 499, 201, 670, 27, 454, 897, 685, 861, 488, 2, 246, 972, 762, 74, 786, 597, 763, 636, 534, 730, 973, 920, 161, 209, 494, 205, 983, 435, 617, 204, 240, 606, 550, 308, 28, 572, 172, 819, 35, 521, 782, 342, 138, 720, 769, 126, 121, 728, 179, 515, 640, 344, 910, 405, 445, 650, 709, 47, 57, 825, 962, 815, 578, 331, 449, 406, 730, 675, 84, 502, 828, 962, 604, 878, 579, 327, 830, 452, 511, 866, 809, 302, 891, 467, 6, 358, 793, 109, 393, 879, 862, 779, 750, 163, 231, 570, 167, 896, 599, 286, 646, 966, 968, 137, 15, 592, 589, 494, 784, 313, 569, 991, 826, 539, 653, 615, 335, 302, 850, 740, 199, 432, 431, 287, 209, 1000, 140, 232, 543, 701, 711, 254, 574, 43, 413, 307, 163, 831, 199, 627, 398, 368, 336, 311, 93, 140, 791, 923, 856, 1000, 234, 459, 891, 548, 854, 383, 679, 703, 59, 354, 298, 775, 365, 266, 880, 791, 757, 402, 688, 286, 182, 348, 918, 148, 311, 61, 839, 507, 914, 804, 417, 386, 223, 163, 520, 537, 177, 642, 135, 326, 419, 409, 946, 325, 958, 118, 754, 764, 788, 124, 353, 767, 400, 272, 767, 841, 687, 662, 182, 217, 35, 207, 778, 806, 113, 663, 268, 379, 960, 425, 716, 548, 954, 373, 424, 788, 443, 427, 358, 469, 703, 566, 879, 613, 662, 5, 382, 456, 403, 857, 367, 138, 767, 889, 70, 17, 345, 389, 451, 757, 33, 515, 819, 668, 456, 619, 841, 635, 601, 384, 202, 541, 796, 716, 281, 661, 67, 621, 464, 10, 907, 810, 507, 25, 17, 413, 237, 108, 927, 641, 954, 552, 18, 242, 933, 869, 349, 953, 219, 84, 965, 805, 607, 867, 57, 588, 29, 634 };

            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            //var result2 = SnailSolution.Snail(array2);
            //foreach (var item in result2)
            //    Console.Write(item + " ");
            var result1 = SnailSolution.Snail(array);
            foreach (var item in result1)
                Console.Write(item + " ");
        }
    }
} 
