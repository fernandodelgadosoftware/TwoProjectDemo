// See https://aka.ms/new-console-template for more information

namespace Point
{
    public struct Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            //Console.WriteLine("{ " + X + " , " + Y +" }");
            return $"( {X}, {Y} )";
        }
    }
}