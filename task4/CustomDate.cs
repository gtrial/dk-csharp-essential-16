namespace task4
{
    public class CustomDate
    {
        private int Day { get; }
        private int Month { get; }
        private int Year { get; }

        public CustomDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public static CustomDate operator +(CustomDate a, int days)
        {
            return new CustomDate(a.Day + days, a.Month, a.Year);
        }

        public static CustomDate operator -(CustomDate a, CustomDate b)
        {
            return new CustomDate(a.Day - b.Day, a.Month - b.Month, a.Year - b.Year);
        }

        public override string ToString()
        {
            return $"{Year}-{Month}-{Day}";
        }
    }
}