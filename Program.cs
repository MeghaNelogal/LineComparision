namespace LineComparision
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welome To Line Comparision Problem");

            LineCompare checkLine = new LineCompare();
            checkLine.checkLength();
            checkLine.checkEquality();
            checkLine.CompareLines();
        }
    }
}