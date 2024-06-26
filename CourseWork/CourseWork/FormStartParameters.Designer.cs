namespace CourseWork
{
    partial class FormStartParameters
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
            numericUpDownFirstNominal = new NumericUpDown();
            numericUpDownSecondNominal = new NumericUpDown();
            numericUpDownThirdNominal = new NumericUpDown();
            labelFirstNominal = new Label();
            labelSecondNominal = new Label();
            labelThirdNominal = new Label();
            labelSum = new Label();
            numericUpDownSum = new NumericUpDown();
            buttonAccept = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstNominal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondNominal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownThirdNominal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownFirstNominal
            // 
            numericUpDownFirstNominal.Location = new Point(152, 12);
            numericUpDownFirstNominal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownFirstNominal.Name = "numericUpDownFirstNominal";
            numericUpDownFirstNominal.Size = new Size(150, 27);
            numericUpDownFirstNominal.TabIndex = 0;
            numericUpDownFirstNominal.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownSecondNominal
            // 
            numericUpDownSecondNominal.Location = new Point(152, 45);
            numericUpDownSecondNominal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSecondNominal.Name = "numericUpDownSecondNominal";
            numericUpDownSecondNominal.Size = new Size(150, 27);
            numericUpDownSecondNominal.TabIndex = 1;
            numericUpDownSecondNominal.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDownThirdNominal
            // 
            numericUpDownThirdNominal.Location = new Point(152, 78);
            numericUpDownThirdNominal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownThirdNominal.Name = "numericUpDownThirdNominal";
            numericUpDownThirdNominal.Size = new Size(150, 27);
            numericUpDownThirdNominal.TabIndex = 2;
            numericUpDownThirdNominal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelFirstNominal
            // 
            labelFirstNominal.AutoSize = true;
            labelFirstNominal.Location = new Point(14, 12);
            labelFirstNominal.Name = "labelFirstNominal";
            labelFirstNominal.Size = new Size(135, 20);
            labelFirstNominal.TabIndex = 3;
            labelFirstNominal.Text = "Первое значение:";
            // 
            // labelSecondNominal
            // 
            labelSecondNominal.AutoSize = true;
            labelSecondNominal.Location = new Point(14, 45);
            labelSecondNominal.Name = "labelSecondNominal";
            labelSecondNominal.Size = new Size(132, 20);
            labelSecondNominal.TabIndex = 4;
            labelSecondNominal.Text = "Второе значение:";
            // 
            // labelThirdNominal
            // 
            labelThirdNominal.AutoSize = true;
            labelThirdNominal.Location = new Point(14, 78);
            labelThirdNominal.Name = "labelThirdNominal";
            labelThirdNominal.Size = new Size(129, 20);
            labelThirdNominal.TabIndex = 5;
            labelThirdNominal.Text = "Третье значение:";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Location = new Point(14, 125);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(58, 20);
            labelSum.TabIndex = 6;
            labelSum.Text = "Сумма:";
            // 
            // numericUpDownSum
            // 
            numericUpDownSum.Location = new Point(152, 123);
            numericUpDownSum.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownSum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSum.Name = "numericUpDownSum";
            numericUpDownSum.Size = new Size(150, 27);
            numericUpDownSum.TabIndex = 7;
            numericUpDownSum.Value = new decimal(new int[] { 49, 0, 0, 0 });
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(188, 193);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(150, 29);
            buttonAccept.TabIndex = 8;
            buttonAccept.Text = "Принять";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(14, 193);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormStartParameters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 250);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            Controls.Add(numericUpDownSum);
            Controls.Add(labelSum);
            Controls.Add(labelThirdNominal);
            Controls.Add(labelSecondNominal);
            Controls.Add(labelFirstNominal);
            Controls.Add(numericUpDownThirdNominal);
            Controls.Add(numericUpDownSecondNominal);
            Controls.Add(numericUpDownFirstNominal);
            Name = "FormStartParameters";
            Text = "Начальные параметры";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstNominal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondNominal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownThirdNominal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownFirstNominal;
        private NumericUpDown numericUpDownSecondNominal;
        private NumericUpDown numericUpDownThirdNominal;
        private Label labelFirstNominal;
        private Label labelSecondNominal;
        private Label labelThirdNominal;
        private Label labelSum;
        private NumericUpDown numericUpDownSum;
        private Button buttonAccept;
        private Button buttonCancel;
    }
}
