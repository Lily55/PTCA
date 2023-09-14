namespace DZ_PTCA
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            myPictureBox = new PictureBox();
            button4 = new Button();
            myCondition = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            myHappiness = new Label();
            ((System.ComponentModel.ISupportInitialize)myPictureBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(90, 50);
            button1.Name = "button1";
            button1.Size = new Size(238, 81);
            button1.TabIndex = 0;
            button1.Text = "Живот урчит";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(90, 160);
            button2.Name = "button2";
            button2.Size = new Size(238, 81);
            button2.TabIndex = 1;
            button2.Text = "Глаза закрываются";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Purple;
            button3.Location = new Point(90, 266);
            button3.Name = "button3";
            button3.Size = new Size(238, 81);
            button3.TabIndex = 3;
            button3.Text = "Дедлайн приближается";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // myPictureBox
            // 
            myPictureBox.Image = Properties.Resources.cat_studying;
            myPictureBox.Location = new Point(706, 50);
            myPictureBox.Name = "myPictureBox";
            myPictureBox.Size = new Size(593, 421);
            myPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            myPictureBox.TabIndex = 4;
            myPictureBox.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightPink;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Purple;
            button4.Location = new Point(104, 467);
            button4.Name = "button4";
            button4.Size = new Size(210, 90);
            button4.TabIndex = 5;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button5_Click;
            // 
            // myCondition
            // 
            myCondition.AutoSize = true;
            myCondition.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            myCondition.ForeColor = Color.Purple;
            myCondition.Location = new Point(1165, 479);
            myCondition.Name = "myCondition";
            myCondition.Size = new Size(125, 54);
            myCondition.TabIndex = 6;
            myCondition.Text = "Сплю";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(547, 479);
            label1.Name = "label1";
            label1.Size = new Size(612, 54);
            label1.TabIndex = 7;
            label1.Text = "Текущее физическое состояние:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Location = new Point(1369, 557);
            panel1.Name = "panel1";
            panel1.Size = new Size(97, 46);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(547, 549);
            label2.Name = "label2";
            label2.Size = new Size(577, 54);
            label2.TabIndex = 9;
            label2.Text = "Текущее душевное состояние:";
            // 
            // myHappiness
            // 
            myHappiness.AutoSize = true;
            myHappiness.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            myHappiness.ForeColor = Color.Purple;
            myHappiness.Location = new Point(1130, 549);
            myHappiness.Name = "myHappiness";
            myHappiness.Size = new Size(210, 54);
            myHappiness.TabIndex = 10;
            myHappiness.Text = "Счастлива";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1493, 641);
            Controls.Add(myHappiness);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(myCondition);
            Controls.Add(button4);
            Controls.Add(myPictureBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)myPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox myPictureBox;
        private Button button4;
        private Label myCondition;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label myHappiness;
    }
}