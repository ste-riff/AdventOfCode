/**************/
/* 2022-12-01 */
/**************/

using System;
using System.Collections;

class Day1
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

    static void Main()
    {
        string path = @"C:\Users\StefanoSavarino\source\repos\AdventOfCode\2022-12-01 input\2022-12-01 input";
        List<Elf> elfs = new List<Elf>();

        int counter = 0;
        int highestCalories = 0;
        int top3Calories = 0;
        elfs.Add(new Elf(counter));
        
        foreach(string line in System.IO.File.ReadLines(path))
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

        for(int i = 0; i < 3; i++)
        {
            top3Calories += sortedElfs[counter].GetTotalCalories();
            counter--;
        }
        // Printout answer part#2
        Console.WriteLine("Total calories top3 elves: " + top3Calories);
        
    }
}