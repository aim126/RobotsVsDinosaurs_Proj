using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    public class Dinosaur
    {
        //Member Variables
        public int health;
        public int energy;
        public int attackpower;


        //Constructor
        public Dinosaur()

        {
            health = 100;
            energy =  5  ;
            attackpower = 5;
       }

        //Member Method
        //display  health  energy  and atack power  after attack ,   print  to consol.
        public void DinoAttack(Dinosaur dinosaur, Robot robot)
        {
            robot.health = robot.health - dinosaur.attackpower;
            robot.powerlevel--;
            dinosaur.energy--;
        }


    }

}
