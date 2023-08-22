namespace Point1
{
    public struct Point
    {
        public int X;
        public int Y;
        public int Z;


        public override string ToString()
        {
            return $"( {X}, {Y}, {Z} )";
        }
    }
}