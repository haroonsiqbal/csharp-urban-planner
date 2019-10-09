using System;
using System.Collections.Generic;

namespace urban_planner {
    public class City {
        
        public List<Building> Buildings {get; set;}
        public City (string name1, string mayor1, int established1) {
            Buildings = new List<Building>();
            
            Console.WriteLine($"City: {name1}");
            Console.WriteLine($"Mayor: {mayor1}");
            Console.WriteLine($"Established: {established1}");
        }
        public string name {get; set;}
        public string mayor {get; set;}

        public int established {get; set;}


        public void addBuilding(Building taco) {
            Buildings.Add(taco);

        }
    }
}