using System;

namespace task2
{
    public class Block
    {
        private int Side1 { get; }
        private int Side2 { get; }
        private int Side3 { get; }
        private int Side4 { get; }

        public Block(int side1, int side2, int side3, int side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }

        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType()) return false;
            var other = (Block) obj;
            return Side1 == other.Side1 && Side2 == other.Side2 && Side3 == other.Side3 && Side4 == other.Side4;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Side1, Side2, Side3, Side4);
        }

        public override string ToString()
        {
            return $"{Side1},{Side2},{Side3},{Side4}";
        }
    }
}