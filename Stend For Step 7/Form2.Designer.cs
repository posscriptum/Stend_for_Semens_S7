namespace Stend_For_Step_7
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timerLevelLicuide = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberIndicator1 = new System.Windows.Forms.Label();
            this.numberIndicator2 = new System.Windows.Forms.Label();
            this.numberIndicator3 = new System.Windows.Forms.Label();
            this.numberIndicator4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.timerButtons = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SourceOfInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Stend_For_Step_7.Properties.Resources.Tank06;
            this.pictureBox3.Location = new System.Drawing.Point(140, 536);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(424, 520);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stend_For_Step_7.Properties.Resources.Tank04;
            this.pictureBox2.Location = new System.Drawing.Point(140, 575);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Stend_For_Step_7.Properties.Resources.Tank01;
            this.pictureBox1.Location = new System.Drawing.Point(140, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(140, 616);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(424, 112);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // timerLevelLicuide
            // 
            this.timerLevelLicuide.Tick += new System.EventHandler(this.timerLevelLicuide_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level - PQW 226";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 91);
            this.button1.TabIndex = 5;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(602, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Stend_For_Step_7.Properties.Resources.Green_Button_Poped;
            this.pictureBox5.Location = new System.Drawing.Point(608, 247);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Stend_For_Step_7.Properties.Resources.Green_Button_Poped;
            this.pictureBox6.Location = new System.Drawing.Point(608, 374);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(90, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Setpoint - PIW 352";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Q5.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Q5.2";
            // 
            // numberIndicator1
            // 
            this.numberIndicator1.AutoSize = true;
            this.numberIndicator1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberIndicator1.Location = new System.Drawing.Point(389, 29);
            this.numberIndicator1.Name = "numberIndicator1";
            this.numberIndicator1.Size = new System.Drawing.Size(39, 44);
            this.numberIndicator1.TabIndex = 91;
            this.numberIndicator1.Text = "0";
            // 
            // numberIndicator2
            // 
            this.numberIndicator2.AutoSize = true;
            this.numberIndicator2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberIndicator2.Location = new System.Drawing.Point(349, 29);
            this.numberIndicator2.Name = "numberIndicator2";
            this.numberIndicator2.Size = new System.Drawing.Size(39, 44);
            this.numberIndicator2.TabIndex = 90;
            this.numberIndicator2.Text = "0";
            // 
            // numberIndicator3
            // 
            this.numberIndicator3.AutoSize = true;
            this.numberIndicator3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberIndicator3.Location = new System.Drawing.Point(310, 29);
            this.numberIndicator3.Name = "numberIndicator3";
            this.numberIndicator3.Size = new System.Drawing.Size(39, 44);
            this.numberIndicator3.TabIndex = 89;
            this.numberIndicator3.Text = "0";
            // 
            // numberIndicator4
            // 
            this.numberIndicator4.AutoSize = true;
            this.numberIndicator4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberIndicator4.Location = new System.Drawing.Point(273, 29);
            this.numberIndicator4.Name = "numberIndicator4";
            this.numberIndicator4.Size = new System.Drawing.Size(39, 44);
            this.numberIndicator4.TabIndex = 88;
            this.numberIndicator4.Text = "0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Stend_For_Step_7.Properties.Resources.glass;
            this.pictureBox7.Location = new System.Drawing.Point(259, 13);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(179, 76);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 87;
            this.pictureBox7.TabStop = false;
            // 
            // timerButtons
            // 
            this.timerButtons.Tick += new System.EventHandler(this.timerButtons_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 630);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 40);
            this.button3.TabIndex = 92;
            this.button3.Text = "Level from button";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SourceOfInput
            // 
            this.SourceOfInput.AutoSize = true;
            this.SourceOfInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceOfInput.Location = new System.Drawing.Point(444, 29);
            this.SourceOfInput.Name = "SourceOfInput";
            this.SourceOfInput.Size = new System.Drawing.Size(172, 46);
            this.SourceOfInput.TabIndex = 93;
            this.SourceOfInput.Text = "PIW 352";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 699);
            this.Controls.Add(this.SourceOfInput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numberIndicator1);
            this.Controls.Add(this.numberIndicator2);
            this.Controls.Add(this.numberIndicator3);
            this.Controls.Add(this.numberIndicator4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timerLevelLicuide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numberIndicator1;
        private System.Windows.Forms.Label numberIndicator2;
        private System.Windows.Forms.Label numberIndicator3;
        private System.Windows.Forms.Label numberIndicator4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timerButtons;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label SourceOfInput;
    }
}