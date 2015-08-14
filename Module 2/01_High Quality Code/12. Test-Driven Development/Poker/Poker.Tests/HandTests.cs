namespace Poker.Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HandTests
    {
        Hand testHand = new Hand(new List<ICard>
                                         {
                                             new Card(CardFace.Six, CardSuit.Clubs),
                                             new Card(CardFace.Queen, CardSuit.Spades),
                                             new Card(CardFace.Queen, CardSuit.Hearts),
                                             new Card(CardFace.Queen, CardSuit.Clubs),
                                             new Card(CardFace.Queen, CardSuit.Diamonds)
                                         });    

        [TestMethod]
        public void ToStringMustReturnTheSeparatedStringRepresentationsOfTheCardsInTheHand()
        {
            Assert.AreEqual("6♣ Q♠ Q♥ Q♣ Q♦", this.testHand.ToString());
        }
    }
}
