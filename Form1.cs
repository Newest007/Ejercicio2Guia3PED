using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_Guía_3
{
    public partial class Form1 : Form
    {

        int totalCajero1 = 0; //Objeto usado para calcular el numero de personas en el cajero 1
        int totalCajero2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(totalCajero1 == 5)
            {
                MessageBox.Show("La cola esta llena", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalCajero1++;
                timerCajero1Mover.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnHacerFila1.Enabled = false;

            if(totalCajero1 == 1)
            {
                pictureBox1.Top = pictureBox1.Top - 5;
                if (pictureBox1.Top <= 160) timerCajero1Mover.Enabled = false;
            }

            if(totalCajero1 == 2)
            {
                pictureBox2.Top = pictureBox2.Top - 5;
                if (pictureBox2.Top <= 205) timerCajero1Mover.Enabled = false;
            }

            if(totalCajero1 == 3)
            {
                pictureBox3.Top = pictureBox3.Top - 5;
                if (pictureBox3.Top <= 250) timerCajero1Mover.Enabled = false;
            }

            if (totalCajero1 == 4)
            {
                pictureBox4.Top = pictureBox4.Top - 5;
                if (pictureBox4.Top <= 295) timerCajero1Mover.Enabled = false;
            }

            if(totalCajero1 == 5)
            {
                pictureBox5.Top = pictureBox5.Top - 5;
                if (pictureBox5.Top <= 340) timerCajero1Mover.Enabled = false;
            }

            if (timerCajero1Mover.Enabled == false) btnHacerFila1.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnDespachar1.Enabled = false;
            pictureBox1.Left = pictureBox1.Left + 5;

            if(pictureBox1.Left >= 100)
            {
                pictureBox1.Left = 68;
                if (totalCajero1 == 4) pictureBox5.Location = new Point(68, 395);
                if (totalCajero1 == 3) pictureBox4.Location = new Point(68, 395);
                if (totalCajero1 == 2) pictureBox3.Location = new Point(68, 395);
                if (totalCajero1 == 1) pictureBox2.Location = new Point(68, 395);
                if (totalCajero1 == 0) pictureBox1.Location = new Point(68, 395);
                timerCajero1Eliminar.Enabled = false;
            }
            if (timerCajero1Eliminar.Enabled == false) btnDespachar1.Enabled = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (totalCajero1 == 0) { }
            else
            {
                timerCajero1Eliminar.Enabled = true;
                totalCajero1--;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(totalCajero2 == 5)
            {
                MessageBox.Show("La cola esta llena", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalCajero2++;
                timerCajero2Mover.Enabled = true;
            }
        }

        private void timerCajero2Mover_Tick(object sender, EventArgs e)
        {
            btnHacerFila2.Enabled = false;

            if (totalCajero2 == 1)
            {
                pictureBox6.Top = pictureBox6.Top - 5;
                if (pictureBox6.Top <= 160) timerCajero2Mover.Enabled = false;
            }

            if (totalCajero2 == 2)
            {
                pictureBox7.Top = pictureBox7.Top - 5;
                if (pictureBox7.Top <= 205) timerCajero2Mover.Enabled = false;
            }

            if (totalCajero2 == 3)
            {
                pictureBox8.Top = pictureBox8.Top - 5;
                if (pictureBox8.Top <= 250) timerCajero2Mover.Enabled = false;
            }

            if (totalCajero2 == 4)
            {
                pictureBox9.Top = pictureBox9.Top - 5;
                if (pictureBox9.Top <= 295) timerCajero2Mover.Enabled = false;
            }

            if (totalCajero2 == 5)
            {
                pictureBox10.Top = pictureBox10.Top - 5;
                if (pictureBox10.Top <= 340) timerCajero2Mover.Enabled = false;
            }

            if (timerCajero2Mover.Enabled == false) btnHacerFila2.Enabled = true;

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (totalCajero2 == 0) { }
            else
            {
                timerCajero2Eliminar.Enabled = true;
                totalCajero2--;
            }
        }

        private void timerCajero2Eliminar_Tick(object sender, EventArgs e)
        {
            btnDespachar2.Enabled = false;
            pictureBox6.Left = pictureBox6.Left + 5;

            if (pictureBox6.Left >= 300)
            {
                pictureBox6.Left = 250;
                if (totalCajero2 == 4) pictureBox10.Location = new Point(250, 417);
                if (totalCajero2 == 3) pictureBox9.Location = new Point(250, 417);
                if (totalCajero2 == 2) pictureBox8.Location = new Point(250, 417);
                if (totalCajero2 == 1) pictureBox7.Location = new Point(250, 417);
                if (totalCajero2 == 0) pictureBox6.Location = new Point(250, 417);
                timerCajero2Eliminar.Enabled = false;
            }
            if (timerCajero2Eliminar.Enabled == false) btnDespachar2.Enabled = true;

        }
    }
}
