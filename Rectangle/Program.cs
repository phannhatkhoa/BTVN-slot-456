namespace Rectangle
{

    public class Point
    {
        private int x;
        private int y;
        public int X { get; set; }
        public int Y { get; set; }
            
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"Point ({x},{y})";
        }
    }
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
       
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public override string ToString()
        {
            return $"{TopLeft},{BottomRight}";
        }

        public bool Contains(Point point)
        {
            bool isInHorizontal = TopLeft.X <= point.X && BottomRight.X >= BottomRight.X;
            bool isInVertical = TopLeft.Y <= point.Y && BottomRight.Y >= BottomRight.Y;
            bool isInRectangle = isInHorizontal && isInVertical;
            return isInRectangle;

        }
    }
    class Program {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            Console.WriteLine(p1);
            Rectangle r1 = new Rectangle(new Point(0, 2) , new Point(2, 0));
            Console.WriteLine($"Retangle{r1} contains {p1} is{r1.Contains(p1)}");
        }
    }
}