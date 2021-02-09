using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs.Dinosaurs
{
	class Herd
	{
		//member verables
		public List<Dinosaur> dinosaurs = new List<Dinosaur>();

		//constructor
		public Herd()
		{
			Dinosaur dinosaurOne = new Dinosaur("TRex", 100, 100, 30);
			Dinosaur dinosaurTwo = new Dinosaur("allosaurus", 100, 100, 25);
			Dinosaur dinosaurThree = new Dinosaur("raptor", 100, 100, 20);

			dinosaurs.Add(dinosaurOne);
			dinosaurs.Add(dinosaurTwo);
			dinosaurs.Add(dinosaurThree);
		}

		//member method
	}
}
