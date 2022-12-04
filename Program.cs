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
        private ArrayList food_calories;
        private int total_calories = 0;

        //Empty constructor
        public Elf()
        {
            this.id = 0;
            this.food_calories = new ArrayList();
            this.total_calories = 0;
        }

        //Contructor
        public Elf(int id)
        {
            this.id = id;
            this.food_calories = new ArrayList();
            this.total_calories = 0;
        }
    }

    static void Main()
    {
        string path = @"C:\Users\StefanoSavarino\source\repos\AdventOfCode\2022-12-01 input\2022-12-01 input";
        ArrayList elfs = new ArrayList();

        int counter = 0;
        elfs.Add(new Elf(counter));
        
        foreach(string line in System.IO.File.ReadLines(path))
        {
            if (line == "")
            {
                counter++;
                elfs.Add(new Elf(counter));
                Console.WriteLine("counter = " + counter);
            }
            else
            {
                
                Console.WriteLine(line);
            }
        }
            
    }
}