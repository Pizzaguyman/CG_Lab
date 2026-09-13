namespace CG_Lab
{
    partial class Form1
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
            drawingBoard = new Panel();
            button1 = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            button2 = new Button();
            numericUpDown4 = new NumericUpDown();
            button3 = new Button();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            SuspendLayout();
            // 
            // drawingBoard
            // 
            drawingBoard.BorderStyle = BorderStyle.FixedSingle;
            drawingBoard.Location = new Point(3, 3);
            drawingBoard.Name = "drawingBoard";
            drawingBoard.Size = new Size(750, 750);
            drawingBoard.TabIndex = 0;
            drawingBoard.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(973, 9);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 0;
            button1.Text = "Нарисовать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(770, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Масштаб:";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(838, 9);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(776, 72);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Переместить на";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(778, 169);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "Повернуть на";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(778, 265);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 5;
            label4.Text = "Масштабировать";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(793, 107);
            numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(945, 107);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(1083, 106);
            button2.Name = "button2";
            button2.Size = new Size(79, 23);
            button2.TabIndex = 8;
            button2.Text = "Применить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(793, 200);
            numericUpDown4.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(991, 200);
            button3.Name = "button3";
            button3.Size = new Size(79, 23);
            button3.TabIndex = 10;
            button3.Text = "Применить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(796, 297);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(120, 23);
            numericUpDown5.TabIndex = 11;
            numericUpDown5.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(931, 297);
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(120, 23);
            numericUpDown6.TabIndex = 12;
            numericUpDown6.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown6.ValueChanged += numericUpDown6_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(1083, 295);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 13;
            button4.Text = "Применить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(796, 323);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 14;
            label5.Text = "по X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(931, 323);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 15;
            label6.Text = "по Y";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(798, 350);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Сохранить соотношение";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(915, 204);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 17;
            label7.Text = "градусов";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 757);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown5);
            Controls.Add(button3);
            Controls.Add(numericUpDown4);
            Controls.Add(button2);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(drawingBoard);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel drawingBoard;
        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button button2;
        private NumericUpDown numericUpDown4;
        private Button button3;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private Button button4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Label label7;
    }
}
