using System;
using System.Collections.Generic;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.width = 3152;
            FiveOneTwoEigth.depth = 6217;
            FiveOneTwoEigth.stories = 5;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Mr. Moneybucks");


            Building TwoThirteenUnion = new Building("213 Union Street");
            TwoThirteenUnion.width = 339;
            TwoThirteenUnion.depth = 244;
            TwoThirteenUnion.stories = 40;
            TwoThirteenUnion.Construct();
            TwoThirteenUnion.Purchase("Dr. Elizabeth Smith");

            Building FiveHundredChurch = new Building("500 Church Street");
            FiveHundredChurch.width = 414;
            FiveHundredChurch.depth = 501;
            FiveHundredChurch.stories = 87;
            FiveHundredChurch.Construct();
            FiveHundredChurch.Purchase("The Simmons Trust Company");

            City megalopolis = new City("megalopolis", "mr. rogers", 1806);
            megalopolis.addBuilding(FiveOneTwoEigth);
            megalopolis.addBuilding(TwoThirteenUnion);
            megalopolis.addBuilding(FiveHundredChurch);

            foreach (Building building in megalopolis.Buildings)
            {
                building.Print();
            }
        }
    }
}
