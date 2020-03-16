using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinosaurs
{
   public class Fleet
    {
        //Constructor()
        Robot Robot1 = new Robot();
        Robot Robot2 = new Robot();
        Robot Robot3 = new Robot();

        public List<Robot> robotsFleet;
        public Fleet()
        {
           robotsFleet = new List<Robot>();      
           robotsFleet.Add(Robot1);
           robotsFleet.Add(Robot2);
           robotsFleet.Add(Robot3);
        }




    }



}
