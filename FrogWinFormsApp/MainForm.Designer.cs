namespace FrogWinFormsApp
{
    partial class GameMainForm
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
            components = new System.ComponentModel.Container();
            RightPictureBox1 = new PictureBox();
            RightPictureBox2 = new PictureBox();
            RightPictureBox3 = new PictureBox();
            EmptyPictureBox = new PictureBox();
            LeftPictureBox3 = new PictureBox();
            LeftPictureBox2 = new PictureBox();
            LeftPictureBox1 = new PictureBox();
            label1 = new Label();
            CounterMovesLabel = new Label();
            LeftPictureBox4 = new PictureBox();
            RightPictureBox4 = new PictureBox();
            EndGamePictureBox = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            рестартToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            restartToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)RightPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmptyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EndGamePictureBox).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RightPictureBox1
            // 
            RightPictureBox1.Image = Properties.Resources.right_frog;
            RightPictureBox1.Location = new Point(100, 50);
            RightPictureBox1.Name = "RightPictureBox1";
            RightPictureBox1.Size = new Size(100, 100);
            RightPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            RightPictureBox1.TabIndex = 0;
            RightPictureBox1.TabStop = false;
            RightPictureBox1.Click += PictureBox3_Click;
            // 
            // RightPictureBox2
            // 
            RightPictureBox2.Image = Properties.Resources.right_frog;
            RightPictureBox2.Location = new Point(200, 50);
            RightPictureBox2.Name = "RightPictureBox2";
            RightPictureBox2.Size = new Size(100, 100);
            RightPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            RightPictureBox2.TabIndex = 1;
            RightPictureBox2.TabStop = false;
            RightPictureBox2.Click += PictureBox3_Click;
            // 
            // RightPictureBox3
            // 
            RightPictureBox3.Image = Properties.Resources.right_frog;
            RightPictureBox3.Location = new Point(300, 50);
            RightPictureBox3.Name = "RightPictureBox3";
            RightPictureBox3.Size = new Size(100, 100);
            RightPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            RightPictureBox3.TabIndex = 2;
            RightPictureBox3.TabStop = false;
            RightPictureBox3.Click += PictureBox3_Click;
            // 
            // EmptyPictureBox
            // 
            EmptyPictureBox.Image = Properties.Resources.empty_frog;
            EmptyPictureBox.Location = new Point(500, 50);
            EmptyPictureBox.Name = "EmptyPictureBox";
            EmptyPictureBox.Size = new Size(100, 100);
            EmptyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EmptyPictureBox.TabIndex = 3;
            EmptyPictureBox.TabStop = false;
            // 
            // LeftPictureBox3
            // 
            LeftPictureBox3.Image = Properties.Resources.left_frog;
            LeftPictureBox3.Location = new Point(700, 50);
            LeftPictureBox3.Name = "LeftPictureBox3";
            LeftPictureBox3.Size = new Size(100, 100);
            LeftPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            LeftPictureBox3.TabIndex = 4;
            LeftPictureBox3.TabStop = false;
            LeftPictureBox3.Click += PictureBox3_Click;
            // 
            // LeftPictureBox2
            // 
            LeftPictureBox2.Image = Properties.Resources.left_frog;
            LeftPictureBox2.Location = new Point(800, 50);
            LeftPictureBox2.Name = "LeftPictureBox2";
            LeftPictureBox2.Size = new Size(100, 100);
            LeftPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            LeftPictureBox2.TabIndex = 5;
            LeftPictureBox2.TabStop = false;
            LeftPictureBox2.Click += PictureBox3_Click;
            // 
            // LeftPictureBox1
            // 
            LeftPictureBox1.Image = Properties.Resources.left_frog;
            LeftPictureBox1.Location = new Point(900, 50);
            LeftPictureBox1.Name = "LeftPictureBox1";
            LeftPictureBox1.Size = new Size(100, 100);
            LeftPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            LeftPictureBox1.TabIndex = 6;
            LeftPictureBox1.TabStop = false;
            LeftPictureBox1.Click += PictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(102, 173);
            label1.Name = "label1";
            label1.Size = new Size(198, 37);
            label1.TabIndex = 7;
            label1.Text = "Кол-во ходов:";
            // 
            // CounterMovesLabel
            // 
            CounterMovesLabel.AutoSize = true;
            CounterMovesLabel.Font = new Font("Segoe UI", 15F);
            CounterMovesLabel.Location = new Point(289, 180);
            CounterMovesLabel.Name = "CounterMovesLabel";
            CounterMovesLabel.Size = new Size(23, 28);
            CounterMovesLabel.TabIndex = 8;
            CounterMovesLabel.Text = "0";
            // 
            // LeftPictureBox4
            // 
            LeftPictureBox4.Image = Properties.Resources.left_frog;
            LeftPictureBox4.Location = new Point(600, 50);
            LeftPictureBox4.Name = "LeftPictureBox4";
            LeftPictureBox4.Size = new Size(100, 100);
            LeftPictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            LeftPictureBox4.TabIndex = 9;
            LeftPictureBox4.TabStop = false;
            LeftPictureBox4.Click += PictureBox3_Click;
            // 
            // RightPictureBox4
            // 
            RightPictureBox4.Image = Properties.Resources.right_frog;
            RightPictureBox4.Location = new Point(400, 50);
            RightPictureBox4.Name = "RightPictureBox4";
            RightPictureBox4.Size = new Size(100, 100);
            RightPictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            RightPictureBox4.TabIndex = 10;
            RightPictureBox4.TabStop = false;
            RightPictureBox4.Click += PictureBox3_Click;
            // 
            // EndGamePictureBox
            // 
            EndGamePictureBox.Location = new Point(0, 0);
            EndGamePictureBox.Name = "EndGamePictureBox";
            EndGamePictureBox.Size = new Size(50, 50);
            EndGamePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EndGamePictureBox.TabIndex = 11;
            EndGamePictureBox.TabStop = false;
            EndGamePictureBox.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { рестартToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 26);
            // 
            // рестартToolStripMenuItem
            // 
            рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            рестартToolStripMenuItem.Size = new Size(116, 22);
            рестартToolStripMenuItem.Text = "Рестарт";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { restartToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(55, 20);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += RestartToolStripMenuItem_Click;
            // 
            // GameMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 211, 255);
            ClientSize = new Size(1084, 261);
            Controls.Add(menuStrip1);
            Controls.Add(EndGamePictureBox);
            Controls.Add(RightPictureBox4);
            Controls.Add(LeftPictureBox4);
            Controls.Add(CounterMovesLabel);
            Controls.Add(label1);
            Controls.Add(LeftPictureBox1);
            Controls.Add(LeftPictureBox2);
            Controls.Add(LeftPictureBox3);
            Controls.Add(EmptyPictureBox);
            Controls.Add(RightPictureBox3);
            Controls.Add(RightPictureBox2);
            Controls.Add(RightPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "GameMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Переселение лягушонков";
            ((System.ComponentModel.ISupportInitialize)RightPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmptyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)EndGamePictureBox).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox RightPictureBox1;
        private PictureBox RightPictureBox2;
        private PictureBox RightPictureBox3;
        private PictureBox EmptyPictureBox;
        private PictureBox LeftPictureBox3;
        private PictureBox LeftPictureBox2;
        private PictureBox LeftPictureBox1;
        private Label label1;
        private Label CounterMovesLabel;
        private PictureBox LeftPictureBox4;
        private PictureBox RightPictureBox4;
        private PictureBox EndGamePictureBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem рестартToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem restartToolStripMenuItem;
    }
}
