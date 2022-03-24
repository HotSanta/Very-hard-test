using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogansTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score=0;
        int count = 0;
        int loss = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            score += 1;
            pictureBox3.Visible=false;
            pictureBox2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            score = 0;
            count = 0;
            label2.Text = "0/3";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = true;
            button1.Visible = true;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            label3.Visible = true;
            label7.Visible = false;

            label8.Visible = false;

            label9.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            score += 1;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            string output = score.ToString();
            label2.Text = (output + "/3");
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            label5.Visible = true;
            label1.Visible = false;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox5.Visible = true;
            pictureBox4.Visible = true;
            label5.Visible=true;
            string output=score.ToString();
            label2.Text = (output + "/3");
            loss -= 1;
            label1.Visible = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            String output = score.ToString();
            label2.Text = output + "/3";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            string output = count.ToString();
            label4.Text = ("Time:"+output);
            if (count==20)
            {
                timer1.Stop();
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                button1.Visible = true;
                pictureBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label9.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                MessageBox.Show("You Lost. How are that slow?");
                

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            score += 1;
            string output = score.ToString();
            label2.Text = (output + "/3");
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox8.Visible = true;
            label6.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loss -= 1;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox8.Visible = true;
            label6.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            score += 1;
            string output = score.ToString();
            label2.Text = (output + "/3");
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            label2.Visible = false;
            label3.Visible = false;

            string output1 = loss.ToString();
            if (score == 3)
            {
                label8.Text = ("Great Job!");
                pictureBox10.Visible = true;
            }
            else if (score == 2)
            {
                label8.Text = ("You did okay");
                pictureBox9.Visible = true;
            }
            else
            {

                label8.Text = ("You did horrible. Won't lie");
                pictureBox9.Visible = true;
            }
            if (loss < 2)
                label9.Text = ("You only got " + output1 + " wrong and " + output + " right!");
            else label9.Text = ("You got" + output + " right!");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            loss -= 1;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            string output = score.ToString();
            string output1 = loss.ToString();
            if (score==3)
            {
                label8.Text = ("Great Job!");
                pictureBox10.Visible = true;
            }
            else if (score==2)
            {
                label8.Text = ("You did okay");
                pictureBox9.Visible = true;
            }
            else
            {

                label8.Text = ("You did horrible. Won't lie");
                pictureBox7.Visible= true;
            }
            if (loss < 2)
                label9.Text = ("You only got " + output1 + " wrong and " + output + " right!");
            else label9.Text = ("You got" + output + " right!");



        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Start();
            button1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button2.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
        }
    }
}
