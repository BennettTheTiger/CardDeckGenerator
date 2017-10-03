using System;
namespace schoonermanPrj2
{
	public class Card
	{
		private int number;
		private string suit;
		private bool picked;

		public Card(int number, string suit)
		{
			this.number = number;
			this.suit = suit;
			picked = false;
		}

		/// <summary>
		/// Prints the card.
		/// </summary>
		public void PrintCard()
		{
			switch (number)
			{
				case 0:
					Console.Write("Ace of ");
					break;
				case 10:
					Console.Write("Jack of ");
					break;
				case 11:
					Console.Write("Queen of ");
					break;
				case 12:
					Console.Write("King of ");
					break;
				default:
					Console.Write("The " + (number + 1) + " of ");
					break;
			}//end of switch
			Console.Write(suit);
			Console.Write("\n");

		}

		//methods and getters to see if the card has been picked 
		public void PickCard()
		{
			picked = true;
		}

		//sets the card to picked
		public bool Picked
		{
			get { return picked; }
		}
	}
}
