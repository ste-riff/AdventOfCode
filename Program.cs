/**************/
/* 2022-12-01 */
/**************/

using System;
using System.Collections;

class AdventOfCode
{
    class Elf
    {
        private int id = 0;
        private List<int> food_calories;
        private int total_calories = 0;

        //Empty constructor
        public Elf()
        {
            this.id = 0;
            this.food_calories = new List<int>();
            this.total_calories = 0;
        }

        //Contructor
        public Elf(int id)
        {
            this.id = id;
            this.food_calories = new List<int>();
            this.total_calories = 0;
        }
        
        public void AddItemCalories(int item_calories)
        {
            this.food_calories.Add(item_calories);
            this.total_calories += item_calories;
        }
        
        public int GetTotalCalories()
        {
            return this.total_calories;
        }
    }

    enum RockPaperScissorsPoints
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3,
        Loss = 0,
        Draw = 3,
        Win = 6
    }

    static void Main()
    {

        //Day1();
        Day2();
        
    }

    static void Day1()
    {
        string day1Path = @"C:\Users\StefanoSavarino\source\repos\AdventOfCode\2022-12-01 input\2022-12-01 input";
        List<Elf> elfs = new List<Elf>();

        int counter = 0;
        int highestCalories = 0;
        int top3Calories = 0;
        elfs.Add(new Elf(counter));

        foreach (string line in System.IO.File.ReadLines(day1Path))
        {
            if (line == "")
            {
                counter++;
                elfs.Add(new Elf(counter));
            }
            else
            {
                elfs[counter].AddItemCalories(Int32.Parse(line));
            }
        }

        foreach (Elf el in elfs)
        {
            if (el.GetTotalCalories() > highestCalories)
                highestCalories = el.GetTotalCalories();
        }
        // Printout answer part#1
        Console.WriteLine("Highest calories count: " + highestCalories);

        List<Elf> sortedElfs = elfs.OrderBy(el => el.GetTotalCalories()).ToList();

        for (int i = 0; i < 3; i++)
        {
            top3Calories += sortedElfs[counter].GetTotalCalories();
            counter--;
        }
        // Printout answer part#2
        Console.WriteLine("Total calories top3 elves: " + top3Calories);
    }

    static void Day2()
    {
        string day2Path = @"C:\Users\StefanoSavarino\source\repos\AdventOfCode\2022-12-02 input\input.txt";
        int counter = 0;
        int totalPoints = 0;

        foreach(string line in System.IO.File.ReadLines(day2Path))
        {
            int first, second;
            string [] round = line.Split(new[] {' '});
            // Console.WriteLine("Round " + counter + " - elf: " + round[0] + ", you: " + round[1]);
            counter++;

            if (round[0] == "A")
            {
                if (round[1] == "X")
                {
                    totalPoints += (int) RockPaperScissorsPoints.Draw;
                    totalPoints += (int) RockPaperScissorsPoints.Rock;
                } else if (round[1] == "Y")
                {
                    totalPoints += (int) RockPaperScissorsPoints.Win;
                    totalPoints += (int) RockPaperScissorsPoints.Paper;
                } else if (round[1] == "Z")
                {
                    totalPoints += (int) RockPaperScissorsPoints.Loss;
                    totalPoints += (int) RockPaperScissorsPoints.Scissors;
                }
            } else if (round[0] == "B")
            {
                if (round[1] == "X")
                {
                    totalPoints += (int)RockPaperScissorsPoints.Loss;
                    totalPoints += (int)RockPaperScissorsPoints.Rock;
                }
                else if (round[1] == "Y")
                {
                    totalPoints += (int)RockPaperScissorsPoints.Draw;
                    totalPoints += (int)RockPaperScissorsPoints.Paper;
                }
                else if (round[1] == "Z")
                {
                    totalPoints += (int)RockPaperScissorsPoints.Win;
                    totalPoints += (int)RockPaperScissorsPoints.Scissors;
                }
            } else if (round[0] == "C")
            {
                if (round[1] == "X")
                {
                    totalPoints += (int)RockPaperScissorsPoints.Win;
                    totalPoints += (int)RockPaperScissorsPoints.Rock;
                }
                else if (round[1] == "Y")
                {
                    totalPoints += (int)RockPaperScissorsPoints.Loss;
                    totalPoints += (int)RockPaperScissorsPoints.Paper;
                }
                else if (round[1] == "Z")
                {
                    totalPoints += (int)RockPaperScissorsPoints.Draw;
                    totalPoints += (int)RockPaperScissorsPoints.Scissors;
                }
            }
        }
        Console.WriteLine("Final result: " + totalPoints);
    }
}