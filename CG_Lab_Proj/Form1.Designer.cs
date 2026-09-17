using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CG_Lab_Proj
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
            moveXVal = new NumericUpDown();
            moveYVal = new NumericUpDown();
            button2 = new Button();
            turnXVal = new NumericUpDown();
            button3 = new Button();
            resizeXVal = new NumericUpDown();
            resizeYVal = new NumericUpDown();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            moveZVal = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            turnYVal = new NumericUpDown();
            label12 = new Label();
            turnZVal = new NumericUpDown();
            label13 = new Label();
            resizeZVal = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moveXVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moveYVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnXVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resizeXVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resizeYVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moveZVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnYVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnZVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resizeZVal).BeginInit();
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
            numericUpDown1.DecimalPlaces = 3;
            numericUpDown1.Location = new Point(838, 9);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(768, 53);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Переместить на";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(774, 168);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "Повернуть на";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(774, 303);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 5;
            label4.Text = "Масштабировать";
            // 
            // moveXVal
            // 
            moveXVal.Location = new Point(768, 95);
            moveXVal.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            moveXVal.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            moveXVal.Name = "moveXVal";
            moveXVal.Size = new Size(120, 23);
            moveXVal.TabIndex = 6;
            // 
            // moveYVal
            // 
            moveYVal.Location = new Point(906, 95);
            moveYVal.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            moveYVal.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            moveYVal.Name = "moveYVal";
            moveYVal.Size = new Size(120, 23);
            moveYVal.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(772, 124);
            button2.Name = "button2";
            button2.Size = new Size(79, 23);
            button2.TabIndex = 8;
            button2.Text = "Применить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // turnXVal
            // 
            turnXVal.Location = new Point(770, 195);
            turnXVal.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            turnXVal.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            turnXVal.Name = "turnXVal";
            turnXVal.Size = new Size(120, 23);
            turnXVal.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(774, 249);
            button3.Name = "button3";
            button3.Size = new Size(79, 23);
            button3.TabIndex = 10;
            button3.Text = "Применить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // resizeXVal
            // 
            resizeXVal.DecimalPlaces = 3;
            resizeXVal.Location = new Point(771, 335);
            resizeXVal.Name = "resizeXVal";
            resizeXVal.Size = new Size(120, 23);
            resizeXVal.TabIndex = 11;
            resizeXVal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            resizeXVal.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // resizeYVal
            // 
            resizeYVal.DecimalPlaces = 3;
            resizeYVal.Location = new Point(906, 335);
            resizeYVal.Name = "resizeYVal";
            resizeYVal.Size = new Size(120, 23);
            resizeYVal.TabIndex = 12;
            resizeYVal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            resizeYVal.ValueChanged += numericUpDown6_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(774, 392);
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
            label5.Location = new Point(771, 361);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 14;
            label5.Text = "по X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(906, 361);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 15;
            label6.Text = "по Y";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(964, 395);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Сохранить пропорции";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(770, 221);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 17;
            label7.Text = "градусов по оси X";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(772, 75);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 18;
            label8.Text = "по X:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(906, 75);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 19;
            label9.Text = "по Y";
            // 
            // moveZVal
            // 
            moveZVal.Location = new Point(1038, 95);
            moveZVal.Name = "moveZVal";
            moveZVal.Size = new Size(120, 23);
            moveZVal.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1040, 75);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 21;
            label10.Text = "по Z";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(906, 221);
            label11.Name = "label11";
            label11.Size = new Size(106, 15);
            label11.TabIndex = 23;
            label11.Text = "градусов по оси Y";
            // 
            // turnYVal
            // 
            turnYVal.Location = new Point(906, 195);
            turnYVal.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            turnYVal.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            turnYVal.Name = "turnYVal";
            turnYVal.Size = new Size(120, 23);
            turnYVal.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1038, 221);
            label12.Name = "label12";
            label12.Size = new Size(106, 15);
            label12.TabIndex = 25;
            label12.Text = "градусов по оси X";
            // 
            // turnZVal
            // 
            turnZVal.Location = new Point(1038, 195);
            turnZVal.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            turnZVal.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            turnZVal.Name = "turnZVal";
            turnZVal.Size = new Size(120, 23);
            turnZVal.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1038, 361);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 27;
            label13.Text = "по Z";
            // 
            // resizeZVal
            // 
            resizeZVal.DecimalPlaces = 3;
            resizeZVal.Location = new Point(1038, 335);
            resizeZVal.Name = "resizeZVal";
            resizeZVal.Size = new Size(120, 23);
            resizeZVal.TabIndex = 26;
            resizeZVal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 757);
            Controls.Add(label13);
            Controls.Add(resizeZVal);
            Controls.Add(label12);
            Controls.Add(turnZVal);
            Controls.Add(label11);
            Controls.Add(turnYVal);
            Controls.Add(label10);
            Controls.Add(moveZVal);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(resizeYVal);
            Controls.Add(resizeXVal);
            Controls.Add(button3);
            Controls.Add(turnXVal);
            Controls.Add(button2);
            Controls.Add(moveYVal);
            Controls.Add(moveXVal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(drawingBoard);
            Name = "Form1";
            Text = "3D отрисовка проекций";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)moveXVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)moveYVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnXVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)resizeXVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)resizeYVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)moveZVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnYVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnZVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)resizeZVal).EndInit();
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
        private NumericUpDown moveXVal;
        private NumericUpDown moveYVal;
        private Button button2;
        private NumericUpDown turnXVal;
        private Button button3;
        private NumericUpDown resizeXVal;
        private NumericUpDown resizeYVal;
        private Button button4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown moveZVal;
        private Label label10;
        private Label label11;
        private NumericUpDown turnYVal;
        private Label label12;
        private NumericUpDown turnZVal;
        private Label label13;
        private NumericUpDown resizeZVal;
    }
}
