using System;

namespace JudgeCircle
{
	class Program
	{

		public static bool JudgeCircle(string moves)
		{

			if(string.IsNullOrEmpty(moves))
				return true;

			Dictionary<char,int> directionCount = new Dictionary<char,int>();

			directionCount.Add('L',0);
			directionCount.Add('R',0);
			directionCount.Add('U',0);
			directionCount.Add('D',0);

			for(int index=0; index<moves.Length; index++)
			{
				directionCount[moves[index]] = directionCount[moves[index]] + 1;
			}

			return      directionCount['U'] == directionCount['D'] 
				&&
				directionCount['L'] == directionCount['R'];

		}
		static void Main(string[] args)
		{
			Console.WriteLine(JudgeCircle("UD"));	
		}
	}
}
