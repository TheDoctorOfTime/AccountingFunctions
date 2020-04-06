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
    //sample format: Account*Particular*Count*Price*Multiple*percentage*deduction*total
    // example text: RafaelIgnacio*Processors*12*5000*60000*.12%*72*59928
    public partial class SalesExpensesForm : Form
    {
        Files data = new Files();
        bool isSales = true;
        string account, particular, quantity, price, vatable, percentage, vat, total;
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
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3], currLine[4], currLine[5], currLine[6], currLine[7]);
                }
            }catch (Exception)
            {
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
            float quantity = 0;
            float price = 0;

            float multiplier = 0;

            float Val1 = 0;
            float Val2 = 0;

            //Define quantity and price and Vat
            try { quantity = float.Parse(TrackerView.Rows[currRow].Cells[2].Value.ToString()); } catch (Exception) { TrackerView.Rows[currRow].Cells[2].Value = string.Empty; }
            try { price    = float.Parse(TrackerView.Rows[currRow].Cells[3].Value.ToString()); } catch (Exception) { TrackerView.Rows[currRow].Cells[3].Value = string.Empty; }
            try { Val2     = float.Parse(TrackerView.Rows[currRow].Cells[6].Value.ToString()); } catch (Exception) { TrackerView.Rows[currRow].Cells[6].Value = string.Empty; }

            //Make sure % is .2/.5/.10/.12 % only
            try
            {
                if (
                    (TrackerView.Rows[currRow].Cells[5].Value.ToString() != ".2%"  && TrackerView.Rows[currRow].Cells[5].Value.ToString() != ".2"  && TrackerView.Rows[currRow].Cells[5].Value.ToString() != "0.2%"  && TrackerView.Rows[currRow].Cells[5].Value.ToString() != "0.2" ) &&
                    (TrackerView.Rows[currRow].Cells[5].Value.ToString() != ".5%"  && TrackerView.Rows[currRow].Cells[5].Value.ToString() != ".5"  && TrackerView.Rows[currRow].Cells[5].Value.ToString() != "0.5%"  && TrackerView.Rows[currRow].Cells[5].Value.ToString() != "0.5" ) &&
                    (TrackerView.Rows[currRow].Cells[5].Value.ToString() != ".10%" && TrackerView.Rows[currRow].Cells[5].Value.ToString() != ".10" && TrackerView.Rows[currRow].Cells[5].Value.ToString() != "0.10%" && TrackerView.Rows[currRow].Cells[5].Value.ToString() != "0.10") &&
                    (TrackerView.Rows[currRow].Cells[5].Value.ToString() != ".12%" && TrackerView.Rows[currRow].Cells[5].Value.ToString() != ".12" && TrackerView.Rows[currRow].Cells[5].Value.ToString() != "0.12%" && TrackerView.Rows[currRow].Cells[5].Value.ToString() != "0.12")
                ) 
                { TrackerView.Rows[currRow].Cells[5].Value = string.Empty; }
                else
                {
                    if (TrackerView.Rows[currRow].Cells[5].Value.ToString() == ".2%"  || TrackerView.Rows[currRow].Cells[5].Value.ToString() == ".2"  || TrackerView.Rows[currRow].Cells[5].Value.ToString() == "0.2%"  || TrackerView.Rows[currRow].Cells[5].Value.ToString() == "0.2" ) multiplier = 0.002f ;
                    if (TrackerView.Rows[currRow].Cells[5].Value.ToString() == ".5%"  || TrackerView.Rows[currRow].Cells[5].Value.ToString() == ".5"  || TrackerView.Rows[currRow].Cells[5].Value.ToString() == "0.5%"  || TrackerView.Rows[currRow].Cells[5].Value.ToString() == "0.5" ) multiplier = 0.005f ;
                    if (TrackerView.Rows[currRow].Cells[5].Value.ToString() == ".10%" || TrackerView.Rows[currRow].Cells[5].Value.ToString() == ".10" || TrackerView.Rows[currRow].Cells[5].Value.ToString() == "0.10%" || TrackerView.Rows[currRow].Cells[5].Value.ToString() == "0.10") multiplier = 0.001f ;
                    if (TrackerView.Rows[currRow].Cells[5].Value.ToString() == ".12%" || TrackerView.Rows[currRow].Cells[5].Value.ToString() == ".12" || TrackerView.Rows[currRow].Cells[5].Value.ToString() == "0.12%" || TrackerView.Rows[currRow].Cells[5].Value.ToString() == "0.12") multiplier = 0.0012f;
                }
            }
            catch (Exception) { }

            //Calculate Total
            try
            {
                if (
                    TrackerView.Rows[currRow].Cells[1].Value != null &&
                    TrackerView.Rows[currRow].Cells[2].Value != null &&
                    TrackerView.Rows[currRow].Cells[3].Value != null &&
                       (
                        TrackerView.Rows[currRow].Cells[5].Value != null ||
                        TrackerView.Rows[currRow].Cells[6].Value != null
                       )
                   )
                {
                    //Vatable
                    Val1 = quantity * price;
                    TrackerView.Rows[currRow].Cells[4].Value = Val1;

                    if (TrackerView.Rows[currRow].Cells[5].Value != null)
                    {
                        TrackerView.Rows[currRow].Cells[6].Value = (multiplier * Val1);
                    }
                    else if (TrackerView.Rows[currRow].Cells[6].Value != null)
                    {
                        TrackerView.Rows[currRow].Cells[5].Value = ((Val2 / Val1) * 100) + "%";
                        multiplier = (Val2 / Val1) * 100;
                    }

                    if (multiplier == 0.002) TrackerView.Rows[currRow].Cells[5].Value = "0.2%";
                    if (multiplier == 0.005) TrackerView.Rows[currRow].Cells[5].Value = "0.5%";
                    if (multiplier == 0.001) TrackerView.Rows[currRow].Cells[5].Value = "0.10%";
                    if (multiplier == 0.0012) TrackerView.Rows[currRow].Cells[5].Value = "0.12%";

                    try
                    {
                        float sol1 = Val1 + Val2;
                        float sol2 = Val1 - Val2;

                        string add = sol1.ToString();
                        string sub = sol2.ToString();

                        if (isSales)  TrackerView.Rows[currRow].Cells[7].Value = add;
                        if (!isSales) TrackerView.Rows[currRow].Cells[7].Value = sub;
                    } catch (Exception) {  }
                }
            }
            catch (Exception)
            {
                TrackerView.Rows[currRow].Cells[7].Value = "Invalid Character/s";
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
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3], currLine[4], currLine[5], currLine[6], currLine[7]);
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
                    if (
                        TrackerView.Rows[i].Cells[0].Value != null &&
                        TrackerView.Rows[i].Cells[1].Value != null &&
                        TrackerView.Rows[i].Cells[2].Value != null &&
                        TrackerView.Rows[i].Cells[3].Value != null &&
                        TrackerView.Rows[i].Cells[4].Value != null &&
                        TrackerView.Rows[i].Cells[5].Value != null &&
                        TrackerView.Rows[i].Cells[6].Value != null &&
                        TrackerView.Rows[i].Cells[7].Value != null)
                    {
                        account     = TrackerView.Rows[i].Cells[0].Value.ToString();
                        particular  = TrackerView.Rows[i].Cells[1].Value.ToString();
                        quantity    = TrackerView.Rows[i].Cells[2].Value.ToString();
                        price       = TrackerView.Rows[i].Cells[3].Value.ToString();
                        vatable     = TrackerView.Rows[i].Cells[4].Value.ToString();
                        percentage  = TrackerView.Rows[i].Cells[5].Value.ToString();
                        vat         = TrackerView.Rows[i].Cells[6].Value.ToString();
                        total       = TrackerView.Rows[i].Cells[7].Value.ToString();

                        string line = account + "*" + particular + "*" + quantity + "*" + price + "*" + vatable + "*" + percentage + "*" + vat + "*" + total;
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
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3], currLine[4], currLine[5], currLine[6], currLine[7]);
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
                    if (
                        TrackerView.Rows[i].Cells[0].Value != null &&
                        TrackerView.Rows[i].Cells[1].Value != null &&
                        TrackerView.Rows[i].Cells[2].Value != null &&
                        TrackerView.Rows[i].Cells[3].Value != null &&
                        TrackerView.Rows[i].Cells[4].Value != null &&
                        TrackerView.Rows[i].Cells[5].Value != null &&
                        TrackerView.Rows[i].Cells[6].Value != null &&
                        TrackerView.Rows[i].Cells[7].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        particular = TrackerView.Rows[i].Cells[1].Value.ToString();
                        quantity = TrackerView.Rows[i].Cells[2].Value.ToString();
                        price = TrackerView.Rows[i].Cells[3].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[4].Value.ToString();
                        percentage = TrackerView.Rows[i].Cells[5].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[6].Value.ToString();
                        total = TrackerView.Rows[i].Cells[7].Value.ToString();

                        string line = account + "*" + particular + "*" + quantity + "*" + price + "*" + vatable + "*" + percentage + "*" + vat + "*" + total;
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
                    if (
                        TrackerView.Rows[i].Cells[0].Value != null &&
                        TrackerView.Rows[i].Cells[1].Value != null &&
                        TrackerView.Rows[i].Cells[2].Value != null &&
                        TrackerView.Rows[i].Cells[3].Value != null &&
                        TrackerView.Rows[i].Cells[4].Value != null &&
                        TrackerView.Rows[i].Cells[5].Value != null &&
                        TrackerView.Rows[i].Cells[6].Value != null &&
                        TrackerView.Rows[i].Cells[7].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        particular = TrackerView.Rows[i].Cells[1].Value.ToString();
                        quantity = TrackerView.Rows[i].Cells[2].Value.ToString();
                        price = TrackerView.Rows[i].Cells[3].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[4].Value.ToString();
                        percentage = TrackerView.Rows[i].Cells[5].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[6].Value.ToString();
                        total = TrackerView.Rows[i].Cells[7].Value.ToString();

                        string line = account + "*" + particular + "*" + quantity + "*" + price + "*" + vatable + "*" + percentage + "*" + vat + "*" + total;
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
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3], currLine[4], currLine[5], currLine[6], currLine[7]);
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
                    if (
                        TrackerView.Rows[i].Cells[0].Value != null &&
                        TrackerView.Rows[i].Cells[1].Value != null &&
                        TrackerView.Rows[i].Cells[2].Value != null &&
                        TrackerView.Rows[i].Cells[3].Value != null &&
                        TrackerView.Rows[i].Cells[4].Value != null &&
                        TrackerView.Rows[i].Cells[5].Value != null &&
                        TrackerView.Rows[i].Cells[6].Value != null &&
                        TrackerView.Rows[i].Cells[7].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        particular = TrackerView.Rows[i].Cells[1].Value.ToString();
                        quantity = TrackerView.Rows[i].Cells[2].Value.ToString();
                        price = TrackerView.Rows[i].Cells[3].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[4].Value.ToString();
                        percentage = TrackerView.Rows[i].Cells[5].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[6].Value.ToString();
                        total = TrackerView.Rows[i].Cells[7].Value.ToString();

                        string line = account + "*" + particular + "*" + quantity + "*" + price + "*" + vatable + "*" + percentage + "*" + vat + "*" + total;
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
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3], currLine[4], currLine[5], currLine[6], currLine[7]);
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
                    if (
                        TrackerView.Rows[i].Cells[0].Value != null &&
                        TrackerView.Rows[i].Cells[1].Value != null &&
                        TrackerView.Rows[i].Cells[2].Value != null &&
                        TrackerView.Rows[i].Cells[3].Value != null &&
                        TrackerView.Rows[i].Cells[4].Value != null &&
                        TrackerView.Rows[i].Cells[5].Value != null &&
                        TrackerView.Rows[i].Cells[6].Value != null &&
                        TrackerView.Rows[i].Cells[7].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        particular = TrackerView.Rows[i].Cells[1].Value.ToString();
                        quantity = TrackerView.Rows[i].Cells[2].Value.ToString();
                        price = TrackerView.Rows[i].Cells[3].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[4].Value.ToString();
                        percentage = TrackerView.Rows[i].Cells[5].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[6].Value.ToString();
                        total = TrackerView.Rows[i].Cells[7].Value.ToString();

                        string line = account + "*" + particular + "*" + quantity + "*" + price + "*" + vatable + "*" + percentage + "*" + vat + "*" + total;
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
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3], currLine[4], currLine[5], currLine[6], currLine[7]);
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
                    if (
                        TrackerView.Rows[i].Cells[0].Value != null &&
                        TrackerView.Rows[i].Cells[1].Value != null &&
                        TrackerView.Rows[i].Cells[2].Value != null &&
                        TrackerView.Rows[i].Cells[3].Value != null &&
                        TrackerView.Rows[i].Cells[4].Value != null &&
                        TrackerView.Rows[i].Cells[5].Value != null &&
                        TrackerView.Rows[i].Cells[6].Value != null &&
                        TrackerView.Rows[i].Cells[7].Value != null)
                    {
                        account = TrackerView.Rows[i].Cells[0].Value.ToString();
                        particular = TrackerView.Rows[i].Cells[1].Value.ToString();
                        quantity = TrackerView.Rows[i].Cells[2].Value.ToString();
                        price = TrackerView.Rows[i].Cells[3].Value.ToString();
                        vatable = TrackerView.Rows[i].Cells[4].Value.ToString();
                        percentage = TrackerView.Rows[i].Cells[5].Value.ToString();
                        vat = TrackerView.Rows[i].Cells[6].Value.ToString();
                        total = TrackerView.Rows[i].Cells[7].Value.ToString();

                        string line = account + "*" + particular + "*" + quantity + "*" + price + "*" + vatable + "*" + percentage + "*" + vat + "*" + total;
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
                    TrackerView.Rows.Add(currLine[0], currLine[1], currLine[2], currLine[3], currLine[4], currLine[5], currLine[6], currLine[7]);
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
