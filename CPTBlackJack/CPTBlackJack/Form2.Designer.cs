namespace CPTBlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcharacter = new System.Windows.Forms.ComboBox();
            this.pbcharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CPTBlackJack.Properties.Resources.Blank;
            this.label1.Location = new System.Drawing.Point(185, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO BLACKJACK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CPTBlackJack.Properties.Resources.Blank;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CPTBlackJack.Properties.Resources.Blank;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(463, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(491, 329);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(104, 27);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "Play";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::CPTBlackJack.Properties.Resources.Blank;
            this.label2.Location = new System.Drawing.Point(2, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 76);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Enter Your Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(208, 182);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 20);
            this.txtname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::CPTBlackJack.Properties.Resources.Blank;
            this.label3.Location = new System.Drawing.Point(2, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 76);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Your Avatar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbcharacter
            // 
            this.cbcharacter.FormattingEnabled = true;
            this.cbcharacter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbcharacter.Location = new System.Drawing.Point(191, 264);
            this.cbcharacter.Name = "cbcharacter";
            this.cbcharacter.Size = new System.Drawing.Size(75, 21);
            this.cbcharacter.TabIndex = 4;
            this.cbcharacter.SelectedIndexChanged += new System.EventHandler(this.Changeavatar);
            // 
            // pbcharacter
            // 
            this.pbcharacter.Location = new System.Drawing.Point(282, 227);
            this.pbcharacter.Name = "pbcharacter";
            this.pbcharacter.Size = new System.Drawing.Size(151, 105);
            this.pbcharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcharacter.TabIndex = 5;
            this.pbcharacter.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPTBlackJack.Properties.Resources.Blank;
            this.ClientSize = new System.Drawing.Size(636, 368);
            this.Controls.Add(this.pbcharacter);
            this.Controls.Add(this.cbcharacter);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbcharacter;
        private System.Windows.Forms.PictureBox pbcharacter;
    }
}