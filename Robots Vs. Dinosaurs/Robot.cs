using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs.Dinosaurs
{
	class Robot
	{
		//member verables
		//I want a Robot to have a name, health, power level, and a Weapon with a type (i.e. sword) and attack power.
		public string name;
		public int health;
		public int powerLevel;
		public string weapon;
		public double attackPower;

		//constructor
		public Robot(string name, int health, int powerLevel,string weapon, double robotAttackPower)
		{
			this.name = name;
			this.health = health;
			this.powerLevel = powerLevel;
			this.weapon = weapon;
			attackPower = robotAttackPower;
		}


		//member method
		public void RobotAttack(Dinosaur dinosaur)
		{

		}


	}
}
