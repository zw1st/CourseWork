namespace CourseWork
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 40);
            label1.TabIndex = 0;
            label1.Text = "Жадный алгоритм. Задача о размене монет\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 242);
            label2.Name = "label2";
            label2.Size = new Size(425, 140);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(689, 100);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(652, 60);
            label4.TabIndex = 3;
            label4.Text = "Определить:\r\nВозможно ли набрать сумму S монетами данного номинала, использую жадный алгоритм.\r\nЕсли возможно, вернуть минимальное количество монет.\r\n";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMenu";
            Text = "Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}