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
    public partial class How_To_Play : Form
    {
        public How_To_Play()
        {
            InitializeComponent();
        }

        private void How_To_Play_Load(object sender, EventArgs e)
        {
            label1.Text = "Cara Bermain :"+Environment.NewLine+
                          "- Tekan tombol Z untuk menembakkan peluru" + Environment.NewLine + 
                          "- Tekan tombol Arrow untuk menggerakan pesawat"+Environment.NewLine+
                          "- Hancurkan Alien sebanyak-banyaknya dan secepat-cepatnya"+Environment.NewLine+
                          "  agar tidak kehabisan waktu"+Environment.NewLine+
                          "- Waktu yang diberikan berbeda tiap stage";
        }
    }
}
