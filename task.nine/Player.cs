using System;
namespace task.nine
{
	public class Player
	{
		public string name;
		public int age;
		public int intelligence; 
		public int sportiness;
		public string gender;
		public int power;

		public Player(string name, int age, int intelligence, int sportiness, string gender, int power)
		{
			this.name = name;
			this.age = age;
			this.intelligence = intelligence;
			this.sportiness = sportiness;
			this.gender = gender;
			this.power = power;
		}
	}
}

