using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Join strings
            string[] word = new string[10] { "asd", "sd", "ds", "as", "ds", "sa", "sad", "asd", "we", "asd" };
            string all = string.Join(" ", word);
            Console.WriteLine(all);
            #endregion

            #region dimension arrays And Multi Table
            int[,] demarray = new int[10, 10];
            

            for (int i = 0; i < demarray.GetLength(0); i++)
            {
                for (int j = 0; j < demarray.GetLength(1); j++)
                {

                    demarray[i, j] = ((i + 1) * (j+ 1));
                    
                    Console.Write($"\t{demarray[i, j]}");
                   
                }
                Console.WriteLine();
                
            }
            #endregion

            #region Jagged Array

            int[][] intjagarr  = new int [4][];
            intjagarr[0] = new int[4];
            intjagarr[1] = new int[1];
            intjagarr[2] = new int[5];
            intjagarr[4] = new int[25];
            string[][] strjagarr = new string[5][];
            strjagarr[0] = new string[5] { "fuck", "you", "mate", "imma", "troll" };
            strjagarr[1] = new string[4] { "yo", "yo", "my", "nigga" };

            #endregion

            #region functions

            Array.Sort(word); // sort number from the smallest to the biggest by default and strings by alphabetic order
            word.GetLength(0); // set number equal to the length of the array in a specific dimension

            char[,,,] chardim = new char[2,3,4,1]; // return amount of dimensions in an array
            Console.WriteLine(chardim.Rank);
            
            double[] DBarry = { 1.2, 3.5, 12.4 };

            int index = Array.IndexOf(DBarry, 1.2); // indexof return the location in  the array with the requested value
            int index2 = Array.IndexOf(DBarry, 5); // return -1 if doesnt exist

            #endregion 
        }
    }
}
