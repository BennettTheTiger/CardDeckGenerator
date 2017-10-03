using System;
namespace schoonermanPrj2
{
	public class Deck
	{
		//field
		private Card[] myCards;
		private Random randomizer;

		//constructor
		public Deck(Random randomizer)
		{
			myCards = new Card[52];
			this.randomizer = randomizer;

			for (int i = 0; i < 52; i++)
			{

				if (i < 13)
				{
					myCards[i] = new Card((i % 13), "Spades");
				}
				else if (13 <= i && i <26)
				{
					myCards[i] = new Card((i % 13), "Hearts");
				}
				else if (26 <= i && i < 39)
				{
					myCards[i] = new Card((i % 13), "Clubs");
				}
				else if (39 <= i && i < 52)
				{
					myCards[i] = new Card((i % 13), "Diamonds");
				}
			}//end of card initalizer

		}
		/// <summary>
		/// Prints out every card in the deck
		/// </summary>
		public void PrintDeck()
		{
			Console.WriteLine("Here are all the possible cards:");
			foreach (Card someCard in myCards)
			{
				someCard.PrintCard();
			}
			Console.WriteLine();
		}
		/// <summary>
		/// Deal the specified cardNum.
		/// </summary>
		/// <returns>The deal.</returns>
		/// <param name="cardNum">Number of cards to deal.</param>
		/// <param name="handNum">Number of hands to deal. </param>
		public void Deal(int handNum, int cardNum)
		{
			Console.WriteLine("You would like me to deal " + cardNum + " cards per hand");


			for (int n = 0; n < handNum; n++)
			{
				Console.WriteLine("Hand " + (n+1) + " consists of:");
				//deal the cards to this hand
				for (int i = 0; i < cardNum; i++)
				{

					int randomIndex = randomizer.Next(52);

					//if the card generaged is picked look for one that is not 
					if (myCards[randomIndex].Picked)
					{
						while (myCards[randomIndex].Picked)
						{
							randomIndex = randomizer.Next(52);
						}
					}

					myCards[randomIndex].PrintCard();// prints the card
					myCards[randomIndex].PickCard();// makes the card not able to be picked again
				}//end card deal
				Console.WriteLine();
			}//end hand
		}
	
	}

}
