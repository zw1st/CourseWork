namespace CourseWork
{
    partial class FormVisualizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxVisualizer = new PictureBox();
            labelCoin = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            labelRemainToSum = new Label();
            buttonMakeStepForward = new Button();
            buttonStart = new Button();
            labelCurrentRemain = new Label();
            labelCoinAmout = new Label();
            buttonMakeStepReverse = new Button();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            InfoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisualizer).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxVisualizer
            // 
            pictureBoxVisualizer.BackColor = SystemColors.Control;
            pictureBoxVisualizer.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxVisualizer.Location = new Point(158, 36);
            pictureBoxVisualizer.Name = "pictureBoxVisualizer";
            pictureBoxVisualizer.Size = new Size(630, 270);
            pictureBoxVisualizer.TabIndex = 0;
            pictureBoxVisualizer.TabStop = false;
            // 
            // labelCoin
            // 
            labelCoin.AutoSize = true;
            labelCoin.Location = new Point(158, 309);
            labelCoin.Name = "labelCoin";
            labelCoin.Size = new Size(140, 20);
            labelCoin.TabIndex = 3;
            labelCoin.Text = "Количество монет:";
            // 
            // labelRemainToSum
            // 
            labelRemainToSum.AutoSize = true;
            labelRemainToSum.Location = new Point(158, 329);
            labelRemainToSum.Name = "labelRemainToSum";
            labelRemainToSum.Size = new Size(148, 20);
            labelRemainToSum.TabIndex = 4;
            labelRemainToSum.Text = "Осталось до суммы:";
            // 
            // buttonMakeStepForward
            // 
            buttonMakeStepForward.Location = new Point(12, 409);
            buttonMakeStepForward.Name = "buttonMakeStepForward";
            buttonMakeStepForward.Size = new Size(152, 29);
            buttonMakeStepForward.TabIndex = 6;
            buttonMakeStepForward.Text = "Шаг вперед\r\n";
            buttonMakeStepForward.UseVisualStyleBackColor = true;
            buttonMakeStepForward.Click += buttonMakeStep_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 374);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(310, 29);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelCurrentRemain
            // 
            labelCurrentRemain.AutoSize = true;
            labelCurrentRemain.Location = new Point(312, 329);
            labelCurrentRemain.Name = "labelCurrentRemain";
            labelCurrentRemain.Size = new Size(0, 20);
            labelCurrentRemain.TabIndex = 8;
            // 
            // labelCoinAmout
            // 
            labelCoinAmout.AutoSize = true;
            labelCoinAmout.Location = new Point(306, 309);
            labelCoinAmout.Name = "labelCoinAmout";
            labelCoinAmout.Size = new Size(0, 20);
            labelCoinAmout.TabIndex = 9;
            // 
            // buttonMakeStepReverse
            // 
            buttonMakeStepReverse.Location = new Point(170, 409);
            buttonMakeStepReverse.Name = "buttonMakeStepReverse";
            buttonMakeStepReverse.Size = new Size(152, 29);
            buttonMakeStepReverse.TabIndex = 10;
            buttonMakeStepReverse.Text = "Шаг назад";
            buttonMakeStepReverse.UseVisualStyleBackColor = true;
            buttonMakeStepReverse.Click += buttonMakeStepReverse_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "courseWork.txt";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "courseWork.txt";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 11;
            menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, LoadToolStripMenuItem, InfoToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveToolStripMenuItem.Size = new Size(231, 26);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.AccessibleName = "";
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            LoadToolStripMenuItem.Size = new Size(231, 26);
            LoadToolStripMenuItem.Text = "Загрузить";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            InfoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            InfoToolStripMenuItem.Size = new Size(231, 26);
            InfoToolStripMenuItem.Text = "Информация";
            InfoToolStripMenuItem.Click += InfoToolStripMenuItem_Click;
            // 
            // FormVisualizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMakeStepReverse);
            Controls.Add(labelCoinAmout);
            Controls.Add(labelCurrentRemain);
            Controls.Add(buttonStart);
            Controls.Add(buttonMakeStepForward);
            Controls.Add(labelRemainToSum);
            Controls.Add(labelCoin);
            Controls.Add(pictureBoxVisualizer);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormVisualizer";
            Text = "Визуализация";
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisualizer).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxVisualizer;
        private Label labelCoin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label labelRemainToSum;
        private Button buttonMakeStepForward;
        private Button buttonStart;
        private Label labelCurrentRemain;
        private Label labelCoinAmout;
        private Button buttonMakeStepReverse;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private ToolStripMenuItem InfoToolStripMenuItem;
    }
}