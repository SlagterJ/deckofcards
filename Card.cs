using System;

namespace deckofcards {
  public class Card {
    // Properties

    // Defines the suit of the card.
    // Clubs, Hearts, Spades or Diamonds
    protected string _suit; 
    // Defines the rank of the card.
    // 0 - 8, 9 = jack, 10 = queen, 11 = king, 12 = ace
    protected int _rank;

    // Constructor, a card can't exist without
    // a suite and a deck.
    public Card(string suit, int rank) {
      this.SetSuit(suit);
      this.SetRank(rank);
    }

    // Property manipulators
    protected void SetSuit(string suit) { this._suit = suit; }
    public string GetSuit() { return this._suit; }

    protected void SetRank(int rank) { this._rank = rank; }
    public string GetRank() {
      if (this._rank <= 8) return (this._rank + 2).ToString();

      switch (this._rank) {
        case 9:
          return "Jack";
        case 10:
          return "Queen";
        case 11:
          return "King";
        default:
          return "Ace";
      }
    }
    public int GetInternalRank() { return this._rank; }

    // Misc methods
    public void Dump() {
      Console.WriteLine(this.GetRank() + " " + this.GetSuit());
    }
  }
}
