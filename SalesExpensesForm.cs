using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccountingFunctions
{
    public partial class SalesExpensesForm : Form
    {
        Files data = new Files();
        bool showSales = true;

        string account, vatable, vat, total;

        public SalesExpensesForm()
        {
            InitializeComponent();
        }

        private void SalesExpensesForm_Load(object sender, EventArgs e)
        {
            data.downloadCompany(info.currComp);
            NameText.Text = info.User;
            companyText.Text = info.currComp;

            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Sales.txt");
            foreach (string line in lines)
            {
                string[] currLine = line.Split('*');
                TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
            }
        }

        private void NameText_OnValueChanged(object sender, EventArgs e)
        {
            NameText.Text = info.User;
        }

        private void companyText_OnValueChanged(object sender, EventArgs e)
        {
            companyText.Text = info.currComp;
        }

        private void ValText_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button02_Click(object sender, EventArgs e)
        {

        }

        private void button05_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            TrackerView.Rows.Add(info.User);
        }

        private void TrackerView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowSales_Click(object sender, EventArgs e)
        {
            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Sales.txt");
            foreach (string line in lines)
            {
                string[] currLine = line.Split('*');
                TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
            }

            showingText.Text = "Sales";
        }

        private void ShowExpenses_Click(object sender, EventArgs e)
        {
            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Expenses.txt");
            foreach (string line in lines)
            {
                string[] currLine = line.Split('*');
                TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
            }

            showingText.Text = "Expenses";
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            data.uploadCompany(info.currComp);
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
