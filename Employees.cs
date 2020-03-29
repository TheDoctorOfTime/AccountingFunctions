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
        float bPay, ded1, ded2, ded3, tPay;
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
            try
            {
                string[] output = new string[100000];
                for (int i = 0; i < TrackerView.Rows.Count; i++)
                {
                    //checks if row contains value
                    if (TrackerView.Rows[i].Cells[0].Value != null && TrackerView.Rows[i].Cells[1].Value != null && TrackerView.Rows[i].Cells[2].Value != null && TrackerView.Rows[i].Cells[3].Value != null)
                    {
                        string name = TrackerView.Rows[i].Cells[0].Value.ToString();
                        string bpay = TrackerView.Rows[i].Cells[1].Value.ToString();
                        string duc1 = TrackerView.Rows[i].Cells[2].Value.ToString();
                        string duc2 = TrackerView.Rows[i].Cells[3].Value.ToString();
                        string duc3 = TrackerView.Rows[i].Cells[4].Value.ToString();
                        string tpay = TrackerView.Rows[i].Cells[5].Value.ToString();

                        string line = name + "*" + bpay + "*" + duc1 + "*" + duc2 + "*" + duc3 + "*" + tpay;
                        output[i] = line;
                    }
                    data.writeEmployees(output);
                }
            }
            catch (Exception) { }

            data.uploadCompany(info.currComp);

            if (data.success)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] output = new string[100000];
                for (int i = 0; i < TrackerView.Rows.Count; i++)
                {
                    //checks if row contains value
                    if (TrackerView.Rows[i].Cells[0].Value != null && TrackerView.Rows[i].Cells[1].Value != null && TrackerView.Rows[i].Cells[2].Value != null && TrackerView.Rows[i].Cells[3].Value != null)
                    {
                        string name = TrackerView.Rows[i].Cells[0].Value.ToString();
                        string bpay = TrackerView.Rows[i].Cells[1].Value.ToString();
                        string duc1 = TrackerView.Rows[i].Cells[2].Value.ToString();
                        string duc2 = TrackerView.Rows[i].Cells[3].Value.ToString();
                        string duc3 = TrackerView.Rows[i].Cells[4].Value.ToString();
                        string tpay = TrackerView.Rows[i].Cells[5].Value.ToString();

                        string line = name + "*" + bpay + "*" + duc1 + "*" + duc2 + "*" + duc3 + "*" + tpay;
                        output[i] = line;
                    }
                    data.writeEmployees(output);
                }
            }
            catch (Exception) { }

            data.uploadCompany(info.currComp);
            if(data.success) Application.Exit();
        }

        private void TrackerView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Check Value of Name and Basic is pay is not null
            if ((TrackerView.Rows[currRow].Cells[0].Value != null) && (TrackerView.Rows[currRow].Cells[1].Value != null))
            {
                //attempt parsing to float Cell 1 (Basic Pay)
                try
                {
                    bPay = float.Parse(TrackerView.Rows[currRow].Cells[1].Value.ToString());

                    //Make sure Cell 1 (Basic Pay) is at least 15k php
                    if(bPay >= 15000f)
                    {
                        //Fill Deductions - Done
                        TrackerView.Rows[currRow].Cells[2].Value = "-300";
                        TrackerView.Rows[currRow].Cells[3].Value = "-250";
                        TrackerView.Rows[currRow].Cells[4].Value = "-550";

                        ded1 = float.Parse(TrackerView.Rows[currRow].Cells[2].Value.ToString());
                        ded2 = float.Parse(TrackerView.Rows[currRow].Cells[3].Value.ToString());
                        ded3 = float.Parse(TrackerView.Rows[currRow].Cells[4].Value.ToString());

                        //Compute Total
                        TrackerView.Rows[currRow].Cells[5].Value = (bPay + ded1 + ded2 + ded3).ToString();
                    }
                    else
                    {
                        //Empty Cells
                        TrackerView.Rows[currRow].Cells[2].Value = string.Empty;
                        TrackerView.Rows[currRow].Cells[3].Value = string.Empty;
                        TrackerView.Rows[currRow].Cells[4].Value = string.Empty;

                        //Compute Total
                        TrackerView.Rows[currRow].Cells[5].Value = "Basic Pay is Below Minimum Wage";
                    }
                    
                }
                catch (Exception) 
                {
                    TrackerView.Rows[currRow].Cells[1].Value = string.Empty;
                    TrackerView.Rows[currRow].Cells[5].Value = "Invalid Basic Pay";
                }

                
            }
        }

        private void TrackerView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            currRow = TrackerView.CurrentCell.RowIndex;
        }
    }
}
