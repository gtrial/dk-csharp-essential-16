using System;

namespace task3
{
    public class House : ICloneable
    {
        private double Square { get; }
        private double Price { get; }

        public House(double square, double price)
        {
            Square = square;
            Price = price;
        }

        public object Clone()
        {
            return (House) MemberwiseClone();
        }

        public House DeepClone()
        {
            return (House) Clone();
        }

        public override string ToString()
        {
            return $"{Square},{Price}";
        }
    }
}