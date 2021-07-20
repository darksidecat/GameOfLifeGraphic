using System;
using System.Drawing;
using System.Windows.Forms;
using GameOfLife;

namespace GameOfLifeGraphic
{
    public partial class GameForm : Form
    {
        private int _cell_size;
        private int _cell_size_borderless;
        private int _x;
        private int _y;

        private Graphics _graphics;
        private Field field;

        public GameForm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            NextFrame();
        }

        private void FirstFrameInit()
        {
            _cell_size = (int)ScaleSelector.Value;
            _cell_size_borderless = _cell_size - ((_cell_size > 2) ? 1 : 0);

            _x = PictureBoxMain.Width / _cell_size;
            _y = PictureBoxMain.Height / _cell_size;

            field = new(_x, _y);
            field.FillRandom((float)FillingSelector.Value / 100);


            PictureBoxMain.Image = new Bitmap(PictureBoxMain.Width, PictureBoxMain.Height);
            _graphics = Graphics.FromImage(PictureBoxMain.Image);

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            ScaleSelector.Enabled = false;
            FillingSelector.Enabled = false;

            FirstFrameInit();
            GameTimer.Start();
        }

        private void NextFrame()
        {
            _graphics.Clear(Color.Black);

            
            for (int x = 0; x < field.FieldCurrent.GetLength(0); x++)
            {
                for (int y = 0; y < field.FieldCurrent.GetLength(1); y++)
                {
                    if (field.FieldCurrent[x, y] == 1)
                    {
                        _graphics.FillRectangle(
                            Brushes.DarkGreen, x * _cell_size, y * _cell_size, _cell_size_borderless, _cell_size_borderless);
                    }
                }

            }
            field.UpdateField();
            PictureBoxMain.Refresh();
        }



        private void StopButton_Click(object sender, EventArgs e)
        {
            if (!GameTimer.Enabled)
                return;

            ScaleSelector.Enabled = true;
            FillingSelector.Enabled = true;

            GameTimer.Stop();

        }

        private void SpeedBar_Scroll(object sender, EventArgs e)
        {
            GameTimer.Interval = SpeedBar.Value;
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            if (GameTimer.Enabled)
                return;

            ScaleSelector.Enabled = false;
            FillingSelector.Enabled = false;

            GameTimer.Start();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (!GameTimer.Enabled)
                NextFrame();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            FirstFrameInit();
            NextFrame();

        }
    }
}
