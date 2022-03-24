using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9_2
{
    public partial class Form1 : Form
    {

        double ticket_price = 0;
        double total_price = 0;
        int iPerson = 0;
        int gPerson = 0;
        bool isGroup = false;
        bool mealbox = false;
        bool beveage = false;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            radioButton1.Checked = true;
            textBox1.Enabled = false;
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday || dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                radioButton1.Text = "1日券600元";
            }
            else
            {
                radioButton1.Text = "1日券540元";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isGroup)
            {
                try
                {
                    gPerson = int.Parse(textBox1.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("請輸入正整數！", "錯誤", MessageBoxButtons.OK);
                    return;
                }

                if (gPerson >= 7)
                {
                    if (mealbox && beveage)
                    {
                        total_price = (ticket_price * iPerson) + (ticket_price * gPerson * 0.9) + (iPerson + gPerson) * 130;
                    }
                    else if (mealbox)
                    {
                        total_price = (ticket_price * iPerson) + (ticket_price * gPerson * 0.9) + (iPerson + gPerson) * 80;
                    }
                    else if (beveage)
                    {
                        total_price = (ticket_price * iPerson) + (ticket_price * gPerson * 0.9) + (iPerson + gPerson) * 50;
                    }
                }
                else
                {
                    MessageBox.Show("團體價至少要7(含)人", "提示", MessageBoxButtons.OK);
                    if (mealbox && beveage)
                    {
                        total_price = (ticket_price * iPerson) + (ticket_price * gPerson) + (iPerson + gPerson) * 130;
                    }
                    else if (mealbox)
                    {
                        total_price = (ticket_price * iPerson) + (ticket_price * gPerson) + (iPerson + gPerson) * 80;
                    }
                    else if (beveage)
                    {
                        total_price = (ticket_price * iPerson) + (ticket_price * gPerson) + (iPerson + gPerson) * 50;
                    }
                }
            }
            else
            {
                if (mealbox && beveage)
                {
                    total_price = (ticket_price * iPerson) + (iPerson * 130);
                }
                else if (mealbox)
                {
                    total_price = (ticket_price * iPerson) + (iPerson * 80);
                }
                else if (beveage)
                {
                    total_price = (ticket_price * iPerson) + (iPerson * 50);

                }
            }
            label4.Text = "總計： " + total_price + " 元";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            textBox1.Enabled = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            ticket_price = 0;
            total_price = 0;
            iPerson = 0;
            gPerson = 0;
            isGroup = false;
            mealbox = false;
            beveage = false;
            textBox1.Text = "";
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek != DayOfWeek.Saturday && dateTimePicker1.Value.DayOfWeek != DayOfWeek.Sunday)
            {
                radioButton1.Text = "1日券540元";
                if (radioButton1.Checked)
                {
                    ticket_price *= 0.9;
                }
            }
            else
            {
                radioButton1.Text = "1日券600元";
                ticket_price = 600;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ticket_price = 600;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ticket_price = 900;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButton3.Checked = true;
                iPerson = 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                iPerson = 1;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                iPerson = 2;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                iPerson = 3;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                iPerson = 4;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                iPerson = 5;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                iPerson = 6;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                isGroup = true;
                textBox1.Enabled = true;
            }
            else
            {
                isGroup = false;
                textBox1.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                mealbox = true;
            }
            else
            {
                mealbox = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                beveage = true;
            }
            else
            {
                beveage = false;
            }
        }
    }
}