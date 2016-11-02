using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Panzer : Form
    {
        public Panzer()
        {
            InitializeComponent();
            _fireGamer1.FireImage = Properties.Resources.bullet1;
            _fireGamer2.FireImage = Properties.Resources.bullet2;
            _gamer1.GamerImage = Properties.Resources.tank1_Up;
            _gamer2.GamerImage = Properties.Resources.tank2_Up;
           
        }


        readonly Gamer _gamer1 = new Gamer();
        readonly Gamer _gamer2 = new Gamer();

        readonly Fire _fireGamer1 = new Fire();
        readonly Fire _fireGamer2 = new Fire();


        protected override void OnKeyDown(KeyEventArgs k) // нажатие клавиш 
        {
            base.OnKeyDown(k);
            switch (k.KeyCode)
            {
                // клавиши для Gamer1
                case Keys.Up: { _gamer1.Ор = Orientation.Up; _gamer1.Move = true; _gamer1.GamerImage = Properties.Resources.tank1_Up; break; }
                case Keys.Down: { _gamer1.Ор = Orientation.Down; _gamer1.Move = true; _gamer1.GamerImage = Properties.Resources.tank1_Down; break; }
                case Keys.Left: { _gamer1.Ор = Orientation.Left; _gamer1.Move = true; _gamer1.GamerImage = Properties.Resources.tank1_Left; break; }
                case Keys.Right: { _gamer1.Ор = Orientation.Right; _gamer1.Move = true; _gamer1.GamerImage = Properties.Resources.tank1_Right; break; }
                case Keys.NumPad0: 
                    {
                        if (_fireGamer1.Shot == false)
                        {
                            if (_gamer1.Ор == Orientation.Up) { _fireGamer1.Location.X = _gamer1.Location.X + 13; _fireGamer1.Location.Y = _gamer1.Location.Y - 7; }
                            if (_gamer1.Ор == Orientation.Down) { _fireGamer1.Location.X = _gamer1.Location.X + 13; _fireGamer1.Location.Y = _gamer1.Location.Y + 33; }
                            if (_gamer1.Ор == Orientation.Left) { _fireGamer1.Location.X = _gamer1.Location.X - 7; _fireGamer1.Location.Y = _gamer1.Location.Y + 13; }
                            if (_gamer1.Ор == Orientation.Right) { _fireGamer1.Location.X = _gamer1.Location.X + 33; _fireGamer1.Location.Y = _gamer1.Location.Y + 13; }
                            if (_gamer1.Ор == Orientation.Up) _fireGamer1.Direction = Orientation.Up;
                            if (_gamer1.Ор == Orientation.Down) _fireGamer1.Direction = Orientation.Down;
                            if (_gamer1.Ор == Orientation.Left) _fireGamer1.Direction = Orientation.Left;
                            if (_gamer1.Ор == Orientation.Right) _fireGamer1.Direction = Orientation.Right;
                            BulletGamer1_PicBox.Show();
                            _fireGamer1.Shot = true;
                        }
                        break;
                    }
                // клавиши для Gamer2
                case Keys.W: { _gamer2.Ор = Orientation.Up; _gamer2.Move = true; _gamer2.GamerImage = Properties.Resources.tank2_Up;  break; }
                case Keys.S: { _gamer2.Ор = Orientation.Down; _gamer2.Move = true; _gamer2.GamerImage = Properties.Resources.tank2_Down;  break; }
                case Keys.A: { _gamer2.Ор = Orientation.Left; _gamer2.Move = true; _gamer2.GamerImage = Properties.Resources.tank2_Left;  break; }
                case Keys.D: { _gamer2.Ор = Orientation.Right; _gamer2.Move = true; _gamer2.GamerImage = Properties.Resources.tank2_Right;  break; }
                case Keys.Space:
                    {
                        if (_fireGamer2.Shot == false)
                        {
                            if (_gamer2.Ор == Orientation.Up) { _fireGamer2.Location.X = _gamer2.Location.X + 13; _fireGamer2.Location.Y = _gamer2.Location.Y - 7; }
                            if (_gamer2.Ор == Orientation.Down) { _fireGamer2.Location.X = _gamer2.Location.X + 13; _fireGamer2.Location.Y = _gamer2.Location.Y + 33; }
                            if (_gamer2.Ор == Orientation.Left) { _fireGamer2.Location.X = _gamer2.Location.X - 7; _fireGamer2.Location.Y = _gamer2.Location.Y + 13; }
                            if (_gamer2.Ор == Orientation.Right) { _fireGamer2.Location.X = _gamer2.Location.X + 33; _fireGamer2.Location.Y = _gamer2.Location.Y + 13; }
                            if (_gamer2.Ор == Orientation.Up) _fireGamer2.Direction = Orientation.Up;
                            if (_gamer2.Ор == Orientation.Down) _fireGamer2.Direction = Orientation.Down;
                            if (_gamer2.Ор == Orientation.Left) _fireGamer2.Direction = Orientation.Left;
                            if (_gamer2.Ор == Orientation.Right) _fireGamer2.Direction = Orientation.Right;
                            BulletGamer2_PicBox.Show();
                            _fireGamer2.Shot = true;
                        }
                        break;
                    }
              }
        }

        protected override void OnKeyUp(KeyEventArgs k)        // отпускание клавиш 
        {
            base.OnKeyUp(k);
            switch (k.KeyCode)
            {
                // клавиши для Gamer1
                case Keys.Up: {  _gamer1.Move = false; break; }
                case Keys.Down: { _gamer1.Move = false; break; }
                case Keys.Left: { _gamer1.Move = false; break; }
                case Keys.Right: { _gamer1.Move = false; break; }
                // клавиши для Gamer2
                case Keys.W: { _gamer2.Move = false; break; }
                case Keys.S: { _gamer2.Move = false; break; }
                case Keys.A: { _gamer2.Move = false; break; }
                case Keys.D: { _gamer2.Move = false; break; }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)   // таймер 
        {
            _gamer1.Location.X = Gamer1_PicBox.Location.X;
            _gamer1.Location.Y = Gamer1_PicBox.Location.Y;
            _gamer2.Location.X = Gamer2_PicBox.Location.X;
            _gamer2.Location.Y = Gamer2_PicBox.Location.Y;

            _gamer1.Go();
            _gamer2.Go();
            _fireGamer1.Move();
            _fireGamer2.Move();

            Gamer1_PicBox.Image = _gamer1.GamerImage;
            Gamer2_PicBox.Image = _gamer2.GamerImage;
            BulletGamer1_PicBox.Image = _fireGamer1.FireImage;
            BulletGamer2_PicBox.Image = _fireGamer2.FireImage;

            Gamer1_PicBox.Location = new Point(_gamer1.Location.X,_gamer1.Location.Y);
            Gamer2_PicBox.Location = new Point(_gamer2.Location.X,_gamer2.Location.Y);
            BulletGamer1_PicBox.Location = new Point(_fireGamer1.Location.X,_fireGamer1.Location.Y);
            BulletGamer2_PicBox.Location = new Point(_fireGamer2.Location.X, _fireGamer2.Location.Y);
            if (_fireGamer1.Shot == false) BulletGamer1_PicBox.Hide();
            if (_fireGamer2.Shot == false) BulletGamer2_PicBox.Hide();
        }

        private void Игрок1_PicBox_Click(object sender, EventArgs e)
        {

        }

        private void panzer_Load(object sender, EventArgs e)
        {

        }
    }
}