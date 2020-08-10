using System;
using System.Collections.Generic;
using System.Linq;

namespace StarTrekProgram
{
    class Program
    {
        // Fields
        // 10800 possible names + 150 short name possibilities
        static List<string> vulcanMaleNames = new List<string>();
        // 90 possible names
        static List<string> vulcanFemaleNames = new List<string>();

        static string vulcanGenderList;


        static void Main()
        {
            Console.WriteLine("Velkommen til Star Trek navne programmet.");
            GetUserInput();
        }

        /// <summary>
        /// Prints the names for the Vulcans
        /// </summary>
        static void PrintNames()
        {
            int counter = 1;
            if(vulcanGenderList == "male")
            {
                foreach(string i in vulcanMaleNames)
                {
                    Console.WriteLine(counter + " " + i);
                    counter++;
                }
            }

            else if(vulcanGenderList == "female")
            {
                counter = 1;
                foreach(string i in vulcanFemaleNames)
                {
                    Console.WriteLine(counter + " " + i);
                    counter++;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        /// <summary>
        /// Generates vulcan names
        /// 11040 possible names total
        /// </summary>
        static void GenerateNames()
        {
            if(vulcanGenderList == "male")
            {
                // First set of arrays for name combinations 
                string[] firstArray = { "S", "Sp", "Sk", "St", "T" };
                string[] secondArray = { "a", "e", "i", "o", "u", "y" };
                string[] thirdArray = { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
                string[] fourthArray = { "a", "e", "i", "o", "u", "y" };
                string[] fifthArray = { "q", "p", "k", "ck", "l" };

                // Second set of arrays for name combinations 
                string[] sixthArray = { "S", "Sp", "Sk", "St", "T" };
                string[] seventhArray = { "a", "e", "i", "o", "u", "y" };
                string[] eighthArray = { "q", "p", "k", "ck", "l" };


                // Loop until first set of combinations have been made
                while(vulcanMaleNames.Count != 10800)
                {
                    Random firstRndNum = new Random();
                    int firstNumber = firstRndNum.Next(0, firstArray.Length);

                    Random secondRndNum = new Random();
                    int secondNumber = secondRndNum.Next(0, secondArray.Length);

                    Random thirdRndNum = new Random();
                    int thirdNumber = thirdRndNum.Next(0, thirdArray.Length);

                    Random fourthRndNum = new Random();
                    int fourthNumber = fourthRndNum.Next(0, fourthArray.Length);

                    Random fifthRndNum = new Random();
                    int fifthNumber = fifthRndNum.Next(0, fifthArray.Length);

                    // Combine strings
                    string maleName = firstArray[firstNumber] + secondArray[secondNumber] + thirdArray[thirdNumber] + fourthArray[fourthNumber] + fifthArray[fifthNumber];

                    // Only add if not already added to the list
                    if(!vulcanMaleNames.Contains(maleName))
                    {
                        vulcanMaleNames.Add(maleName);
                    }
                }

                // Loop until second set of combinations have been created
                while(vulcanMaleNames.Count != 10950)
                {
                    Random sixthRndNum = new Random();
                    int sixthNumber = sixthRndNum.Next(0, sixthArray.Length);

                    Random seventhRndNum = new Random();
                    int seventhNumber = seventhRndNum.Next(0, seventhArray.Length);

                    Random eighthRndNum = new Random();
                    int eighthNumber = eighthRndNum.Next(0, eighthArray.Length);

                    // Combine strings
                    string maleName = sixthArray[sixthNumber] + seventhArray[seventhNumber] + eighthArray[eighthNumber];

                    // Only add if not already added to the list
                    if(!vulcanMaleNames.Contains(maleName))
                    {
                        vulcanMaleNames.Add(maleName);
                    }
                }
                PrintNames();
            }

            else if(vulcanGenderList == "female")
            {

                // Arrays for name combinations
                string[] firstArray = { "T’" };
                string[] secondArray = { "P", "K", "Q" };
                string[] thirdArray = { "a", "e", "i", "o", "u", "y" };
                string[] fourthArray = { "r", "j", "’p", "k", "l" };


                // Loop untill all combinations have been made
                while(vulcanFemaleNames.Count != 90)
                {
                    Random firstRndNum = new Random();
                    int firstNumber = firstRndNum.Next(0, firstArray.Length);

                    Random secondRndNum = new Random();
                    int secondNumber = secondRndNum.Next(0, secondArray.Length);

                    Random thirdRndNum = new Random();
                    int thirdNumber = thirdRndNum.Next(0, thirdArray.Length);

                    Random fourthRndNum = new Random();
                    int fourthNumber = fourthRndNum.Next(0, fourthArray.Length);

                    // Combine strings
                    string femaleName = firstArray[firstNumber] + secondArray[secondNumber] + thirdArray[thirdNumber] + fourthArray[fourthNumber];

                    // Only add if not already added to the list
                    if(!vulcanFemaleNames.Contains(femaleName))
                    {
                        vulcanFemaleNames.Add(femaleName);
                    }
                }
                PrintNames();
            }
        }

        /// <summary>
        /// Gets user input
        /// </summary>
        static void GetUserInput()
        {
            Console.WriteLine("1. Generer samtlige Vulcan hankøns navne.\n" +
                "2. Generer Vulcan hunkøns navne.");
            string nameVulcanGender = Console.ReadLine();

            if(nameVulcanGender == "1")
            {
                vulcanGenderList = "male";
            }
            else if(nameVulcanGender == "2")
            {
                vulcanGenderList = "female";
            }
            else
            {
                Console.WriteLine("Fejl, du indtastede ikke et gyldigt tal.");
                GetUserInput();
            }

            GenerateNames();
        }
    }
}