using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs.Dinosaurs
{
	class Battlefield
	{

		//member verables
		public int robotsScore;
		public int dinoScore;
		public Fleet fleet;
		public Herd herd;


		//constructor
		public Battlefield()
		{
			robotsScore = 0;
			dinoScore = 0;
			fleet = new Fleet();
			herd = new Herd();

		}

		//member method

		//foreach 



		public void RunBattle()
		{
			//Use a for loop to allow multiple attacks
			Console.WriteLine(fleet.robots[0].name);
			
			for (int i = 0; i < herd.dinosaurs.Count; i++)
			{
				fleet.robots[i].RobotAttack(herd.dinosaurs[i]);
				if (herd.dinosaurs[i].health <= 0)
				{
					Console.WriteLine($"{fleet.robots[i].name} has defeted {herd.dinosaurs[i].dinotype}");
					robotsScore++;
				}


			}
		
			for (int i = 0; i < fleet.robots.Count; i++)
			{
				herd.dinosaurs[i].DinoAttack(fleet.robots[i]);
				if (fleet.robots[i].health <= 0)
				{ 
					Console.WriteLine($"{herd.dinosaurs[i].dinotype} has defeted {fleet.robots[i].name}");
					dinoScore++;
					DisplayWinner();
				}
			}
			Console.ReadLine();
		}

		public void CheckDinoHealth()
		{

		}

		public void CheckRobotHealth()
		{

		}

		public void DisplayWinner()
		{


			if (dinoScore > robotsScore )
			{
				Console.WriteLine("Dinosaur's won this game");
			}
			else
			{
				Console.WriteLine("Robot's won this game");
			}
		}

		


	}
}
