using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
    public class Robot
    {
        //Member Variables
        public string name;
        public int health;
        public int powerlevel;
        //public string Weapon;
        public string attackpower;


        //Constarutor
        public Robot()
        {
            name = "Roby";
            health = 100;
            powerlevel = 5;
            //Weapon = "Sword" ;
            attackpower = "strike hard";
        }
            // member method check health and power level and after attack and print to console.
            public void RobotAttack(Robot robot, Dinosaur dinosaur)

            {
                dinosaur.health = dinosaur.health- robot.powerlevel;
                dinosaur.energy--;
                dinosaur.attackpower--;






            }            













































    }
            

           


           


            











       

        
    
}
