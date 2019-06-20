using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal classACost = 15;
                decimal classBCost = 12;
                decimal classCCost = 9;

                decimal classATickets;
                decimal classBTickets;
                decimal classCTickets;

                classATickets = decimal.Parse(classASold.Text);
                classBTickets = decimal.Parse(classBSold.Text);
                classCTickets = decimal.Parse(classCSold.Text);

                decimal classATotal;
                decimal classBTotal;
                decimal classCTotal;
                decimal total;

                classATotal = classACost * classATickets;
                classBTotal = classBCost * classBTickets;
                classCTotal = classCCost * classCTickets;
                total = classATotal + classBTotal + classCTotal;


                classARevenue.Text = classATotal.ToString("C");
                classBRevenue.Text = classBTotal.ToString("C");
                classCRevenue.Text = classCTotal.ToString("C");
                totalRevenue.Text = total.ToString("C");
            }
            catch
            {
                MessageBox.Show("No data entered or wrong type of data");
            }
            
        }

        private void classARevenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            classARevenue.Text = "";
            classBRevenue.Text = "";
            classCRevenue.Text = "";
            classASold.Text = "";
            classBSold.Text = "";
            classCSold.Text = "";
            totalRevenue.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
