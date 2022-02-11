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
        int totalCajero3 = 0;
        int totalCajero4 = 0;

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

            if(pictureBox1.Left >= 150)
            {
                pictureBox1.Left = 68;
                if (totalCajero1 == 4) pictureBox5.Location = new Point(68, 435);
                if (totalCajero1 == 3) pictureBox4.Location = new Point(68, 435);
                if (totalCajero1 == 2) pictureBox3.Location = new Point(68, 435);
                if (totalCajero1 == 1) pictureBox2.Location = new Point(68, 435);
                if (totalCajero1 == 0) pictureBox1.Location = new Point(68, 435);
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

            if (pictureBox6.Left >= 350)
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

        private void bntHacerFila3_Click(object sender, EventArgs e)
        {
            if (totalCajero3 == 5)
            {
                MessageBox.Show("La cola esta llena", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalCajero3++;
                timerCajero3Mover.Enabled = true;
            }
        }

        private void timerCajero3Mover_Tick(object sender, EventArgs e)
        {
            btnHacerFila3.Enabled = false;

            if (totalCajero3 == 1)
            {
                pictureBox15.Top = pictureBox15.Top - 5;
                if (pictureBox15.Top <= 160) timerCajero3Mover.Enabled = false;
            }

            if (totalCajero3 == 2)
            {
                pictureBox14.Top = pictureBox14.Top - 5;
                if (pictureBox14.Top <= 205) timerCajero3Mover.Enabled = false;
            }

            if (totalCajero3 == 3)
            {
                pictureBox13.Top = pictureBox13.Top - 5;
                if (pictureBox13.Top <= 250) timerCajero3Mover.Enabled = false;
            }

            if (totalCajero3 == 4)
            {
                pictureBox12.Top = pictureBox12.Top - 5;
                if (pictureBox12.Top <= 295) timerCajero3Mover.Enabled = false;
            }

            if (totalCajero3 == 5)
            {
                pictureBox11.Top = pictureBox11.Top - 5;
                if (pictureBox11.Top <= 340) timerCajero3Mover.Enabled = false;
            }

            if (timerCajero3Mover.Enabled == false) btnHacerFila3.Enabled = true;
        }

        private void timerCajero3Eliminar_Tick(object sender, EventArgs e)
        {
            btnDespachar3.Enabled = false;
            pictureBox15.Left = pictureBox15.Left + 5;

            if (pictureBox15.Left >= 500)
            {
                pictureBox15.Left = 425;
                if (totalCajero3 == 4) pictureBox11.Location = new Point(425, 435);
                if (totalCajero3 == 3) pictureBox12.Location = new Point(425, 435);
                if (totalCajero3 == 2) pictureBox13.Location = new Point(425, 435);
                if (totalCajero3 == 1) pictureBox14.Location = new Point(425, 435);
                if (totalCajero3 == 0) pictureBox15.Location = new Point(425, 435);
                timerCajero3Eliminar.Enabled = false;
            }
            if (timerCajero3Eliminar.Enabled == false) btnDespachar3.Enabled = true;

        }

        private void btnDespachar3_Click(object sender, EventArgs e)
        {
            if (totalCajero3 == 0) { }
            else
            {
                timerCajero3Eliminar.Enabled = true;
                totalCajero3--;
            }
        }

        private void timerCajero4Mover_Tick(object sender, EventArgs e)
        {
            btnHacerFila4.Enabled = false;

            if (totalCajero4 == 1)
            {
                pictureBox20.Top = pictureBox20.Top - 5;
                if (pictureBox20.Top <= 160) timerCajero4Mover.Enabled = false;
            }

            if (totalCajero4 == 2)
            {
                pictureBox19.Top = pictureBox19.Top - 5;
                if (pictureBox19.Top <= 205) timerCajero4Mover.Enabled = false;
            }

            if (totalCajero4 == 3)
            {
                pictureBox18.Top = pictureBox18.Top - 5;
                if (pictureBox18.Top <= 250) timerCajero4Mover.Enabled = false;
            }

            if (totalCajero4 == 4)
            {
                pictureBox17.Top = pictureBox17.Top - 5;
                if (pictureBox17.Top <= 295) timerCajero4Mover.Enabled = false;
            }

            if (totalCajero4 == 5)
            {
                pictureBox16.Top = pictureBox16.Top - 5;
                if (pictureBox16.Top <= 340) timerCajero4Mover.Enabled = false;
            }

            if (timerCajero4Mover.Enabled == false) btnHacerFila4.Enabled = true;
        }

        private void timerCajero4Eliminar_Tick(object sender, EventArgs e)
        {
            btnDespachar4.Enabled = false;
            pictureBox20.Left = pictureBox20.Left + 5;

            if (pictureBox20.Left >= 700)
            {
                pictureBox20.Left = 586;
                if (totalCajero4 == 4) pictureBox16.Location = new Point(586, 435);
                if (totalCajero4 == 3) pictureBox17.Location = new Point(586, 435);
                if (totalCajero4 == 2) pictureBox18.Location = new Point(586, 435);
                if (totalCajero4 == 1) pictureBox19.Location = new Point(586, 435);
                if (totalCajero4 == 0) pictureBox20.Location = new Point(586, 435);
                timerCajero4Eliminar.Enabled = false;
            }
            if (timerCajero4Eliminar.Enabled == false) btnDespachar4.Enabled = true;

        }

        private void btnHacerFila4_Click(object sender, EventArgs e)
        {
            if (totalCajero4 == 5)
            {
                MessageBox.Show("La cola esta llena", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalCajero4++;
                timerCajero4Mover.Enabled = true;
            }
        }

        private void btnDespachar4_Click(object sender, EventArgs e)
        {
            if (totalCajero4 == 0) { }
            else
            {
                timerCajero4Eliminar.Enabled = true;
                totalCajero4--;
            }
        }
    }
}
