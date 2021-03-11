namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Box02 = new System.Windows.Forms.PictureBox();
            this.Box04 = new System.Windows.Forms.PictureBox();
            this.Box01 = new System.Windows.Forms.PictureBox();
            this.Box00 = new System.Windows.Forms.PictureBox();
            this.Box06 = new System.Windows.Forms.PictureBox();
            this.Box08 = new System.Windows.Forms.PictureBox();
            this.Box03 = new System.Windows.Forms.PictureBox();
            this.Box05 = new System.Windows.Forms.PictureBox();
            this.Box07 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_playerturn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Box02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box07)).BeginInit();
            this.SuspendLayout();
            // 
            // Box02
            // 
            this.Box02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box02.Location = new System.Drawing.Point(1208, 300);
            this.Box02.Margin = new System.Windows.Forms.Padding(4);
            this.Box02.Name = "Box02";
            this.Box02.Size = new System.Drawing.Size(220, 198);
            this.Box02.TabIndex = 3;
            this.Box02.TabStop = false;
            this.Box02.Click += new System.EventHandler(this.Selectspot);
            // 
            // Box04
            // 
            this.Box04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box04.Location = new System.Drawing.Point(952, 515);
            this.Box04.Margin = new System.Windows.Forms.Padding(4);
            this.Box04.Name = "Box04";
            this.Box04.Size = new System.Drawing.Size(220, 198);
            this.Box04.TabIndex = 4;
            this.Box04.TabStop = false;
            this.Box04.Click += new System.EventHandler(this.Selectspot);
            // 
            // Box01
            // 
            this.Box01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box01.Location = new System.Drawing.Point(952, 302);
            this.Box01.Margin = new System.Windows.Forms.Padding(4);
            this.Box01.Name = "Box01";
            this.Box01.Size = new System.Drawing.Size(220, 198);
            this.Box01.TabIndex = 5;
            this.Box01.TabStop = false;
            this.Box01.Click += new System.EventHandler(this.Selectspot);
            // 
            // Box00
            // 
            this.Box00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box00.Location = new System.Drawing.Point(698, 300);
            this.Box00.Margin = new System.Windows.Forms.Padding(4);
            this.Box00.Name = "Box00";
            this.Box00.Size = new System.Drawing.Size(220, 198);
            this.Box00.TabIndex = 6;
            this.Box00.TabStop = false;
            this.Box00.Click += new System.EventHandler(this.Selectspot);
            // 
            // Box06
            // 
            this.Box06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box06.Location = new System.Drawing.Point(702, 735);
            this.Box06.Margin = new System.Windows.Forms.Padding(4);
            this.Box06.Name = "Box06";
            this.Box06.Size = new System.Drawing.Size(220, 198);
            this.Box06.TabIndex = 7;
            this.Box06.TabStop = false;
            this.Box06.Click += new System.EventHandler(this.Selectspot);
            // 
            // Box08
            // 
            this.Box08.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box08.Location = new System.Drawing.Point(1208, 735);
            this.Box08.Margin = new System.Windows.Forms.Padding(4);
            this.Box08.Name = "Box08";
            this.Box08.Size = new System.Drawing.Size(220, 198);
            this.Box08.TabIndex = 8;
            this.Box08.TabStop = false;
            this.Box08.Click += new System.EventHandler(this.Selectspot);
            // 
            // Box03
            // 
            this.Box03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box03.Location = new System.Drawing.Point(702, 517);
            this.Box03.Margin = new System.Windows.Forms.Padding(4);
            this.Box03.Name = "Box03";
            this.Box03.Size = new System.Drawing.Size(220, 198);
            this.Box03.TabIndex = 9;
            this.Box03.TabStop = false;
            this.Box03.Click += new System.EventHandler(this.Selectspot);
            // 
            // Box05
            // 
            this.Box05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box05.Location = new System.Drawing.Point(1208, 515);
            this.Box05.Margin = new System.Windows.Forms.Padding(4);
            this.Box05.Name = "Box05";
            this.Box05.Size = new System.Drawing.Size(220, 198);
            this.Box05.TabIndex = 10;
            this.Box05.TabStop = false;
            this.Box05.Click += new System.EventHandler(this.Selectspot);
            // 
            // Box07
            // 
            this.Box07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box07.Location = new System.Drawing.Point(952, 735);
            this.Box07.Margin = new System.Windows.Forms.Padding(4);
            this.Box07.Name = "Box07";
            this.Box07.Size = new System.Drawing.Size(220, 198);
            this.Box07.TabIndex = 8;
            this.Box07.TabStop = false;
            this.Box07.Click += new System.EventHandler(this.Selectspot);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 371);
            this.label1.TabIndex = 11;
            this.label1.Text = "TIC TAC GO";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1180, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 715);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(926, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 712);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(692, 717);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(748, 13);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(690, 504);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(750, 12);
            this.label5.TabIndex = 12;
            // 
            // lbl_playerturn
            // 
            this.lbl_playerturn.AutoSize = true;
            this.lbl_playerturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerturn.ForeColor = System.Drawing.Color.Gold;
            this.lbl_playerturn.Location = new System.Drawing.Point(24, 612);
            this.lbl_playerturn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_playerturn.Name = "lbl_playerturn";
            this.lbl_playerturn.Size = new System.Drawing.Size(302, 55);
            this.lbl_playerturn.TabIndex = 13;
            this.lbl_playerturn.Text = "Player\'s turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1624, 1071);
            this.Controls.Add(this.lbl_playerturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box05);
            this.Controls.Add(this.Box03);
            this.Controls.Add(this.Box07);
            this.Controls.Add(this.Box08);
            this.Controls.Add(this.Box06);
            this.Controls.Add(this.Box00);
            this.Controls.Add(this.Box01);
            this.Controls.Add(this.Box04);
            this.Controls.Add(this.Box02);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Box02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box07)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box02;
        private System.Windows.Forms.PictureBox Box04;
        private System.Windows.Forms.PictureBox Box01;
        private System.Windows.Forms.PictureBox Box00;
        private System.Windows.Forms.PictureBox Box06;
        private System.Windows.Forms.PictureBox Box08;
        private System.Windows.Forms.PictureBox Box03;
        private System.Windows.Forms.PictureBox Box05;
        private System.Windows.Forms.PictureBox Box07;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_playerturn;
    }
}

