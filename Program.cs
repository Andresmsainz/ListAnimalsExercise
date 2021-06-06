using System;
using System.Collections.Generic;

namespace AnimalsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animals Exercise!");

            Animals tiger = new Animals();
            Animals elephant = new Animals();
            Animals giraffe = new Animals();

            List<Animals> listAnimals = new List<Animals>();
            
            tiger.Name = "Tony The Tiger";
            elephant.Name = "Peanut the Elephant";
            giraffe.Name = "Geoffrey the Giraffe";

            listAnimals.Add(tiger);
            listAnimals.Add(elephant);
            listAnimals.Add(giraffe);

            foreach (var item in listAnimals)
            {
                item.SayHi();
                item.Feed();
            }
        }
    }

    class Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine(Name + " is saying hello!");
        }

        public void Feed()
        {
            Console.WriteLine(Name + " is being fed!");
        }

    }
}
