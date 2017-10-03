Random Card Generator

Author: Bennett Schoonerman
Date 3/1/2017

Introduction:
	
	The random card generator creates a deck of 52 cards. The user is then asked how many hands will need to be dealt. Then how many cards to each hand. Then the program randomly generates the desired number of cards to the number of hands playing.


Requirements:

	This program requires an IDE to run C# code. Open the .sln file and execute it. 

Known Issues:

	None.

Classes:
	
	Cards:
		
		Number:  0 -13 a switch statement interprets these numbers as names.
		Suit: A string value that  determines one of four suits.
		Picked: A boolean that determines if the card is in play or not.

		Methods:
			Picked() This method makes a card picked so it cant be chosen twice.

	Deck:

		Cards [ ] : Holds an array of cards that can be be dealt or displayed
		
			Methods:
				Deal() deals out a specified number of cards to a number of hands

				Print() Shows all of the cards in the deck. 
	
