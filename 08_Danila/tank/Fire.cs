using System.Drawing;

namespace WindowsFormsApplication1
{
    class Fire
    {
        public Orientation Direction = new Orientation();
        public Point Location;
        public bool Shot;
        public Image FireImage;

        public void Move()
        {
            if (Shot)
            {
                if (Direction == Orientation.Up) { Location.Y -= 4; }
                if (Direction == Orientation.Down) { Location.Y += 4; }
                if (Direction == Orientation.Left) { Location.X -= 4; }
                if (Direction == Orientation.Right) { Location.X += 4; }
                if ((Location.X < 0) || (Location.X > 635) || (Location.Y < 0) || (Location.Y > 475)) Shot = false;
            }
        }
    }
}
