using System;
using System.Collections.Generic;

namespace deckofcards
{
    class Program
    {
// Card class
        public class Card
        {
            string stringVal; // Value of the card as a string
            string suit; // Suit of the card
            int val; // Value of the card as a number

            public Card(string new_stringVal, string new_suit, int new_val)
            {
                stringVal = new_stringVal;
                suit = new_suit;
                val = new_val;
            }

            public override string ToString() 
            {
                return stringVal + " of " + suit;
            }           
        }
// Deck class
        public class Deck
        {
            public List<Card> cards;

            // Constructor - build the deck
            public Deck()
            {
                Reset();
            }

            // Deal cards
            public Card Deal() 
            {
                if(cards.Count > 0) 
                {
                    Card temp = cards[0];
                    cards.RemoveAt(0);
                    return temp;
                }
                return null;
            }

            // Shuffle the deck
            public Deck Shuffle() 
            {
                Random rand = new Random();
                for(int idx = cards.Count - 1; idx > 0; idx--) 
                {
                    int randIdx = rand.Next(idx);
                    Card temp = cards[randIdx];
                    cards[randIdx] = cards[idx];
                    cards[idx] = temp;
                }
                return this;
            }

            // Reset method- resets the deck
            public Deck Reset()
            {
                cards = new List<Card>(); // Clears cards list
                string[] val_arr = new string[] {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
                string[] suit_arr = new string[] {"Clubs","Spades","Hearts","Diamonds"};
            
                for (int i=0;i<val_arr.Length;i++)
                {
                    foreach(string j in suit_arr)
                    {
                        cards.Add(new Card(val_arr[i],j,i));
                    }
                }
                return this;
            }

            // Overrides the ToString method to display like so:
            public override string ToString() 
            {
                string info = "";
                foreach(Card card in cards) 
                {
                    info += card + "\n";
                }
                return info;
            }

        }
// Player class
        public class Player 
        {
            public string name;
            private List<Card> hand;

            public Player(string n) {
                hand = new List<Card>();
                name = n;
            }

            public void DrawFrom(Deck currentDeck) {
                hand.Add(currentDeck.Deal());
            }

            public Card Discard(int idx) 
            {
                Card temp = hand[idx];
                hand.RemoveAt(idx);
                return temp;
            }
        }
        static void Main(string[] args)
        {

            Deck game = new Deck();
            Console.WriteLine(game.ToString());
            Console.WriteLine(game.Shuffle().ToString());
        }
    }
}
