using System;
namespace task.nine
{
	public class Teams
	{
		public List<Player> team;
		public string title;
		public string leader;
		public int score;
		 
		public Teams(List<Player> team, string title, string leader, int score)
		{
			this.team = team;
			this.title = title;
			this.leader = leader;
			this.score = score;
		}
	}
}

