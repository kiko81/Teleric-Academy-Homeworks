namespace Deck.Tests
{
    using NUnit.Framework;

    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void ExpectNewDeckBeFull()
        {
            var deck = new Deck();
            Assert.AreEqual(deck.CardsLeft, 24);
        }

        [Test]
        public void ExpectTrumpCardToEqualSwappedCard()
        {
            var deck = new Deck();
            var card = new Card(CardSuit.Club, CardType.Ace);
            deck.ChangeTrumpCard(card);
            Assert.AreEqual(card, deck.GetTrumpCard);
        }

        [Test]
        [TestCase(0)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(20)]
        [TestCase(24)]
        public void TestGettingCardsFromDeckShouldProperlyUpdateTheCountOfCardsLeft(int countOfCardsToGet)
        {
            var deck = new Deck();
            var card = deck.GetNextCard();
            int cardsLeftCount = deck.CardsLeft;
            for (int i = 1; i < countOfCardsToGet; i++)
            {
                card = deck.GetNextCard();
                cardsLeftCount--;
            }
            Assert.AreEqual(deck.CardsLeft, cardsLeftCount);
        }
    }
}
