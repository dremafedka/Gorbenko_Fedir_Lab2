using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Planet
    {
        public string NameOfPlanet;

        public void NamePlanet()
        {
            Console.WriteLine($"Name of our Planet: {NameOfPlanet}");
            Console.WriteLine();
        }
        public void CreatePlanet()
        { 
            Continent continent = new Continent();
            continent.Call();
            continent.NameContinents();
            continent.NumberContinents();

            Ocean ocean = new Ocean();
            ocean.Call();
            ocean.NameOceans();
            ocean.NumberOceans();

            Island island = new Island();
            island.Call();

        }

        static void Main(string[] args)
        {
            Planet planet = new Planet();
            planet.NameOfPlanet = "Earth";
            planet.NamePlanet();
            planet.CreatePlanet();
        }
    }

   

}
