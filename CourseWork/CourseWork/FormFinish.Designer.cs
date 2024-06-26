namespace CourseWork
{
    partial class FormFinish
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
            labelMainText = new Label();
            labelCoin = new Label();
            labelSum = new Label();
            SuspendLayout();
            // 
            // labelMainText
            // 
            labelMainText.AutoSize = true;
            labelMainText.Location = new Point(12, 9);
            labelMainText.Name = "labelMainText";
            labelMainText.Size = new Size(205, 20);
            labelMainText.TabIndex = 0;
            labelMainText.Text = "Алгоритм завершил работу.\r\n";
            // 
            // labelCoin
            // 
            labelCoin.AutoSize = true;
            labelCoin.Location = new Point(12, 41);
            labelCoin.Name = "labelCoin";
            labelCoin.Size = new Size(161, 20);
            labelCoin.TabIndex = 1;
            labelCoin.Text = "Монет использовано:";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(12, 61);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(148, 20);
            labelSum.TabIndex = 2;
            labelSum.Text = "Осталось до суммы:";
            // 
            // FormFinish
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 170);
            Controls.Add(labelSum);
            Controls.Add(labelCoin);
            Controls.Add(labelMainText);
            Name = "FormFinish";
            Text = "Финальная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMainText;
        private Label labelCoin;
        private Label labelSum;
    }
}