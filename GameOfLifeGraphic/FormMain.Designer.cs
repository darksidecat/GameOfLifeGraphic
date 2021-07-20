
namespace GameOfLifeGraphic
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerBottom = new System.Windows.Forms.SplitContainer();
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.FillingSelector = new System.Windows.Forms.NumericUpDown();
            this.labelFill = new System.Windows.Forms.Label();
            this.ScaleSelector = new System.Windows.Forms.NumericUpDown();
            this.labelRes = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel1.SuspendLayout();
            this.splitContainerBottom.Panel2.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillingSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerBottom.IsSplitterFixed = true;
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBottom.Name = "splitContainerBottom";
            this.splitContainerBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBottom.Panel1
            // 
            this.splitContainerBottom.Panel1.Controls.Add(this.PictureBoxMain);
            // 
            // splitContainerBottom.Panel2
            // 
            this.splitContainerBottom.Panel2.Controls.Add(this.NextButton);
            this.splitContainerBottom.Panel2.Controls.Add(this.ResumeButton);
            this.splitContainerBottom.Panel2.Controls.Add(this.labelSpeed);
            this.splitContainerBottom.Panel2.Controls.Add(this.SpeedBar);
            this.splitContainerBottom.Panel2.Controls.Add(this.StopButton);
            this.splitContainerBottom.Panel2.Controls.Add(this.StartButton);
            this.splitContainerBottom.Panel2.Controls.Add(this.FillingSelector);
            this.splitContainerBottom.Panel2.Controls.Add(this.labelFill);
            this.splitContainerBottom.Panel2.Controls.Add(this.ScaleSelector);
            this.splitContainerBottom.Panel2.Controls.Add(this.labelRes);
            this.splitContainerBottom.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainerBottom.Size = new System.Drawing.Size(1194, 522);
            this.splitContainerBottom.SplitterDistance = 472;
            this.splitContainerBottom.TabIndex = 0;
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(1194, 472);
            this.PictureBoxMain.TabIndex = 0;
            this.PictureBoxMain.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(684, 19);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.Next_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(522, 19);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(75, 23);
            this.ResumeButton.TabIndex = 8;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(765, 22);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(39, 15);
            this.labelSpeed.TabIndex = 7;
            this.labelSpeed.Text = "Speed";
            // 
            // SpeedBar
            // 
            this.SpeedBar.Location = new System.Drawing.Point(806, 19);
            this.SpeedBar.Maximum = 100;
            this.SpeedBar.Minimum = 1;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(285, 45);
            this.SpeedBar.TabIndex = 6;
            this.SpeedBar.TickFrequency = 10;
            this.SpeedBar.Value = 1;
            this.SpeedBar.Scroll += new System.EventHandler(this.SpeedBar_Scroll);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(603, 19);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(441, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start ";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // FillingSelector
            // 
            this.FillingSelector.Location = new System.Drawing.Point(223, 17);
            this.FillingSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FillingSelector.Name = "FillingSelector";
            this.FillingSelector.Size = new System.Drawing.Size(120, 23);
            this.FillingSelector.TabIndex = 3;
            this.FillingSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FillingSelector.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelFill
            // 
            this.labelFill.AutoSize = true;
            this.labelFill.Location = new System.Drawing.Point(178, 19);
            this.labelFill.Name = "labelFill";
            this.labelFill.Size = new System.Drawing.Size(39, 15);
            this.labelFill.TabIndex = 2;
            this.labelFill.Text = "Filling";
            // 
            // ScaleSelector
            // 
            this.ScaleSelector.Location = new System.Drawing.Point(52, 17);
            this.ScaleSelector.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ScaleSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleSelector.Name = "ScaleSelector";
            this.ScaleSelector.Size = new System.Drawing.Size(120, 23);
            this.ScaleSelector.TabIndex = 1;
            this.ScaleSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ScaleSelector.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(12, 19);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(34, 15);
            this.labelRes.TabIndex = 0;
            this.labelRes.Text = "Scale";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 522);
            this.Controls.Add(this.splitContainerBottom);
            this.Name = "GameForm";
            this.Text = "GameOfLife";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.splitContainerBottom.Panel1.ResumeLayout(false);
            this.splitContainerBottom.Panel2.ResumeLayout(false);
            this.splitContainerBottom.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillingSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBottom;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.NumericUpDown ScaleSelector;
        private System.Windows.Forms.NumericUpDown FillingSelector;
        private System.Windows.Forms.Label labelFill;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox PictureBoxMain;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button NextButton;
    }
}

