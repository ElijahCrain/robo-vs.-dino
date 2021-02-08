using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs.Dinosaurs
{
	class fleet
	{
		//member verables
		List<Robot> robots = new List<Robot>();

		//constructor
		public fleet()
		{
			Robot robotOne = new Robot("bob", 100, 100,"sword", 25);
			Robot robotTwo = new Robot("tom", 100, 100,"sword", 25);
			Robot robotThree = new Robot("josh", 100, 100,"sword", 25);

			robots.Add(robotOne);
			robots.Add(robotTwo);
			robots.Add(robotThree);

		}

		
		//member method
	}
}
