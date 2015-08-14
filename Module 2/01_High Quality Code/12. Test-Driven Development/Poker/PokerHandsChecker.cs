namespace Poker
{
    using System;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("No hand passed");
            }

            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < 5; i++)
            {
                if (hand.ToString().IndexOf(hand.Cards[i].ToString()) != hand.ToString().LastIndexOf(hand.Cards[i].ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            for (int i = 0; i < 2; i++)
            {
                var result = hand.Cards.Count(card => card.Face == hand.Cards[i].Face);

                if (result == 4)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            CardSuit firstCardSuit = hand.Cards[0].Suit;

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != firstCardSuit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
