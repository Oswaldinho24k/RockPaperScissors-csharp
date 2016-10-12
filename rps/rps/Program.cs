using System;

namespace rps
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string exit;
			do{
				
				Console.WriteLine ("Rock, Paper, Scissors...Pick your choice ");
				//Choose the option
				Console.WriteLine ("1(Rock), 2(Paper), 3(Scissors) ");
				int rock = 1;
				int paper = 2;
				int scissors = 3;
				int choice = Convert.ToInt32( Console.ReadLine ());

				if (choice == rock) {
					Console.WriteLine ("You chose Rock");
				}
				else if (choice == paper) {
					Console.WriteLine ("You chose Paper");
				}
				else if (choice == scissors) {
					Console.WriteLine ("You chose Scissors");
				}
				//Pc choice
				Random rnd = new Random();
				int pc = rnd.Next(1, 4);
				if (pc == rock) {
					Console.WriteLine ("PC chose Rock");
				}
				else if (pc == paper) {
					Console.WriteLine ("PC chose Paper");
				}
				else if (pc == scissors) {
					Console.WriteLine ("PC chose Scissors");
				}
				//The fight
				if(choice==pc){
					Console.WriteLine ("///It's a TIE///");
				}
				else if(choice==rock && pc==paper){
					Console.WriteLine ("###YOU LOSE###");
				}
				else if(choice==rock && pc==scissors){
					Console.WriteLine ("¡¡¡YOU WIN!!!");
				}
				else if(choice==paper && pc==rock){
					Console.WriteLine ("¡¡¡YOU WIN!!!");
				}
				else if(choice==paper && pc==scissors){
					Console.WriteLine ("###YOU LOSE###");
				}
				else if(choice==scissors && pc==rock){
					Console.WriteLine ("###YOU LOSE###");
				}
				else if(choice==scissors && pc==paper){
					Console.WriteLine ("¡¡¡YOU WIN!!!");
				}

				//Break out then game
				Console.WriteLine ("---Exit???  yes/no---");
				exit = Console.ReadLine ();
			}

			while(exit != "yes");

		}
	}
}
