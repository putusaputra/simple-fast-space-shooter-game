using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Game_Sederhana
{
    public partial class Stage2 : Form
    {
        Form1 frm;
        Stage3 stg3;
        int a = 0;
        int b = 0;
        Point posisi;
        Musuh msh;
        Boolean pelurubesar = false;
        Boolean musuh1 = false;
        Boolean musuh2 = false;
        Boolean musuh3 = false;
        Boolean musuh4 = false;
        Boolean musuh5 = false;
        Boolean musuh6 = false;
        Boolean musuh7 = false;
        Boolean musuh8 = false;
        Boolean musuh9 = false;
        Boolean musuh10 = false;
        Boolean waktuhabis = false;
        Boolean cekSampai = true;
        PictureBox peluru;
        Point lokasipeluru;
        int hitungwaktu = 10;
        int hitungmusuhyghancur = 0;
        public Stage2()
        {
            InitializeComponent();
        }

        private void Stage2_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            label3.Hide();
            buttonMenu.Hide();
            buttonNextStage.Hide();
            a = pesawat.Location.X;
            b = pesawat.Location.Y;
            msh = new Musuh();
            //musuh1
            msh.musuh1.Name = "musuh1";
            msh.musuh1.Width = 50;
            msh.musuh1.Height = 50;
            msh.musuh1.Location = new Point(210, 123);
            Bitmap gambar = new Bitmap(@"monster1.png");
            msh.musuh1.Image = (Image)gambar;
            msh.musuh1.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh1.Enabled = true;
            msh.musuh1.Visible = true;
            this.Controls.Add(msh.musuh1);
            //musuh2
            msh.musuh2.Name = "musuh2";
            msh.musuh2.Width = 50;
            msh.musuh2.Height = 50;
            msh.musuh2.Location = new Point(260, 123);
            Bitmap gambar2 = new Bitmap(@"monster1.png");
            msh.musuh2.Image = (Image)gambar;
            msh.musuh2.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh2.Enabled = true;
            msh.musuh2.Visible = true;
            this.Controls.Add(msh.musuh2);
            //musuh3
            msh.musuh3.Name = "musuh3";
            msh.musuh3.Width = 50;
            msh.musuh3.Height = 50;
            msh.musuh3.Location = new Point(310, 123);
            Bitmap gambar3 = new Bitmap(@"monster1.png");
            msh.musuh3.Image = (Image)gambar;
            msh.musuh3.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh3.Enabled = true;
            msh.musuh3.Visible = true;
            this.Controls.Add(msh.musuh3);
            //musuh4
            msh.musuh4.Name = "musuh4";
            msh.musuh4.Width = 50;
            msh.musuh4.Height = 50;
            msh.musuh4.Location = new Point(360, 123);
            Bitmap gambar4 = new Bitmap(@"monster1.png");
            msh.musuh4.Image = (Image)gambar;
            msh.musuh4.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh4.Enabled = true;
            msh.musuh4.Visible = true;
            this.Controls.Add(msh.musuh4);
            //musuh5
            msh.musuh5.Name = "musuh5";
            msh.musuh5.Width = 50;
            msh.musuh5.Height = 50;
            msh.musuh5.Location = new Point(410, 123);
            Bitmap gambar5 = new Bitmap(@"monster1.png");
            msh.musuh5.Image = (Image)gambar;
            msh.musuh5.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh5.Enabled = true;
            msh.musuh5.Visible = true;
            this.Controls.Add(msh.musuh5);
            //musuh6
            msh.musuh6.Name = "musuh6";
            msh.musuh6.Width = 50;
            msh.musuh6.Height = 50;
            msh.musuh6.Location = new Point(410, 73);
            Bitmap gambar6 = new Bitmap(@"monster1.png");
            msh.musuh6.Image = (Image)gambar;
            msh.musuh6.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh6.Enabled = true;
            msh.musuh6.Visible = true;
            this.Controls.Add(msh.musuh6);
            //musuh7
            msh.musuh7.Name = "musuh7";
            msh.musuh7.Width = 50;
            msh.musuh7.Height = 50;
            msh.musuh7.Location = new Point(360, 73);
            Bitmap gambar7 = new Bitmap(@"monster1.png");
            msh.musuh7.Image = (Image)gambar;
            msh.musuh7.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh7.Enabled = true;
            msh.musuh7.Visible = true;
            this.Controls.Add(msh.musuh7);
            //musuh8
            msh.musuh8.Name = "musuh8";
            msh.musuh8.Width = 50;
            msh.musuh8.Height = 50;
            msh.musuh8.Location = new Point(310, 73);
            Bitmap gambar8 = new Bitmap(@"monster1.png");
            msh.musuh8.Image = (Image)gambar;
            msh.musuh8.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh8.Enabled = true;
            msh.musuh8.Visible = true;
            this.Controls.Add(msh.musuh8);
            //musuh9
            msh.musuh9.Name = "musuh9";
            msh.musuh9.Width = 50;
            msh.musuh9.Height = 50;
            msh.musuh9.Location = new Point(260, 73);
            Bitmap gambar9 = new Bitmap(@"monster1.png");
            msh.musuh9.Image = (Image)gambar;
            msh.musuh9.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh9.Enabled = true;
            msh.musuh9.Visible = true;
            this.Controls.Add(msh.musuh9);
            //musuh10
            msh.musuh10.Name = "musuh10";
            msh.musuh10.Width = 50;
            msh.musuh10.Height = 50;
            msh.musuh10.Location = new Point(210, 73);
            Bitmap gambar10 = new Bitmap(@"monster1.png");
            msh.musuh10.Image = (Image)gambar;
            msh.musuh10.SizeMode = PictureBoxSizeMode.Normal;
            msh.musuh10.Enabled = true;
            msh.musuh10.Visible = true;
            this.Controls.Add(msh.musuh10);
            //labelwaktu
            label2.ForeColor = Color.BlueViolet;
            label2.Text = "Time Left : " + 10 + " " + "Detik";
            //labelscore
            label1.ForeColor = Color.BlueViolet;
            //waktumulai
            timer3.Enabled = true;
        }

        private void Stage2_KeyDown(object sender, KeyEventArgs e)
        {
            posisi = pesawat.Location;

            if (e.KeyCode == Keys.Up)
            {
                if (posisi.Y > 250)
                {
                    posisi.Y -= 50;
                    pesawat.Location = posisi;
                }
                //atas = true;
                //timer1.Enabled = true;

            }
            else if (e.KeyCode == Keys.Down)
            {
                if (posisi.Y < 327)
                {
                    posisi.Y += 50;
                    pesawat.Location = posisi;
                }
                //bawah = true;
                //timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (posisi.X > 60)
                {
                    posisi.X -= 50;
                    pesawat.Location = posisi;
                }
                //kiri = true;
                //timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (posisi.X < 599)
                {
                    posisi.X += 50;
                    pesawat.Location = posisi;
                }
                //kanan = true;
                //timer1.Enabled = true;
            }
            else if (e.KeyCode == Keys.Z)
            {
                if (waktuhabis == false)
                {
                    if (cekSampai)
                    {
                        peluru = new PictureBox();
                        peluru.Name = "peluru";
                        peluru.Width = 20;
                        peluru.Height = 20;
                        posisi.X += 25;
                        posisi.Y -= 20;
                        peluru.Location = posisi;

                        Bitmap gambar = new Bitmap(@"bullet_orange_alt.png");
                        peluru.BackgroundImage = (Image)gambar;
                        peluru.Visible = true;
                        this.Controls.Add(peluru);
                        SoundPlayer mainmusik = new SoundPlayer(@"5910_1335863658.wav");
                        mainmusik.Play();
                        pelurubesar = true;
                        timer2.Enabled = true;
                        cekSampai = false;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hitungscore = 0;
            //int hitungsplash = 0;
            //hitungsplash++;
            if (musuh1)
            {
                msh.musuh1.Width -= 10;
                msh.musuh1.Height -= 10;
                if (msh.musuh1.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh1);
                    //timer1.Enabled = false;
                    //musuh1 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh2)
            {
                msh.musuh2.Width -= 10;
                msh.musuh2.Height -= 10;
                if (msh.musuh2.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh2);
                    //timer1.Enabled = false;
                    //musuh2 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh3)
            {
                msh.musuh3.Width -= 10;
                msh.musuh3.Height -= 10;
                if (msh.musuh3.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh3);
                    //timer1.Enabled = false;
                    //musuh3 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh4)
            {
                msh.musuh4.Width -= 10;
                msh.musuh4.Height -= 10;
                if (msh.musuh4.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh4);
                    //timer1.Enabled = false;
                    //musuh4 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh5)
            {
                msh.musuh5.Width -= 10;
                msh.musuh5.Height -= 10;
                if (msh.musuh5.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh5);
                    //timer1.Enabled = false;
                    //musuh4 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh6)
            {
                msh.musuh6.Width -= 10;
                msh.musuh6.Height -= 10;
                if (msh.musuh6.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh6);
                    //timer1.Enabled = false;
                    //musuh4 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh7)
            {
                msh.musuh7.Width -= 10;
                msh.musuh7.Height -= 10;
                if (msh.musuh7.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh7);
                    //timer1.Enabled = false;
                    //musuh4 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh8)
            {
                msh.musuh8.Width -= 10;
                msh.musuh8.Height -= 10;
                if (msh.musuh8.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh8);
                    //timer1.Enabled = false;
                    //musuh4 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh9)
            {
                msh.musuh9.Width -= 10;
                msh.musuh9.Height -= 10;
                if (msh.musuh9.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh9);
                    //timer1.Enabled = false;
                    //musuh4 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }

            if (musuh10)
            {
                msh.musuh10.Width -= 10;
                msh.musuh10.Height -= 10;
                if (msh.musuh10.Size.IsEmpty)
                {
                    this.Controls.Remove(msh.musuh10);
                    //timer1.Enabled = false;
                    //musuh4 = false;
                    hitungscore += 10;
                    label1.Text = "Score : " + hitungscore;
                }
            }
            /*if (atas)
            {
                if (posisi.Y > 250)
                {
                    posisi.Y -= 50;
                    pesawat.Location = posisi;
                }
                atas = false;
                timer1.Enabled = false;
            }
            /*else if (bawah)
            {
                if (posisi.Y < 327)
                {
                    posisi.Y += 50;
                    pesawat.Location = posisi;
                }
                bawah = false;
                timer1.Enabled = false;
            }
            /*else if (kiri)
            {
                if (posisi.X > 60)
                {
                    posisi.X -= 50;
                    pesawat.Location = posisi;
                }
                kiri = false;
                timer1.Enabled = false;
            }
            else if (kanan)
            {
                if (posisi.X < 599)
                {
                    posisi.X += 50;
                    pesawat.Location = posisi;
                }
                kanan = false;
                timer1.Enabled = false;
            }*/
            
            
        }

        private Boolean menanggame(int masukan)
        {
            if (masukan == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pelurubesar)
            {
                lokasipeluru = peluru.Location;

                //posisi.X += 18;
                //posisi.Y -= 20;
                //peluru.Location = posisi;
                SoundPlayer mainmusikmenang = new SoundPlayer();

                if (peluru.Bounds.IntersectsWith(msh.musuh1.Bounds))
                {

                    msh.musuh1.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh1.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh1 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                    }

                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh2.Bounds))
                {

                    msh.musuh2.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh2.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh2 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                    }
                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh3.Bounds))
                {

                    msh.musuh3.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh3.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh3 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                    }
                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh4.Bounds))
                {

                    msh.musuh4.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh4.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh4 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                    }
                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh5.Bounds))
                {

                    msh.musuh5.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh5.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh5 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                        buttonMenu.Show();
                        buttonNextStage.Show();
                    }
                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh6.Bounds))
                {

                    msh.musuh6.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh6.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh6 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                        buttonMenu.Show();
                        buttonNextStage.Show();
                    }
                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh7.Bounds))
                {

                    msh.musuh7.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh7.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh7 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                        buttonMenu.Show();
                        buttonNextStage.Show();
                    }
                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh8.Bounds))
                {

                    msh.musuh8.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh8.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh8 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                        buttonMenu.Show();
                        buttonNextStage.Show();
                    }
                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh9.Bounds))
                {

                    msh.musuh9.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh9.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh9 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                        buttonMenu.Show();
                        buttonNextStage.Show();
                    }
                }
                else if (peluru.Bounds.IntersectsWith(msh.musuh10.Bounds))
                {

                    msh.musuh10.Image = null;
                    Bitmap gambarslime = new Bitmap(@"slimehitam.png");

                    msh.musuh10.Image = (Image)gambarslime;
                    SoundPlayer main = new SoundPlayer(@"Splat Sounds - Free Sound Effects - Splat Sound Clips - Sound Bites.wav");
                    main.Play();
                    pelurubesar = false;
                    timer2.Enabled = false;
                    hitungmusuhyghancur += 1;
                    this.Controls.Remove(peluru);
                    musuh10 = true;
                    timer1.Enabled = true;
                    cekSampai = true;
                    if (menanggame(hitungmusuhyghancur))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        waktuhabis = true;
                        panel1.Show();
                        label3.Text = "YOU WIN";
                        label3.ForeColor = Color.BlueViolet;
                        label3.BringToFront();
                        label3.Show();

                        mainmusikmenang.SoundLocation = @"you win.wav";
                        mainmusikmenang.Play();
                        buttonMenu.Show();
                        buttonNextStage.Show();
                    }
                }
                else if (peluru.Location.Y > 4)
                {
                    //posisi.Y -= 20;
                    lokasipeluru.Y -= 20;
                    peluru.Location = lokasipeluru;

                }
                else if (peluru.Location.Y < 4)
                {

                    pelurubesar = false;
                    timer2.Enabled = false;
                    this.Controls.Remove(peluru);
                    cekSampai = true;
                }

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = "Time Left : " + hitungwaktu + " " + "Detik";
            if (hitungwaktu != 0)
            {
                hitungwaktu = hitungwaktu - 1;
            }
            else
            {
                timer3.Enabled = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
                waktuhabis = true;
                panel1.Show();
                label3.BringToFront();
                label3.Show();
                SoundPlayer mainmusikkalah = new SoundPlayer(@"Freesound.org - --You Lose- - Evil- by Rocotilos.wav");
                mainmusikkalah.Play();
                buttonMenu.Show();
            }
        }

        private void Stage2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void buttonNextStage_Click(object sender, EventArgs e)
        {
            stg3 = new Stage3();
            stg3.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pesawat_Click(object sender, EventArgs e)
        {

        }
    }
}
