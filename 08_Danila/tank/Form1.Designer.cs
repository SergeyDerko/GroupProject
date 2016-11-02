namespace WindowsFormsApplication1
{
    partial class Panzer
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

      
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BulletGamer2_PicBox = new System.Windows.Forms.PictureBox();
            this.Gamer2_PicBox = new System.Windows.Forms.PictureBox();
            this.BulletGamer1_PicBox = new System.Windows.Forms.PictureBox();
            this.Gamer1_PicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulletGamer2_PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gamer2_PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletGamer1_PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gamer1_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Pole;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BulletGamer2_PicBox);
            this.panel1.Controls.Add(this.Gamer2_PicBox);
            this.panel1.Controls.Add(this.BulletGamer1_PicBox);
            this.panel1.Controls.Add(this.Gamer1_PicBox);
            this.panel1.Location = new System.Drawing.Point(150, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 480);
            this.panel1.TabIndex = 0;
            // 
            // BulletGamer2_PicBox
            // 
            this.BulletGamer2_PicBox.Location = new System.Drawing.Point(613, 287);
            this.BulletGamer2_PicBox.Name = "BulletGamer2_PicBox";
            this.BulletGamer2_PicBox.Size = new System.Drawing.Size(6, 6);
            this.BulletGamer2_PicBox.TabIndex = 3;
            this.BulletGamer2_PicBox.TabStop = false;
            // 
            // Gamer2_PicBox
            // 
            this.Gamer2_PicBox.Location = new System.Drawing.Point(166, 419);
            this.Gamer2_PicBox.Name = "Gamer2_PicBox";
            this.Gamer2_PicBox.Size = new System.Drawing.Size(32, 32);
            this.Gamer2_PicBox.TabIndex = 2;
            this.Gamer2_PicBox.TabStop = false;
            // 
            // BulletGamer1_PicBox
            // 
            this.BulletGamer1_PicBox.Location = new System.Drawing.Point(613, 264);
            this.BulletGamer1_PicBox.Name = "BulletGamer1_PicBox";
            this.BulletGamer1_PicBox.Size = new System.Drawing.Size(6, 6);
            this.BulletGamer1_PicBox.TabIndex = 1;
            this.BulletGamer1_PicBox.TabStop = false;
            // 
            // Gamer1_PicBox
            // 
            this.Gamer1_PicBox.Location = new System.Drawing.Point(476, 419);
            this.Gamer1_PicBox.Name = "Gamer1_PicBox";
            this.Gamer1_PicBox.Size = new System.Drawing.Size(32, 32);
            this.Gamer1_PicBox.TabIndex = 0;
            this.Gamer1_PicBox.TabStop = false;
            this.Gamer1_PicBox.Click += new System.EventHandler(this.Игрок1_PicBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(256, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fier(Space\\Num0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(625, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Move(WASD\\Arrows)";
            // 
            // Panzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(934, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Panzer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.panzer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BulletGamer2_PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gamer2_PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletGamer1_PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gamer1_PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Gamer1_PicBox;
        private System.Windows.Forms.PictureBox BulletGamer1_PicBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Gamer2_PicBox;
        private System.Windows.Forms.PictureBox BulletGamer2_PicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

