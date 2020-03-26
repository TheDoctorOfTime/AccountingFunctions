using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace AccountingFunctions
{
    public partial class Dashboard : Form
    {
        Files data = new Files();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            svg.Focus();
            data.downloadInfo(info.User);
            NameText.Text = info.User;

            data.companyList(info.User);

            foreach(var company in info.Companies)
            {
                try { CompaniesDrop.Items.Add(company); }
                catch (Exception) { break; }
            }

            CompaniesDrop.SelectedIndex = 0;
            info.currComp = info.Companies[CompaniesDrop.SelectedIndex];

            data.deleteInfo(info.User);
        }

        private void NameText_OnValueChanged(object sender, EventArgs e)
        {
            NameText.Text = info.User;
        }

        private void BankingButton_Click(object sender, EventArgs e)
        {

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesExpensesForm sales = new SalesExpensesForm();
            sales.Show();
            this.Hide();
        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {

        }

        private void CompaniesDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val = CompaniesDrop.SelectedIndex;
            info.currComp = info.Companies[val];
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CompaniesDrop_TextUpdate(object sender, EventArgs e)
        {
            CompaniesDrop.Text = info.currComp;
        }
    }
}
