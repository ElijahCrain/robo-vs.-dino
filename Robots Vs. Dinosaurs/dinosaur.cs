using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs.Dinosaurs
{
	class Dinosaur
	{
		//member verables
		//, I want a Dinosaur to have a type, health, energy, and attack power
		public string dinotype;
		public int health;
		public double energy;
		public double attackPower;


		//constructor
		public Dinosaur (string kind, int health, double dinoEnergy, double dinoAttackPower)
		{
			dinotype = kind;
			this.health = health;
			energy = dinoEnergy;
			attackPower = dinoAttackPower;
		}

		//member method
	}
}
