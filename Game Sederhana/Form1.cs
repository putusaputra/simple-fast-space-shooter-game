using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Sederhana
{
    public partial class Form1 : Form
    {
        Classic_Space_Shooter cssgame;
        How_To_Play htpgame;
        About abt;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Coral;
            this.labelstart.BackColor = Color.Coral;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Empty;
            this.labelstart.BackColor = Color.Empty;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Coral;
            this.labelhtp.BackColor = Color.Coral;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Empty;
            this.labelhtp.BackColor = Color.Empty;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.Coral;
            this.labelabout.BackColor = Color.Coral;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.Empty;
            this.labelabout.BackColor = Color.Empty;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.Coral;
            this.labelexit.BackColor = Color.Coral;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.Empty;
            this.labelexit.BackColor = Color.Empty;
        }

        private void labelstart_MouseEnter(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Coral;
            this.labelstart.BackColor = Color.Coral;
        }

        private void labelstart_MouseLeave(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Empty;
            this.labelstart.BackColor = Color.Empty;
        }

        private void labelhtp_MouseEnter(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Coral;
            this.labelhtp.BackColor = Color.Coral;
        }

        private void labelhtp_MouseLeave(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Empty;
            this.labelhtp.BackColor = Color.Empty;
        }

        private void labelabout_MouseEnter(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.Coral;
            this.labelabout.BackColor = Color.Coral;
        }

        private void labelabout_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.Empty;
            this.labelabout.BackColor = Color.Empty;
        }

        private void labelexit_MouseEnter(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.Coral;
            this.labelexit.BackColor = Color.Coral;
        }

        private void labelexit_MouseLeave(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.Empty;
            this.labelexit.BackColor = Color.Empty;
        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            cssgame = new Classic_Space_Shooter();
            cssgame.Show();
        }

        private void labelstart_Click(object sender, EventArgs e)
        {
            this.Hide();
            cssgame = new Classic_Space_Shooter();
            cssgame.Show();
        }

        private void labelhtp_Click(object sender, EventArgs e)
        {
            
            htpgame = new How_To_Play();
            htpgame.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void labelabout_Click(object sender, EventArgs e)
        {
            abt = new About();
            abt.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            htpgame = new How_To_Play();
            htpgame.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            abt = new About();
            abt.Show();
        }
    }
}
