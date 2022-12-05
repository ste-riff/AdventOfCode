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
        int highest_calories = 0;
        elfs.Add(new Elf(counter));
        
        foreach(string line in System.IO.File.ReadLines(path))
        {
            if (line == "")
            {
                Console.WriteLine("Old Elf total calories: " + elfs[counter].GetTotalCalories());
                counter++;
                elfs.Add(new Elf(counter));
                Console.WriteLine("counter = " + counter);
            }
            else
            {
                elfs[counter].AddItemCalories(Int32.Parse(line));
                Console.WriteLine(line);
            }
        }
        
        foreach(Elf el in elfs)
        {
            if(el.GetTotalCalories() > highest_calories)
                highest_calories = el.GetTotalCalories();
            Console.WriteLine("Current highest calories count: " + highest_calories);
        }

        Console.WriteLine("highest calories = " + highest_calories);

    }
}