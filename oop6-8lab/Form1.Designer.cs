namespace oop6_8lab
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lb1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbColorViolet = new System.Windows.Forms.RadioButton();
            this.rbColorBlue = new System.Windows.Forms.RadioButton();
            this.rbColorGreen = new System.Windows.Forms.RadioButton();
            this.rbColorYellow = new System.Windows.Forms.RadioButton();
            this.rbColorRed = new System.Windows.Forms.RadioButton();
            this.rbColorBlack = new System.Windows.Forms.RadioButton();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnReGroup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(615, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 153);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(5, 122);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Отрезок";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 92);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(112, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Треугольник";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(4, 16);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(86, 17);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Количество";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 64);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Квадрат";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 36);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Круг";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 537);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.rbColorViolet);
            this.panel2.Controls.Add(this.rbColorBlue);
            this.panel2.Controls.Add(this.rbColorGreen);
            this.panel2.Controls.Add(this.rbColorYellow);
            this.panel2.Controls.Add(this.rbColorRed);
            this.panel2.Controls.Add(this.rbColorBlack);
            this.panel2.Location = new System.Drawing.Point(615, 175);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 181);
            this.panel2.TabIndex = 5;
            // 
            // rbColorViolet
            // 
            this.rbColorViolet.AutoSize = true;
            this.rbColorViolet.ForeColor = System.Drawing.Color.Violet;
            this.rbColorViolet.Location = new System.Drawing.Point(5, 154);
            this.rbColorViolet.Margin = new System.Windows.Forms.Padding(4);
            this.rbColorViolet.Name = "rbColorViolet";
            this.rbColorViolet.Size = new System.Drawing.Size(106, 21);
            this.rbColorViolet.TabIndex = 5;
            this.rbColorViolet.TabStop = true;
            this.rbColorViolet.Text = "Филетовый";
            this.rbColorViolet.UseVisualStyleBackColor = true;
            this.rbColorViolet.CheckedChanged += new System.EventHandler(this.rbColorViolet_CheckedChanged);
            // 
            // rbColorBlue
            // 
            this.rbColorBlue.AutoSize = true;
            this.rbColorBlue.ForeColor = System.Drawing.Color.Blue;
            this.rbColorBlue.Location = new System.Drawing.Point(5, 126);
            this.rbColorBlue.Margin = new System.Windows.Forms.Padding(4);
            this.rbColorBlue.Name = "rbColorBlue";
            this.rbColorBlue.Size = new System.Drawing.Size(70, 21);
            this.rbColorBlue.TabIndex = 4;
            this.rbColorBlue.TabStop = true;
            this.rbColorBlue.Text = "Синий";
            this.rbColorBlue.UseVisualStyleBackColor = true;
            this.rbColorBlue.CheckedChanged += new System.EventHandler(this.rbColorBlue_CheckedChanged);
            // 
            // rbColorGreen
            // 
            this.rbColorGreen.AutoSize = true;
            this.rbColorGreen.ForeColor = System.Drawing.Color.Green;
            this.rbColorGreen.Location = new System.Drawing.Point(5, 97);
            this.rbColorGreen.Margin = new System.Windows.Forms.Padding(4);
            this.rbColorGreen.Name = "rbColorGreen";
            this.rbColorGreen.Size = new System.Drawing.Size(88, 21);
            this.rbColorGreen.TabIndex = 3;
            this.rbColorGreen.TabStop = true;
            this.rbColorGreen.Text = "Зеленый";
            this.rbColorGreen.UseVisualStyleBackColor = true;
            this.rbColorGreen.CheckedChanged += new System.EventHandler(this.rbColorGreen_CheckedChanged);
            // 
            // rbColorYellow
            // 
            this.rbColorYellow.AutoSize = true;
            this.rbColorYellow.ForeColor = System.Drawing.Color.Gold;
            this.rbColorYellow.Location = new System.Drawing.Point(5, 69);
            this.rbColorYellow.Margin = new System.Windows.Forms.Padding(4);
            this.rbColorYellow.Name = "rbColorYellow";
            this.rbColorYellow.Size = new System.Drawing.Size(83, 21);
            this.rbColorYellow.TabIndex = 2;
            this.rbColorYellow.TabStop = true;
            this.rbColorYellow.Text = "Желтый";
            this.rbColorYellow.UseVisualStyleBackColor = true;
            this.rbColorYellow.CheckedChanged += new System.EventHandler(this.rbColorYellow_CheckedChanged);
            // 
            // rbColorRed
            // 
            this.rbColorRed.AutoSize = true;
            this.rbColorRed.ForeColor = System.Drawing.Color.Red;
            this.rbColorRed.Location = new System.Drawing.Point(5, 41);
            this.rbColorRed.Margin = new System.Windows.Forms.Padding(4);
            this.rbColorRed.Name = "rbColorRed";
            this.rbColorRed.Size = new System.Drawing.Size(87, 21);
            this.rbColorRed.TabIndex = 1;
            this.rbColorRed.TabStop = true;
            this.rbColorRed.Text = "Красный";
            this.rbColorRed.UseVisualStyleBackColor = true;
            this.rbColorRed.CheckedChanged += new System.EventHandler(this.rbColorRed_CheckedChanged);
            // 
            // rbColorBlack
            // 
            this.rbColorBlack.AutoSize = true;
            this.rbColorBlack.BackColor = System.Drawing.Color.Gainsboro;
            this.rbColorBlack.ForeColor = System.Drawing.Color.Black;
            this.rbColorBlack.Location = new System.Drawing.Point(5, 12);
            this.rbColorBlack.Margin = new System.Windows.Forms.Padding(4);
            this.rbColorBlack.Name = "rbColorBlack";
            this.rbColorBlack.Size = new System.Drawing.Size(81, 21);
            this.rbColorBlack.TabIndex = 0;
            this.rbColorBlack.TabStop = true;
            this.rbColorBlack.Text = "Черный";
            this.rbColorBlack.UseVisualStyleBackColor = false;
            this.rbColorBlack.CheckedChanged += new System.EventHandler(this.rbColorBlack_CheckedChanged);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(615, 364);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(133, 28);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "Группировка";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnReGroup
            // 
            this.btnReGroup.Location = new System.Drawing.Point(615, 401);
            this.btnReGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnReGroup.Name = "btnReGroup";
            this.btnReGroup.Size = new System.Drawing.Size(133, 28);
            this.btnReGroup.TabIndex = 7;
            this.btnReGroup.Text = "Разгруппировка";
            this.btnReGroup.UseVisualStyleBackColor = true;
            this.btnReGroup.Click += new System.EventHandler(this.btnReGroup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 475);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(615, 512);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Липкий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(776, 511);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1027, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReGroup);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbColorBlue;
        private System.Windows.Forms.RadioButton rbColorGreen;
        private System.Windows.Forms.RadioButton rbColorYellow;
        private System.Windows.Forms.RadioButton rbColorRed;
        private System.Windows.Forms.RadioButton rbColorBlack;
        private System.Windows.Forms.RadioButton rbColorViolet;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnReGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
