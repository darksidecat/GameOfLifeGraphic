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
            _cell_size = (int)ResolutionSelector.Value;
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
            ResolutionSelector.Enabled = false;
            FillingSelector.Enabled = false;

            FirstFrameInit();
            timer1.Start();
        }

        private void NextFrame()
        {
            _graphics.Clear(Color.Black);

            
            for (int i = 0; i < field.FieldCurrent.GetLength(0); i++)
            {
                for (int j = 0; j < field.FieldCurrent.GetLength(1); j++)
                {
                    if (field.FieldCurrent[i, j] == 1)
                    {
                        _graphics.FillRectangle(
                            Brushes.DarkGreen, i * _cell_size, j * _cell_size, _cell_size_borderless, _cell_size_borderless);
                    }
                }
            }
            field.UpdateField();
            PictureBoxMain.Refresh();
        }



        private void StopButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                return;

            ResolutionSelector.Enabled = true;
            FillingSelector.Enabled = true;

            timer1.Stop();

        }

        private void SpeedBar_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = SpeedBar.Value;
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;

            ResolutionSelector.Enabled = false;
            FillingSelector.Enabled = false;

            timer1.Start();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                NextFrame();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            FirstFrameInit();
            NextFrame();

        }
    }
}
