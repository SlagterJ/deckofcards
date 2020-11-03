using System;
using System.Collections.Generic;

namespace deckofcards {
  class Deck {
    // Properties
    // Array of cards that are currently in the deck.
    protected List<Card> _cards;

    public Deck() {
      SetCards(CreateDefaultDeck());
    }

    public Deck(List<Card> cards) {
      SetCards(cards);
    }

    public void Shuffle() {
      List<Card> cards = this.GetCards();
      Random random = new Random();
      // Count the amount of cards.
      int n = cards.Count;
      // For every card in the deck, swap it with another.
      while (n > 1) {
        n--;
        int k = random.Next(n + 1);
        // Pick a random card to be swapped.
        Card cardToBeSwapped = cards[k];
        // Swap them
        cards[k] = cards[n];
        cards[n] = cardToBeSwapped;
      }

      // Set the new deck of cards to the shuffled version.
      this.SetCards(cards);
    }

    protected List<Card> CreateDefaultDeck() {
      List<Card> cards = new List<Card>(); 
      // Amount of cards in one suit (+ 1)
      int cardAmount = 13;
      // Amount of suits in one deck
      int suitAmount = 4;
      // Amount of times to loop in order to generate all cards
      int r = cardAmount * suitAmount;
      
      for (int n = 0; n < r; n++) {
        string suitToSetCardTo = "Clubs";
        int rankToSetCardTo = n;
        if (n >= cardAmount * 1) {
          suitToSetCardTo = "Hearts";
          rankToSetCardTo = n - cardAmount * 1;
        }
        if (n >= cardAmount * 2) {
          suitToSetCardTo = "Spades";
          rankToSetCardTo = n - cardAmount * 2;
        } 
        if (n >= cardAmount * 3) {
          suitToSetCardTo = "Diamonds";
          rankToSetCardTo = n - cardAmount * 3;
        }
        Card card = new Card(suitToSetCardTo, rankToSetCardTo);
        cards.Add(card);
      }

      return cards;
    }

    // Property manipulators.
    protected void SetCards(List<Card> cards) { this._cards = cards; }
    public List<Card> GetCards() { return this._cards; }

    // Misc methods
    public void DumpCards() {
      foreach(Card card in this._cards) {
        card.Dump();
      }
    }

    public Card GetTopCard() {
      return this._cards[0];
    }
  }
}
