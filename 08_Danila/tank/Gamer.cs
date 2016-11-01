using System.Drawing;

namespace WindowsFormsApplication1
{
    enum Orientation { Up, Down, Left, Right }

    class Gamer
    {
        public Orientation Ор = new Orientation();
        public Point Location;
        public bool Move;
        public Image GamerImage;
        
        public void Go()
        {
            if (Move)
            {
                if (Ор == Orientation.Up){ if (Location.Y > 0) Location.Y -= 2; }
                else
                    if (Ор == Orientation.Down) { if (Location.Y < 443) Location.Y += 2; }
                    else
                        if (Ор == Orientation.Left) { if (Location.X > 0) Location.X -= 2; }
                        else
                            if (Ор == Orientation.Right) { if (Location.X < 603) Location.X += 2; }
            }
        }
    }
}
