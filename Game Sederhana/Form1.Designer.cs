namespace Game_Sederhana
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
            this.labelstart = new System.Windows.Forms.Label();
            this.labelhtp = new System.Windows.Forms.Label();
            this.labelabout = new System.Windows.Forms.Label();
            this.labelexit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelstart
            // 
            this.labelstart.AutoSize = true;
            this.labelstart.Location = new System.Drawing.Point(323, 131);
            this.labelstart.Name = "labelstart";
            this.labelstart.Size = new System.Drawing.Size(43, 13);
            this.labelstart.TabIndex = 0;
            this.labelstart.Text = "START";
            this.labelstart.Click += new System.EventHandler(this.labelstart_Click);
            this.labelstart.MouseEnter += new System.EventHandler(this.labelstart_MouseEnter);
            this.labelstart.MouseLeave += new System.EventHandler(this.labelstart_MouseLeave);
            // 
            // labelhtp
            // 
            this.labelhtp.AutoSize = true;
            this.labelhtp.Location = new System.Drawing.Point(306, 169);
            this.labelhtp.Name = "labelhtp";
            this.labelhtp.Size = new System.Drawing.Size(82, 13);
            this.labelhtp.TabIndex = 1;
            this.labelhtp.Text = "HOW TO PLAY";
            this.labelhtp.Click += new System.EventHandler(this.labelhtp_Click);
            this.labelhtp.MouseEnter += new System.EventHandler(this.labelhtp_MouseEnter);
            this.labelhtp.MouseLeave += new System.EventHandler(this.labelhtp_MouseLeave);
            // 
            // labelabout
            // 
            this.labelabout.AutoSize = true;
            this.labelabout.Location = new System.Drawing.Point(323, 207);
            this.labelabout.Name = "labelabout";
            this.labelabout.Size = new System.Drawing.Size(44, 13);
            this.labelabout.TabIndex = 2;
            this.labelabout.Text = "ABOUT";
            this.labelabout.Click += new System.EventHandler(this.labelabout_Click);
            this.labelabout.MouseEnter += new System.EventHandler(this.labelabout_MouseEnter);
            this.labelabout.MouseLeave += new System.EventHandler(this.labelabout_MouseLeave);
            // 
            // labelexit
            // 
            this.labelexit.AutoSize = true;
            this.labelexit.Location = new System.Drawing.Point(323, 246);
            this.labelexit.Name = "labelexit";
            this.labelexit.Size = new System.Drawing.Size(31, 13);
            this.labelexit.TabIndex = 3;
            this.labelexit.Text = "EXIT";
            this.labelexit.Click += new System.EventHandler(this.labelexit_Click);
            this.labelexit.MouseEnter += new System.EventHandler(this.labelexit_MouseEnter);
            this.labelexit.MouseLeave += new System.EventHandler(this.labelexit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(272, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 34);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(272, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 34);
            this.panel2.TabIndex = 5;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(272, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 34);
            this.panel3.TabIndex = 6;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(272, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 34);
            this.panel4.TabIndex = 5;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 405);
            this.Controls.Add(this.labelexit);
            this.Controls.Add(this.labelabout);
            this.Controls.Add(this.labelhtp);
            this.Controls.Add(this.labelstart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Space Invader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelstart;
        private System.Windows.Forms.Label labelhtp;
        private System.Windows.Forms.Label labelabout;
        private System.Windows.Forms.Label labelexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

