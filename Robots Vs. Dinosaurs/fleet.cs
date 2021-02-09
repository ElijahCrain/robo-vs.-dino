using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs.Dinosaurs
{
	class Fleet
	{
		//member verables
		public List<Robot> robots = new List<Robot>();

		//constructor
		public Fleet()
		{
			Robot robotOne = new Robot("bob", 100, 100);
			Robot robotTwo = new Robot("tom", 100, 100);
			Robot robotThree = new Robot("josh", 100, 100);

			robots.Add(robotOne);
			robots.Add(robotTwo);
			robots.Add(robotThree);

		}

		
		//member method
	}
}
