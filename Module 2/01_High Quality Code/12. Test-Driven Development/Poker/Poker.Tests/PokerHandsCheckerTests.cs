namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PokerHandsCheckerTests
    {
        private Hand validHand = new Hand(new List<ICard>
                                         {
                                             new Card(CardFace.Six, CardSuit.Clubs),
                                             new Card(CardFace.Queen, CardSuit.Spades),
                                             new Card(CardFace.Queen, CardSuit.Hearts),
                                             new Card(CardFace.Queen, CardSuit.Clubs),
                                             new Card(CardFace.Queen, CardSuit.Diamonds)
                                         });

        private Hand invalidHand4Cards = new Hand(new List<ICard>
                                         {
                                             new Card(CardFace.Six, CardSuit.Clubs),
                                             new Card(CardFace.Queen, CardSuit.Spades),
                                             new Card(CardFace.Queen, CardSuit.Hearts),
                                             new Card(CardFace.Queen, CardSuit.Clubs)
                                         });

        private Hand invalidHand6Cards = new Hand(new List<ICard>
                                         {
                                             new Card(CardFace.Six, CardSuit.Clubs),
                                             new Card(CardFace.Queen, CardSuit.Spades),
                                             new Card(CardFace.Queen, CardSuit.Hearts),
                                             new Card(CardFace.Queen, CardSuit.Clubs),
                                             new Card(CardFace.Queen, CardSuit.Diamonds),
                                             new Card(CardFace.Six, CardSuit.Spades),
                                         });

        private Hand invalidHandEqualCards = new Hand(new List<ICard>
                                         {
                                             new Card(CardFace.Six, CardSuit.Clubs),
                                             new Card(CardFace.Queen, CardSuit.Spades),
                                             new Card(CardFace.Queen, CardSuit.Hearts),
                                             new Card(CardFace.Queen, CardSuit.Spades),
                                             new Card(CardFace.Queen, CardSuit.Diamonds)
                                         });

        private readonly PokerHandsChecker checker = new PokerHandsChecker();

        private Hand validFlushHand = new Hand(new List<ICard>
                                               {
                                                   new Card(CardFace.Six, CardSuit.Clubs),
                                                   new Card(CardFace.Eight, CardSuit.Clubs),
                                                   new Card(CardFace.Queen, CardSuit.Clubs),
                                                   new Card(CardFace.Ten, CardSuit.Clubs),
                                                   new Card(CardFace.Three, CardSuit.Clubs)
                                               });

        // isValid tests
        [TestMethod]
        public void IsValidHandShouldReturnTrueWhenValidHandPassed()
        {
            Assert.IsTrue(this.checker.IsValidHand(this.validHand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValidHandShouldThrowWhenNullPassed()
        {
            this.checker.IsValidHand(null);
        }

        [TestMethod]
        public void IsValidHandShouldReturnFalseWhenHandWithLessThanFiveCardsPassed()
        {
            Assert.IsFalse(this.checker.IsValidHand(this.invalidHand4Cards));
        }

        [TestMethod]
        public void IsValidHandShouldReturnFalseWhenHandWithMoreThanFiveCardsPassed()
        {
            Assert.IsFalse(this.checker.IsValidHand(this.invalidHand6Cards));
        }

        [TestMethod]
        public void IsValidHandShouldReturnFalseWhenHandWithSomeEqualCardsPassed()
        {
            Assert.IsFalse(this.checker.IsValidHand(this.invalidHandEqualCards));
        }

        // flush tests

        [TestMethod]
        public void IsFlushShouldReturnFalseWhenANonFlushHandPassed()
        {
            Assert.IsFalse(this.checker.IsFlush(this.validHand));
        }

        [TestMethod]
        public void IsFlushShouldReturnTrueWhenAFlushHandIsPassed()
        {
            Assert.IsTrue(this.checker.IsFlush(this.validFlushHand));
        }

        // 4 of a kind

        [TestMethod]
        public void IsFourOfAKindShouldReturnFalseWhenNonFourOfAKindHandPassed()
        {
            Assert.IsFalse(this.checker.IsFourOfAKind(this.validFlushHand));
        }

        [TestMethod]
        public void IsFourOfAKindShouldReturnTrueWhenFourOfAKindHandPassed()
        {
            Assert.IsTrue(this.checker.IsFourOfAKind(this.validHand));
        }
    }
}
