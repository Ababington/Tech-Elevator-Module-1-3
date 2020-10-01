﻿using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
            Cow Bessie = new Cow();
            Chicken RhodeIsland = new Chicken();
            FarmAnimal George = new Sheep("George", "Baa");
            Jersey Jeff = new Jersey();

            Console.WriteLine(((Sheep)George).Shear());
            RhodeIsland.LayEgg();
            List<FarmAnimal> farmAnimals = new List<FarmAnimal>();
            farmAnimals.Add(Bessie);
            farmAnimals.Add(RhodeIsland);
            farmAnimals.Add(George);
            farmAnimals.Add(Jeff);
            foreach(FarmAnimal critter in farmAnimals)
            {
                // checks to see if the current critter is of type chicken
                if(critter.GetType() == typeof(Chicken))
                {
                    ((Chicken)critter).LayEgg();
                }
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + critter.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + critter.Sound + " " + critter.Sound + " here");
                Console.WriteLine("And a " + critter.Sound + " " + critter.Sound + " there");
                Console.WriteLine("Here a " + critter.Sound + " there a " + critter.Sound + " everywhere a " + critter.Sound + " " + critter.Sound);
                Console.WriteLine();
            }
            ///// Using Interfaces
            ///
            Tracker JD = new Tracker();

            List<ISingable> singables = new List<ISingable>();
            singables.Add(JD);
            singables.AddRange(farmAnimals);
            foreach (ISingable singable in singables)
            {
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + singable.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + singable.Sound + " " + singable.Sound + " here");
                Console.WriteLine("And a " + singable.Sound + " " + singable.Sound + " there");
                Console.WriteLine("Here a " + singable.Sound + " there a " + singable.Sound + " everywhere a " + singable.Name + " " + singable.Sound);
                Console.WriteLine();
            }

            Apple apple = new Apple();
            List<ISellable> sellables = new List<ISellable>();
            sellables.Add(apple);
            sellables.Add(RhodeIsland);
            foreach (ISellable sellable in sellables)
            {
               
                Console.WriteLine(sellable.ToString());
            }


        }
    }
}