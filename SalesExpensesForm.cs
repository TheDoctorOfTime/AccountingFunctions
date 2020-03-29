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
        bool isSales = true;
        string account, vatable, vat, total;
        int currRow;

        float mathVal;

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
            try
            {
                foreach (string line in lines)
                {
                    string[] currLine = line.Split('*');
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
                }
            }
            catch (Exception)
            { }
            
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
            try
            { mathVal = float.Parse(ValText.Text); }
            catch (Exception)
            {
                try
                {
                    ValText.Text = ValText.Text.Remove(ValText.Text.Length - 1);
                }
                catch (Exception)
                {
                    ValText.Text = "0";
                }
            }
        }

        private void button02_Click(object sender, EventArgs e)
        {
            if (ValText.Text != null) ValText.Text = (mathVal * 0.002f).ToString();
        }

        private void button05_Click(object sender, EventArgs e)
        {
            if (ValText.Text != null) ValText.Text = (mathVal * 0.005f).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ValText.Text != null) ValText.Text = (mathVal * 0.010f).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ValText.Text != null) ValText.Text = (mathVal * 0.012f).ToString();
        }

        private void TrackerView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            currRow = TrackerView.CurrentCell.RowIndex;
            TrackerView.Rows[currRow].Cells[0].Value = info.User;
        }

        private void TrackerView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Check for letters and other values
            //string input = TrackerView.CurrentCell.Value.ToString();
            //foreach(char i in input)
            //{ if (i != '1' || i != '2' || i != '3' || i != '4' || i != '5' || i != '6' || i != '7' || i != '8' || i != '9' || i != '0' || i != '.') TrackerView.CurrentCell.Value = "0"; }

            //if both are filled properly
            try
            {
                if (TrackerView.Rows[currRow].Cells[1].Value != null && TrackerView.Rows[currRow].Cells[2].Value != null)
                {
                    float Val1 = float.Parse(TrackerView.Rows[currRow].Cells[1].Value.ToString());
                    float Val2 = 0;

                    try
                    {
                        string Val2str = TrackerView.Rows[currRow].Cells[2].Value.ToString();
                        string[] num = Val2str.Split(')');
                        
                        if(num[0].Contains("(2%") || num[0].Contains("(5%") || num[0].Contains("(10%") || num[0].Contains("(12%"))
                        {
                            Val2 = float.Parse(num[1]);

                            float sol1 = Val1 + Val2;
                            float sol2 = Val1 - Val2;

                            string add = sol1.ToString();
                            string sub = sol2.ToString();

                            if (isSales) TrackerView.Rows[currRow].Cells[3].Value = add;
                            if (!isSales) TrackerView.Rows[currRow].Cells[3].Value = sub;
                        }
                        else
                        {
                            TrackerView.Rows[currRow].Cells[3].Value = "Input Vat Percentage using (percentage%)Vat";
                        }
                    }
                    catch (Exception) { TrackerView.Rows[currRow].Cells[3].Value = "Input Vat Percentage using (percentage%)Vat"; }

                }
                else
                {

                }
            }
            catch (Exception)
            {
                TrackerView.Rows[currRow].Cells[3].Value = "Invalid Character/s";
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //load sales
            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Sales.txt");
            try
            {
                foreach (string line in lines)
                {
                    string[] currLine = line.Split('*');
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
                }
            }
            catch (Exception)
            { }

            //write to sales
            try
            {
                string[] output = new string[100000];
                for (int i = 0; i < TrackerView.Rows.Count; i++)
                {
                    //checks if row contains value
                    if (TrackerView.Rows[i].Cells[0].Value != null && TrackerView.Rows[i].Cells[1].Value != null && TrackerView.Rows[i].Cells[2].Value != null && TrackerView.Rows[i].Cells[3].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[1].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[2].Value.ToString();
                        total = TrackerView.Rows[i].Cells[3].Value.ToString();

                        string line = account + "*" + vatable + "*" + vat + "*" + total;
                        output[i] = line;
                    }
                    data.writeSales(output);
                }
            }
            catch (Exception) { }

            //load expenses
            TrackerView.Rows.Clear();

            string[] lines2 = File.ReadAllLines(data.compDir + "/Expenses.txt");
            try
            {
                foreach (string line in lines2)
                {
                    string[] currLine = line.Split('*');
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
                }
            }
            catch (Exception)
            { }

            //write to expenses
            try
            {
                string[] output = new string[100000];
                for (int i = 0; i < TrackerView.Rows.Count; i++)
                {
                    //checks if row contains value
                    if (TrackerView.Rows[i].Cells[0].Value != null && TrackerView.Rows[i].Cells[1].Value != null && TrackerView.Rows[i].Cells[2].Value != null && TrackerView.Rows[i].Cells[3].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[1].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[2].Value.ToString();
                        total = TrackerView.Rows[i].Cells[3].Value.ToString();

                        string line = account + "*" + vatable + "*" + vat + "*" + total;
                        output[i] = line;
                    }
                    data.writeExpenses(output);
                }
            }
            catch (Exception) { }

            data.uploadCompany(info.currComp);
            if (data.success) Application.Exit();
        }

        private void ShowSales_Click(object sender, EventArgs e)
        {
            //save info to text
            try
            {
                string[] output = new string[100000];
                for (int i = 0; i < TrackerView.Rows.Count; i++)
                {
                    //checks if row contains value
                    if(TrackerView.Rows[i].Cells[0].Value != null && TrackerView.Rows[i].Cells[1].Value != null && TrackerView.Rows[i].Cells[2].Value != null && TrackerView.Rows[i].Cells[3].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[1].Value.ToString();
                        vat     = TrackerView.Rows[i].Cells[2].Value.ToString();
                        total   = TrackerView.Rows[i].Cells[3].Value.ToString();

                        string line = account + "*" + vatable + "*" + vat + "*" + total;
                        output[i] = line;
                    }
                    data.writeExpenses(output);
                }
            }
            catch (Exception) { }

            //load next
            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Sales.txt");
            try
            {
                foreach (string line in lines)
                {
                    string[] currLine = line.Split('*');
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
                }
            }
            catch (Exception)
            { }

            //confirm
            isSales = true;
            showingText.Text = "Sales";
        }

        private void ShowExpenses_Click(object sender, EventArgs e)
        {
            //save info to text
            try
            {
                string[] output = new string[100000];
                for (int i = 0; i < TrackerView.Rows.Count; i++)
                {
                    //checks if row contains value
                    if (TrackerView.Rows[i].Cells[0].Value != null && TrackerView.Rows[i].Cells[1].Value != null && TrackerView.Rows[i].Cells[2].Value != null && TrackerView.Rows[i].Cells[3].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[1].Value.ToString();
                        vat     = TrackerView.Rows[i].Cells[2].Value.ToString();
                        total   = TrackerView.Rows[i].Cells[3].Value.ToString();

                        string line = account + "*" + vatable + "*" + vat + "*" + total;
                        output[i] = line;
                    }
                    data.writeSales(output);
                }
            }
            catch (Exception) { }

            //load next
            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Expenses.txt");
            try
            {
                foreach (string line in lines)
                {
                    string[] currLine = line.Split('*');
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
                }
            }
            catch (Exception)
            { }
            
            //confirm
            isSales = false;
            showingText.Text = "Expenses";
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            if (isSales)
            {
                showExpenses();
                showSales();
            }
            else
            {
                showSales();
                showExpenses();
            }

            data.uploadCompany(info.currComp);

            if (data.success)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
        }

        private void showExpenses()
        {
            //save info to text
            try
            {
                string[] output = new string[100000];
                for (int i = 0; i < TrackerView.Rows.Count; i++)
                {
                    //checks if row contains value
                    if (TrackerView.Rows[i].Cells[0].Value != null && TrackerView.Rows[i].Cells[1].Value != null && TrackerView.Rows[i].Cells[2].Value != null && TrackerView.Rows[i].Cells[3].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[1].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[2].Value.ToString();
                        total = TrackerView.Rows[i].Cells[3].Value.ToString();

                        string line = account + "*" + vatable + "*" + vat + "*" + total;
                        output[i] = line;
                    }
                    data.writeSales(output);
                }
            }
            catch (Exception) { }

            //load next
            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Expenses.txt");
            try
            {
                foreach (string line in lines)
                {
                    string[] currLine = line.Split('*');
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
                }
            }
            catch (Exception)
            { }

            //confirm
            isSales = false;
            showingText.Text = "Expenses";
        }

        private void showSales()
        {
            //save info to text
            try
            {
                string[] output = new string[100000];
                for (int i = 0; i < TrackerView.Rows.Count; i++)
                {
                    //checks if row contains value
                    if (TrackerView.Rows[i].Cells[0].Value != null && TrackerView.Rows[i].Cells[1].Value != null && TrackerView.Rows[i].Cells[2].Value != null && TrackerView.Rows[i].Cells[3].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[1].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[2].Value.ToString();
                        total = TrackerView.Rows[i].Cells[3].Value.ToString();

                        string line = account + "*" + vatable + "*" + vat + "*" + total;
                        output[i] = line;
                    }
                    data.writeExpenses(output);
                }
            }
            catch (Exception) { }

            //load next
            TrackerView.Rows.Clear();

            string[] lines = File.ReadAllLines(data.compDir + "/Sales.txt");
            try
            {
                foreach (string line in lines)
                {
                    string[] currLine = line.Split('*');
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3]);
                }
            }
            catch (Exception)
            { }

            //confirm
            isSales = true;
            showingText.Text = "Sales";
        }
    }
}
