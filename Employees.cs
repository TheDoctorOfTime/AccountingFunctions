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
        int currRow;

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

        private void TrackerView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((TrackerView.Rows[currRow].Cells[0].Value != null) && (TrackerView.Rows[currRow].Cells[1].Value != null))
            {
                //Validate Account()

                //Make sure Cell 2 is at least 15k php

                //Fill Deductions
                TrackerView.Rows[currRow].Cells[2].Value = string.Empty;
                TrackerView.Rows[currRow].Cells[3].Value = string.Empty;
                TrackerView.Rows[currRow].Cells[4].Value = string.Empty;

                //Compute Total
                TrackerView.Rows[currRow].Cells[5].Value = string.Empty;
            }
        }

        private void TrackerView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            currRow = TrackerView.CurrentCell.RowIndex;
        }
    }
}
