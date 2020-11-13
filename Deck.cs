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
      List<string> suits = new List<string>() {
        "Clubs",
        "Hearts",
        "Spades",
        "Diamonds"
      };
      List<Card> cards = new List<Card>();

      foreach(string suit in suits) {
        for (int rank = 0; rank <= 12; rank++) {
          Card card = new Card(suit, rank);
          cards.Add(card);
        }
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
      Card card = this._cards[0];
      this._cards.RemoveAt(0);
      return card;
    }
  }
}
