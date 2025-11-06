using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HraRaketa
{
    public partial class Okno : Form
    {
        int pcSpeed = 10;               //rychlost pc jak rychle se pohybuje
        int stopSpeed = 10;             //rychlost padajících virů
        int trojuhelnikSpeed = 10;
        int score = 0;                  // skore
        int lives = 3;                  //životy
        int fuel = 100;                 // palivo
        Random rnd = new Random();

        bool moveLeft = false;          // ovládání pc
        bool moveRight = false;

        // pole viru a srdcí
        PictureBox[] stop;
        PictureBox[] trojuhelnik;
        PictureBox[] srdce;
        private PictureBox[] viry;

        public Okno()
        {
            InitializeComponent();

            //form zachytí stisk  kláves
            this.KeyPreview = true;
            this.KeyDown += Okno_KeyDown; // definování metody pro stisk z klávesnice
            this.KeyUp += Okno_KeyUp;

            //inicalizace pc
            pictureBox_pc.Left = groupBox_hraciPlocha.Width / 2 - pictureBox_pc.Width /2;
            pictureBox_pc.Top = groupBox_hraciPlocha.Height  - pictureBox_pc.Height - 10;

            //Inicializace viru
            PictureBox stop = pictureBox_stop; // stop z návrhu
            PictureBox stop2 = new PictureBox();
            stop2.Size = stop.Size;
            stop2.SizeMode = PictureBoxSizeMode.Zoom;
            stop2.Image = stop.Image;
            groupBox_hraciPlocha.Controls.Add(stop2);

            viry = new PictureBox[] { stop, stop2 };
            foreach (var stop in viry)
                Resetstop(stop);

            // inicializace srdcí
            srdce = new PictureBox[] { pictureBox_srdce1, pictureBox_srdce2, pictureBox_srdce3 };


            Casovac.Interval = 50;
            Casovac.Tick += gameloop


            
           

        }

        private void Okno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = true;
            if(e.KeyCode == Keys.Right) moveRight = true;
        }

        private void Okno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = false;
            if (e.KeyCode == Keys.Right) moveRight = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void txt_palivo_Click(object sender, EventArgs e)
        {

        }

        private void txt_zivoty_Click(object sender, EventArgs e)
        {

        }
    }
}
