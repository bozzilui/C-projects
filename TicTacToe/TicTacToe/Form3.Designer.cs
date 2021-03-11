namespace TicTacToe
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_playagain = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(64, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 154);
            this.label1.TabIndex = 1;
            this.label1.Text = "COUNTER-TERRORISTS WIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_playagain
            // 
            this.btn_playagain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_playagain.Font = new System.Drawing.Font("Wide Latin", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playagain.ForeColor = System.Drawing.Color.Gold;
            this.btn_playagain.Location = new System.Drawing.Point(246, 656);
            this.btn_playagain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_playagain.Name = "btn_playagain";
            this.btn_playagain.Size = new System.Drawing.Size(240, 77);
            this.btn_playagain.TabIndex = 2;
            this.btn_playagain.Text = "PLAY AGAIN";
            this.btn_playagain.UseVisualStyleBackColor = false;
            this.btn_playagain.Click += new System.EventHandler(this.btn_playagain_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_quit.Font = new System.Drawing.Font("Wide Latin", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.Gold;
            this.btn_quit.Location = new System.Drawing.Point(646, 656);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(240, 77);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "QUIT";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 837);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_playagain);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_playagain;
        private System.Windows.Forms.Button btn_quit;
    }
}