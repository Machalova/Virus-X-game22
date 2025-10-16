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
        
        public Okno()
        {
            InitializeComponent();
            //form zachytí stisk  kláves
            this.KeyPreview = true;
            this.KeyDown += Okno_KeyDown;
            this.KeyUp += Okno_KeyUp;

            //inicalizace pc
            pictureBox_pc.Left = groupBox_hraciPlocha.Width / 2 - pictureBox_pc.Width /2;
            pictureBox_pc.Top = groupBox_hraciPlocha.Height  - pictureBox_pc.Height - 10;

            //Inicializace viru
            PictureBox stop = pictureBox_stop;

             
            PictureBox trojuhelnik= pictureBox_trojuhelnik;
           

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
