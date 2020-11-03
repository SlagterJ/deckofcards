using System;

namespace deckofcards {
  class Program {
    static void Main(string[] args) {
      // Hallo meneer/mevrouw!
      // Dit is mijn kaartprogramma. U kan een lijst maken van kaarten en deze
      // als eerste param in de constructor van Deck toevoegen om uw eigen deck
      // te maken.
      Deck deck = new Deck();
      Console.WriteLine("----- Cards currently in the deck: ---");
      // Dit dumpt alle kaarten in de volgorde dat ze staan in de lijst naar de
      // console.
      deck.DumpCards();
      Console.WriteLine("----------");
      Console.WriteLine("----- Cards in deck after shuffling: -----");
      // Dit shuffled de kaarten willekeurig door er 1 te kiezen, en die te wisselen
      // met een willekeurige andere.
      deck.Shuffle();
      deck.DumpCards();
      Console.WriteLine("----------");
      Console.WriteLine("Card currently on top:");
      // Dit dumpt de eerste kaart in de lijst.
      deck.GetTopCard().Dump();
    }
  }
}
