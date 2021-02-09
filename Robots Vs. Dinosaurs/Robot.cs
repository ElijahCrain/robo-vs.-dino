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
		public Weapon weapon;
		

		//constructor
		public Robot(string name, int health, int powerLevel)
		{
			this.name = name;
			this.health = health;
			this.powerLevel = powerLevel;
			this.weapon = new Weapon("goldSword", 35);
			
		}


		//member method
		public void RobotAttack(Dinosaur dinosaur)
		{
			//Use writelines to describe attack that is happening
			dinosaur.health -= weapon.attackPower;
		}


	}
}
