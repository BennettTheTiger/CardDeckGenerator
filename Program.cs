using System;

namespace schoonermanPrj2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Random randomizer = new Random();
			//make the deck
			Deck myDeck = new Deck(randomizer);

			//print all the cards in the deck
			myDeck.PrintDeck();
			Console.WriteLine();

			Console.WriteLine("How many hands would you like me to deal?");
			string handRequest = Console.ReadLine();
			int handNum = -1;
			while (!int.TryParse(handRequest, out handNum) || handNum <= 0 || handNum > 52)
			{
				Console.WriteLine("Invalid Request try again");
				handRequest = Console.ReadLine();
			}//end data validation

			Console.WriteLine("How many card would you like to deal to each hand?" );

			string cardRequest = Console.ReadLine();
			int cardNum = -1;
			//waits for a range from 1 - 52 
			while (!int.TryParse(cardRequest, out cardNum) || cardNum <= 0 || cardNum > (52/handNum)){
				Console.WriteLine("Invalid Request try again");
				cardRequest = Console.ReadLine();
			}//end data validation

			myDeck.Deal(handNum,cardNum);
		}
	}
}
