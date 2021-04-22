using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SnakeGame
{
    public partial class MainForm : Form
    {
        Bitmap map;
        Graphics SP;
        public MainForm()
        {
            InitializeComponent();
            map = new Bitmap(Pb_Field.Width, Pb_Field.Height);
            SP = Graphics.FromImage(map);
            Pb_Field.Image = map;
            PartSizeX = (int)Pb_Field.Width / 20;
            PartSizeY = (int)Pb_Field.Height / 20;
            LoadImages(countofimages);
            HowToWin = (Pb_Field.Width * Pb_Field.Height) / (PartSizeX * PartSizeY);
        }
        const int countofimages = 2;
        int rndimageindex;
        Rectangle foodrect;
        string direction;
        Rectangle[] SnakeParts = new Rectangle[0];
        int PartSizeX;
        int PartSizeY;
        Image[] food = new Image[countofimages];
        Random rnd = new Random();
        int HowToWin;
        private void AddSnakePart(Point location)
        {
            Size siz = new Size(PartSizeX, PartSizeY);
            Array.Resize<Rectangle>(ref SnakeParts, SnakeParts.Length + 1);
            SnakeParts[SnakeParts.Length - 1] = new Rectangle(location, siz);
        }

        private void LoadImages(int count)
        {
            for (int i = 0; i < count; i++)
            {
                food[i] = Image.FromFile($@"Resources/Food/{i}.png");
            }
        }

        private void DrawSnake()
        {
            SP.Clear(Color.FromArgb(10, 12, 10));
            Pen pen = new Pen(Color.ForestGreen, 1);
            SolidBrush brush = new SolidBrush(Color.ForestGreen);
            SP.DrawRectangles(pen, SnakeParts);
            SP.FillRectangles(brush, SnakeParts);
            SP.DrawImage(food[rnd.Next(rndimageindex)], foodrect.Location); // рисуем рандомный спрайт еды на месте
            Pb_Field.Image = map;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            SnakeMovingTimer.Start();
            Btn_Start.Enabled = false;
        }

        private int BorderCase() // int - номер стороны
        {
            int cs = 0;
                if (SnakeParts[0].X > Pb_Field.Width - PartSizeX)
                {
                    cs = 1;
                }
                if (SnakeParts[0].X < 0)
                {
                    cs = 2;
                }
                if (SnakeParts[0].Y > Pb_Field.Height - PartSizeY)
                {
                    cs = 3;
                }
                if (SnakeParts[0].Y < 0)
                {
                    cs = 4;
                }
            return cs;
        }
        private void BorderBlock(int cs) // cs == case
        {
            if (cs == 1)
            {
                SnakeParts[0].X = 0;
            }
            if (cs == 2)
            {
                SnakeParts[0].X = Pb_Field.Width - PartSizeX;
            }
            if (cs == 3)
            {
                SnakeParts[0].Y = 0;
            }
            if (cs == 4)
            {
                SnakeParts[0].Y = Pb_Field.Height - PartSizeY;
            }
        }
        private void FirstSnakeMove()
        {
            if (BorderCase() == 0)
            {
                switch (direction)
                {
                    case "Left":
                        {
                            SnakeParts[0].X -= PartSizeX;
                            break;
                        }
                    case "Up":
                        {
                            SnakeParts[0].Y -= PartSizeY;
                            break;
                        }
                    case "Right":
                        {
                            SnakeParts[0].X += PartSizeX;
                            break;
                        }
                    case "Down":
                        {
                            SnakeParts[0].Y += PartSizeY;
                            break;
                        }
                }
            }
            else
            {
                BorderBlock(BorderCase());
            }
        }

        private void FullSnakeMove()
        {
                for (int i = SnakeParts.Length - 1; i >= 1; i--)
                {
                    SnakeParts[i].Location = SnakeParts[i - 1].Location;
                }


        }

        private void SpawnFood()
        {
            Point loc = new Point();
            Size siz = new Size(PartSizeX, PartSizeY);
            bool finalCheck = false;
            bool[] fullCheck = new bool[SnakeParts.Length];
            while (finalCheck == false)
            {
                loc.X = rnd.Next(Pb_Field.Width);
                loc.Y = rnd.Next(Pb_Field.Height);
                for (int i = 0; i < SnakeParts.Length; i++)
                {
                    fullCheck[i] = (loc != SnakeParts[i].Location) && (loc.X % PartSizeX == 0) && (loc.Y % PartSizeY == 0);
                }
                if (!fullCheck.Contains<bool>(false))
                {
                    finalCheck = true;
                }

            }
            foodrect = new Rectangle(loc, siz);
            rndimageindex = rnd.Next(countofimages-1);
        }

        private void FailCheck()
        {
            bool[] Collidecheck = new bool[SnakeParts.Length];
            for (int i = 1; i < SnakeParts.Length; i++)
            {
                Collidecheck[i] = (SnakeParts[0] == SnakeParts[i]);
            }
            if (Collidecheck.Contains<bool>(true))
            {
                FailForm fail = new FailForm();
                SnakeMovingTimer.Enabled = false;
                fail.ShowDialog();
            }
        }
        private void CheckFoodEaten()
        {
            bool check = (foodrect.IntersectsWith(SnakeParts[0]));
            if (check)
            {
                foodrect = new Rectangle();
                AddSnakePart(SnakeParts[SnakeParts.Length - 1].Location);
            }
        }

        private void WinCheck()
        {
            if (SnakeParts.Length == HowToWin)
            {
                SnakeMovingTimer.Enabled = false;
                YouWin GgWp = new YouWin();
                GgWp.ShowDialog();
            }
        }
        private void SnakeMovingTimer_Tick(object sender, EventArgs e)
        {
            WinCheck();
            FailCheck();
            CheckFoodEaten();
            if (foodrect.IsEmpty)
            {
                SpawnFood();
            }    
            FullSnakeMove();
            FirstSnakeMove();
            DrawSnake();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            direction = "Right";
            Point center = new Point(Pb_Field.Width / 2, Pb_Field.Height / 2);
            AddSnakePart(center);
            DrawSnake();
        }

        private void Pb_Field_SizeChanged(object sender, EventArgs e)
        {
            PartSizeX = (int)Pb_Field.Width / 20;
            PartSizeY = (int)Pb_Field.Height / 20;
            // Зачем это нужно? Надумывал сделать фуллскрин
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           //switch (e.KeyData)
           //{
           //    case Keys.Up:
           //        {
           //            direction = "Up";
           //            break;
           //        }
           //    case Keys.Left:
           //        {
           //            direction = "Left";
           //            break;
           //        }
           //    case Keys.Right:
           //        {
           //            direction = "Down";
           //            break;
           //        }
           //    case Keys.Down:
           //        {
           //            direction = "Right";
           //            break;
           //        }
           // }
        }

        private void Pb_Field_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           switch (e.KeyData)
           {
               case Keys.W:
                   {
                       direction = "Up";
                       break;
                   }
               case Keys.A:
                   {
                       direction = "Left";
                       break;
                   }
               case Keys.D:
                   {
                       direction = "Right";
                       break;
                   }
               case Keys.S:
                   {
                       direction = "Down";
                       break;
                   }
               case Keys.Up:
                   {
                       direction = "Up";
                       break;
                   }
               case Keys.Left:
                   {
                       direction = "Left";
                       break;
                   }
               case Keys.Right:
                   {
                       direction = "Right";
                       break;
                   }
               case Keys.Down:
                   {
                       direction = "Down";
                       break;
                   }
           }
        }

        private void Btn_Retry_Click(object sender, EventArgs e)
        {
            SnakeMovingTimer.Stop();
            SnakeParts = new Rectangle[0];
            Point center = new Point((int)Pb_Field.Width / 2, (int)Pb_Field.Height / 2);
            AddSnakePart(center);
            DrawSnake();
            Btn_Start.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            direction = "Up";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            direction = "Down";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            direction = "Left";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            direction = "Right";
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            Btn_Pause.Enabled = false;
            if (SnakeMovingTimer.Enabled == true)
            {
                SnakeMovingTimer.Stop();
                Btn_Pause.ForeColor = Color.FromArgb(196, 110, 105);
            }
            else
            {
                SnakeMovingTimer.Start();
                Btn_Pause.ForeColor = Color.FromArgb(140, 196, 145);
            }
            Btn_Pause.Enabled = true;
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {

        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            Btn_Pause.PerformClick();
        }
    }
}
