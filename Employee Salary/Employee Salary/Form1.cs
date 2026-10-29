using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary
{
    public partial class Form1 : Form
    {
        private object empID;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String empID;
            empID = textBox1.Text;
            String empName;
            empName = textBox2.Text;
            double basicSalary;
            

            if (textBox1.Text == " ")
            {
                MessageBox.Show("Please enter Emp Id.");
                    textBox1.Focus();
                return;
            }

            if (textBox2.Text == " ")
            {
                MessageBox.Show("Please enter Name.");
                    textBox2.Focus();
                return;
            }


            if (!double.TryParse(textBox3.Text, out basicSalary))
            {
                MessageBox.Show("Please Enter valid Salary");
                return ;
            }
            
                
                double allowance = basicSalary * 0.2;
                double bonus = basicSalary * 0.1;
                double grossSalary = basicSalary + allowance + bonus;

                richTextBox1.Text = " Emploee ID: " + empID + "\n Employee Name: " + empName + "\n Basic Salary: " + basicSalary +
                    "\n Allowance : " + allowance+ " \n Bonus: " + bonus + "\n Gross Salary: " + grossSalary;

            








        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
