using System;

namespace Num._56
{
    public struct Card
    {
        public Card(Suit suit, Value value):this()
        {
            Suit = suit;
            Value = value;
            _tostring = new Lazy<string>(ToStringInternal);
        }

        public Suit Suit { get; private  set; }
        public Value Value { get; private  set; }

        public override string ToString()
        {
            return _tostring.Value;
        }

        private string ToStringInternal()
        {
            return string.Format("{0} {1}", Suit, Value);
        }

        private readonly Lazy<string> _tostring;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (obj.GetType() != typeof (Card)) return false;
            return Equals((Card) obj);
        }

        public bool Equals(Card other)
        {
            return Equals(other.Suit, Suit) && Equals(other.Value, Value);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Suit.GetHashCode()*397) ^ Value.GetHashCode();
            }
        }

        public static bool  operator== (Card a, Card b)
        {
            return Equals(a, b);
        }

        public static bool operator!=(Card a, Card b)
        {
            return  !Equals(a, b);
        }
    }
}