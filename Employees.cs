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
    public partial class Employees : Form
    {
        Files data = new Files();

        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            data.downloadCompany(info.currComp);
            NameText.Text = info.User;
            companyText.Text = info.currComp;

            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Employees.txt");
            try
            {
                foreach (string line in lines)
                {
                    string[] currLine = line.Split('*');
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3], currLine[4], currLine[5]);
                }
            }
            catch (Exception)
            { }
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            data.uploadCompany(info.currComp);
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            data.uploadCompany(info.currComp);
            Application.Exit();
        }
    }
}
