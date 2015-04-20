using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WendallHsu_Test1
{
    public partial class Form1 : Form
    {

        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string empNo = txtEmpNo.Text;
            string salary = txtSalary.Text;

            if (empNo == "" || salary == "")
            {
                MessageBox.Show("Please enter an employee number and the respective salary to add.");
            }
            else
            {
                myDictionary.Add(empNo, int.Parse(salary));
                MessageBox.Show("Successfully added.");
                txtDisplay.Text = "Employee Number: " + empNo + "   Salary: " + salary;
            }
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            string empNo = txtEmpNo.Text;

            if (empNo == "")
            {
                MessageBox.Show("Please enter an employee number to delete.");
            }
            else if (myDictionary.ContainsKey(empNo))
            {
                myDictionary.Remove(empNo);
                MessageBox.Show("Successfully removed.");
                txtDisplay.Text = "";
            }
            else if (myDictionary.Count == 0)
            {
                MessageBox.Show("There are no records in the dictionary to be deleted.");
            }
            else
            {
                MessageBox.Show("That employee number does not exist and cannot be deleted.");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (myDictionary.Count == 0)
            {
                MessageBox.Show("There are no records in the dictionary to be deleted.");
            }
            else
            {
                myDictionary.Clear();
                MessageBox.Show("Successfully removed all records.");
                txtDisplay.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string empNo = txtEmpNo.Text;

            if (empNo == "")
            {
                MessageBox.Show("Please enter an employee number to search.");
            }
            else if (myDictionary.ContainsKey(empNo))
            {
                int value = myDictionary[empNo];
                txtDisplay.Text = "Employee Number: " + empNo + "   Salary: " + value;
            }
                else if (myDictionary.Count == 0)
            {
                MessageBox.Show("There are no records in the dictionary.");
            }
            else
            {
                MessageBox.Show("No such employee number exists.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                MessageBox.Show("There is nothing on the display to clear.");
            }
            else
            {
                txtDisplay.Text = "";
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";

            if (myDictionary.Count == 0)
            {
                MessageBox.Show("There are no records in the dictionary to be shown.");
            }
            else
            {
                foreach (KeyValuePair<string, int> pair in myDictionary)
                {
                    txtDisplay.Text += "Employee Number: " + pair.Key + "   Salary: " + pair.Value + "\r\n";
                }
            }
           
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye.");
            Application.Exit();
        }
       
    }
}
