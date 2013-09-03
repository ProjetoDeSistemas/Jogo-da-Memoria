using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_dda_Memoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int R, R1, R2, R3, R4, R5, R6, R7, R8, R9, R10, R11, R12, R13, R14, R15, I=0 ,J,J2;
        string A,B;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            numAleatorio.Next();
            R = numAleatorio.Next(1, 17);
            R1 = numAleatorio.Next(1, 17);
            R2 = numAleatorio.Next(1, 17);
            R3 = numAleatorio.Next(1, 17);
            R4 = numAleatorio.Next(1, 17);
            R5 = numAleatorio.Next(1, 17);
            R6 = numAleatorio.Next(1, 17);
            R7 = numAleatorio.Next(1, 17);
            R8 = numAleatorio.Next(1, 17);
            R9 =  numAleatorio.Next(1, 17);
            R10 = numAleatorio.Next(1, 17);
            R11 = numAleatorio.Next(1, 17);
            R12 = numAleatorio.Next(1, 17);
            R13 = numAleatorio.Next(1, 17);
            R14 = numAleatorio.Next(1, 17);
            R15 = numAleatorio.Next(1, 17);

          while (R == R1 || R == R2 || R == R3 || R == R4 || R == R5 || R == R6 || R == R7 || R == R8 || R == R9 || R == R10 || R == R11 || R == R12 || R == R13 || R == R14 || R == R15)
            {
                R = numAleatorio.Next(1, 17);
            }
            while (R1 == R || R1 == R2 || R1 == R3 || R1 == R4 || R1 == R5 || R1 == R6 || R1 == R7 || R1 == R8 || R1 == R9 || R1 == R10 || R1 == R11 || R1 == R12 || R1 == R13 || R1 == R14 || R1 == R15)
            {
                R1 = numAleatorio.Next(1, 17);
            }
            while (R2 == R || R2 == R1 || R2 == R3 || R2 == R4 || R2 == R5 || R2 == R6 || R2 == R7 || R2 == R8 || R2 == R9 || R2 == R10 || R2 == R11 || R2 == R12 || R2 == R13 || R2 == R14 || R2 == R15)
            {
                R2 = numAleatorio.Next(1, 17);
            }
            while (R3 == R || R3 == R1 || R3 == R2 || R3 == R4 || R3 == R5 || R3 == R6 || R3 == R7 || R3 == R8 || R3 == R9 || R3 == R10 || R3 == R11 || R3 == R12 || R3 == R13 || R3 == R14 || R3 == R15)
            {
                R3 = numAleatorio.Next(1, 17);
            }
            while (R4 == R || R4 == R1 || R4 == R2 || R4 == R3 || R4 == R5 || R4 == R6 || R4 == R7 || R4 == R8 || R4 == R9 || R4 == R10 || R4 == R11 || R4 == R12 || R4 == R13 || R4 == R14 || R4 == R15)
            {
                R4 = numAleatorio.Next(1, 17);
            }
            while (R5 == R || R5 == R1 || R5 == R2 || R5 == R3 || R5 == R4 || R5 == R6 || R5 == R7 || R5 == R8 || R5 == R9 || R5 == R10 || R5 == R11 || R5 == R12 || R5 == R13 || R5 == R14 || R5 == R15)
            {
                R5 = numAleatorio.Next(1, 17);
            }
            while (R6 == R || R6 == R1 || R6 == R2 || R6 == R3 || R6 == R4 || R6 == R5 || R6 == R7 || R6 == R8 || R6 == R9 || R6 == R10 || R6 == R11 || R6 == R12 || R6 == R13 || R6 == R14 || R6 == R15)
            {
                R6 = numAleatorio.Next(1, 17);
            }
            while (R7 == R || R7 == R1 || R7 == R2 || R7 == R3 || R7 == R4 || R7 == R5 || R7 == R6 || R7 == R8 || R7 == R9 || R7 == R10 || R7 == R11 || R7 == R12 || R7 == R13 || R7 == R14 || R7 == R15)
            {
                R7 = numAleatorio.Next(1, 17);
            }
            while(R8 == R || R8 == R1 || R8 == R2 || R8 == R3 || R8 == R4 || R8 == R5 || R8 == R6 || R8 == R7 || R8 == R9 || R8 == R10 || R8 == R11 || R8 == R12 || R8 == R13 || R8 == R14 || R8 == R15)
            {
                R8 = numAleatorio.Next(1, 17);
            }
            while (R9 == R || R9 == R1 || R9 == R2 || R9 == R3 || R9 == R4 || R9 == R5 || R9 == R6 || R9 == R7 || R9 == R8 || R9 == R10 || R9 == R11 || R9 == R12 || R9 == R13 || R9 == R14 || R9 == R15)
            {
                R9 = numAleatorio.Next(1, 17);
            }
            while (R10 == R || R10 == R1 || R10 == R2 || R10 == R3 || R10 == R4 || R10 == R5 || R10 == R6 || R10 == R7 || R10 == R8 || R10 == R9 || R10 == R11 || R10 == R12 || R10 == R13 || R10 == R14 || R10 == R15)
            {
                R10 = numAleatorio.Next(1, 17);
            }
            while(R11 == R || R11 == R1 || R11 == R2 || R11 == R3 || R11 == R4 || R11 == R5 || R11 == R6 || R11 == R7 || R11 == R8 || R11 == R9 || R11 == R10 || R11 == R12 || R11 == R13 || R11 == R14 || R11 == R15)
            {
                R11 = numAleatorio.Next(1, 17);
            }
           while(R12 == R || R12 == R1 || R12 == R2 || R12 == R3 || R12 == R4 || R12 == R5 || R12 == R6 || R12 == R7 || R12 == R8 || R12 == R9 || R12 == R10 || R12 == R11 || R12 == R13 || R12 == R14 || R12 == R15)
            {
                R12 = numAleatorio.Next(1, 17);
            }
           while(R13 == R || R13 == R1 || R13 == R2 || R13 == R3 || R13 == R4 || R13 == R5 || R13 == R6 || R13 == R7 || R13 == R8 || R13 == R9 || R13 == R10 || R13 == R11 || R13 == R12 || R13 == R14 || R13 == R15)
            {
                R13 = numAleatorio.Next(1, 17);
            }
           while(R14 == R || R14 == R1 || R14 == R2 || R14 == R3 || R14 == R4 || R14 == R5 || R14 == R6 || R14 == R7 || R14 == R8 || R14 == R9 || R14 == R10 || R14 == R11 || R14 == R12 || R14 == R13 || R14 == R15)
            {
                R14 = numAleatorio.Next(1, 17);
            }
           while(R15 == R || R15 == R1 || R15 == R2 || R15 == R3 || R15 == R4 || R15 == R5 || R15 == R6 || R15 == R7 || R15 == R8 || R15 == R9 || R15 == R10 || R15 == R11 || R15 == R12 || R15 == R13 || R13 == R14)
            {
                R15 = numAleatorio.Next(1, 17);
            }

           pictureBox3.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\"+ Convert.ToString(R)+".jpg");
           pictureBox7.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R1) + ".jpg");
             pictureBox10.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R2) + ".jpg");
             pictureBox13.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R3) + ".jpg");
             pictureBox21.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R4) + ".jpg");
             pictureBox20.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R5) + ".jpg");
             pictureBox19.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R6) + ".jpg");
             pictureBox18.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R7) + ".jpg");
             pictureBox25.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R8) + ".jpg");
             pictureBox24.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R9) + ".jpg");
             pictureBox23.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R10) + ".jpg");
             pictureBox22.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R11) + ".jpg");
             pictureBox29.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R12) + ".jpg");
             pictureBox28.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R13) + ".jpg");
             pictureBox27.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R14) + ".jpg");
             pictureBox26.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R15) + ".jpg");


            
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button1.Visible = false;
            if (I == 1)
            
                
            {
                pictureBox3.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\"+Convert.ToString(R)+".jpg");


                J = R;
                A = Convert.ToString(R);
                button1.Name = A;

                
            }
                if (I==2){

                    pictureBox3.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R) + ".jpg");
                    if (R == J - 8 || R == J + 8)
                    {
                        MessageBox.Show("ACERTOU");
                        I = 0;
                    }
                    else
                    {
                        button1.Visible = true;
                        I = 0;
                        
                    }
                    }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            I = I + 1;


            button2.Visible = false;
            if (I == 1)
            
                
            {
                pictureBox7.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R1) + ".jpg");

                J = R1;
                J2 = 2;
                
            }
            if (I == 2)
            {
                
                pictureBox7.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R1) + ".jpg");
                if (R1 == J - 8 || R1 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
                else
                {
                    button2.Visible = true;
                    I = 0;
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            I = I + 1;

            button3.Visible = false;
            if (I == 1)
            {
                pictureBox10.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R2) + ".jpg");

                J = R2;
                
            }
            if (I == 2)
            {

                pictureBox10.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R2) + ".jpg");
                if (R2 == J - 8 || R2 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
                else
                {
                    button3.Visible = true;
                    I = 0;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button4.Visible = false;
            if (I == 1)
            {
                pictureBox13.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R3) + ".jpg");

                J = R3;
            }
            if (I == 2)
            {

                pictureBox13.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R3) + ".jpg");
                if (R3 == J - 8 || R3 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
                else
                {
                    button4.Visible = true;
                    I = 0;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button7.Visible = false;
            if (I == 1)
            {
                pictureBox21.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R4) + ".jpg");

                J = R4;
            }
            if (I == 2)
            {

                pictureBox21.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R4) + ".jpg");
                if (R4 == J - 8 || R4 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
                else
                {
                    button7.Visible = true;
                    I = 0;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button6.Visible = false;
            if (I == 1)
            {
                pictureBox20.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R5) + ".jpg");

                J = R5;
            }
            if (I == 2)
            {

                pictureBox20.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R5) + ".jpg");
                if (R5 == J - 8 || R5 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
                else
                {
                    button6.Visible = true;
                    I = 0;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button5.Visible = false;
            if (I == 1)
            {
                pictureBox19.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R6) + ".jpg");

                J = R6;
            }
            if (I == 2)
            {

                pictureBox19.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R6) + ".jpg");
                if (R6 == J - 8 || R6 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button14.Visible = false;
            if (I == 1)
            {
                pictureBox18.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R7) + ".jpg");

                J = R7;
            }
            if (I == 2)
            {

                pictureBox18.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R7) + ".jpg");
                if (R7 == J - 8 || R7 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button10.Visible = false;
            if (I == 1)
            {
                pictureBox25.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R8) + ".jpg");

                J = R8;
            }
            if (I == 2)
            {

                pictureBox25.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R8) + ".jpg");
                if (R8 == J - 8 || R8 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button9.Visible = false;
            if (I == 1)
            {
                pictureBox24.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R9) + ".jpg");

                J = R9;
            }
            if (I == 2)
            {

                pictureBox24.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R9) + ".jpg");
                if (R9 == J - 8 || R9 == J + 8)
                {
                    MessageBox.Show("ACERTOU");
                    I = 0;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            I = I + 1;
            button8.Visible = false;
            if (I == 1)
            {
                pictureBox23.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R10) + ".jpg");

                J = R10;
            }
            if (I == 2)
            {

                pictureBox23.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R10) + ".jpg");
                if (R10 == J - 8)
                    MessageBox.Show("ACERTOU");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button15.Visible = false;
            if (I == 1)
            {
                pictureBox22.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R11) + ".jpg");

                J = R11;
            }
            if (I == 2)
            {

                pictureBox22.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R11) + ".jpg");
                if (R11 == J - 8 || R11 == J + 8)
                    MessageBox.Show("ACERTOU");
                I = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button13.Visible = false;
            if (I == 1)
            {
                pictureBox29.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R12) + ".jpg");

                J = R12;
            }
            if (I == 2)
            {

                pictureBox29.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R12) + ".jpg");
                if (R12 == J - 8 || R12 == J + 8)
                    MessageBox.Show("ACERTOU");
                I = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button12.Visible = false;
            if (I == 1)
            {
                pictureBox28.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R13) + ".jpg");

                J = R13;
            }
            if (I == 2)
            {

                pictureBox28.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R13) + ".jpg");
                if (R13 == J - 8 || R13 == J + 8)
                    MessageBox.Show("ACERTOU");
                I = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button11.Visible = false;
            if (I == 1)
            {
                pictureBox27.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R14) + ".jpg");

                J = R14;
            }
            if (I == 2)
            {

                pictureBox27.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R14) + ".jpg");
                if (R14 == J - 8 || R14 == J + 8)
                    MessageBox.Show("ACERTOU");
                I = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            I = I + 1;

            button16.Visible = false;
            if (I == 1)
            {
                pictureBox26.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R15) + ".jpg");

                J = R15;
            }
            if (I == 2)
            {

                pictureBox26.Image = Image.FromFile(@"C:\Jogo dda Memoria\Jogo dda Memoria\Resources\" + Convert.ToString(R15) + ".jpg");
                if (R15 == J - 8 || R == J + 8)
                    MessageBox.Show("ACERTOU");
            }
        }
     
    }
}
