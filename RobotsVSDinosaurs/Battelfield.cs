using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    public class Battelfield
    {

        public Herd herdOfDinos;
        public Fleet fleetOfRobots;
        //member methods
        public Battelfield()
        {
            herdOfDinos = new Herd();
            fleetOfRobots = new Fleet();
        }



        public void SimulateBattle()
        {
            herdOfDinos.dinosaursHerd[0].DinoAttack(herdOfDinos.dinosaursHerd[0], fleetOfRobots.robotsFleet[0]);
        }

      //  public void ("robotHealth,dinosaur.Health");
      //{

      // }




    }
}