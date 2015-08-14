namespace Poker.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ToStringShouldReturnCardFaceAndCardSuitWhenHighCard()
        {
            Card testCard = new Card(CardFace.Queen, CardSuit.Spades);
            Console.WriteLine(testCard);
            Assert.AreEqual("Q♠", testCard.ToString());
        }

        [TestMethod]
        public void ToStringShouldReturnCardFaceAndCardSuitWhenTen()
        {
            Card testCard = new Card(CardFace.Ten, CardSuit.Diamonds);
            Console.WriteLine(testCard);
            Assert.AreEqual("10♦", testCard.ToString());
        }

        [TestMethod]
        public void ToStringShouldReturnCardFaceAndCardSuitWhenLowCard()
        {
            Card testCard = new Card(CardFace.Seven, CardSuit.Clubs);
            Console.WriteLine(testCard);
            Assert.AreEqual("7♣", testCard.ToString());
        }
    }
}
