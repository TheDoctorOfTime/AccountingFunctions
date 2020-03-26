using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AccountingFunctions
{
    class Files
    {
        string username = "accessmdc@gmail.com";
        string password = "extremisP1";
        string ftpServer = "ftp://ftp.drivehq.com";

        public string mainDir = @"C:/Users/Public/MDCdevice";
        public string acntDir = @"C:/Users/Public/MDCdevice/Accounts";
        public string compDir = @"C:/Users/Public/MDCdevice/Companies";
        public string infoDir = @"C:/Users/Public/MDCdevice/Info";

        WebClient client = new WebClient();

        //DIRECTORY MANAGEMENT
        public void createDir()
        {
            //generate Directory Tree
            if (!Directory.Exists(mainDir)) Directory.CreateDirectory(mainDir);
            if (!Directory.Exists(acntDir)) Directory.CreateDirectory(acntDir);
            if (!Directory.Exists(compDir)) Directory.CreateDirectory(compDir);
            if (!Directory.Exists(infoDir)) Directory.CreateDirectory(infoDir);

            //generate blank file
            if (!File.Exists(mainDir + "/blank.txt")) { using (StreamWriter sw = File.CreateText(mainDir + "/blank.txt")) { sw.WriteLine("        "); } }

            //generate use files
            if (!File.Exists(mainDir + "/use.txt")) { using (StreamWriter sw = File.CreateText(mainDir + "/use.txt")) { sw.WriteLine("in use"); } }
            if (!File.Exists(mainDir + "/not.txt")) { using (StreamWriter sw = File.CreateText(mainDir + "/not.txt")) { sw.WriteLine("not in use"); } }
        }

        public void createComp(string company)
        {

        }

        //FTP FUNCTIONS
        public void download(string fileDir, string outDir, string fileName)
        {
            MessageBox.Show(ftpServer + "/" + fileDir, outDir + "/" + fileName);

            client.Credentials = new NetworkCredential(username, password);
            client.DownloadFile(ftpServer + "/" + fileDir, outDir + "/" + fileName);
        }

        public void upload(string fileDir, string upDir, string fileName)
        {
            client.Credentials = new NetworkCredential(username, password);
            client.UploadFile(ftpServer + "/" + fileDir, upDir + "/" + fileName);
        }

        //SPECIFIC FUNCTIONS
        //Downloads
        public void downloadInfo(string user)
        {
            download("My Documents/Info/" + user + ".txt", infoDir, user + "_download.txt");
        }

        public void downloadAccount(string user)
        {
            download("My Documents/Accounts/" + user + ".txt", acntDir, user + "_download.txt");
        }

        public void downloadCompany(string company)
        {
            bool inUse;
            string ln;

            download("My Documents/Companies/" + company + "_checkup.txt", compDir, "checkup.txt");
            using (StreamReader file = new StreamReader(compDir + "/checkup.txt"))
            {
                while ((ln = file.ReadLine()) != null) { ln = file.ReadLine(); }
                file.Close();
            }

            if (ln == "in use") inUse = true;
            else inUse = false;

            if (!inUse)
            {
                download("My Documents/Companies/" + company + "_Employees.txt", compDir, "Employees.txt");
                download("My Documents/Companies/" + company + "_Expenses.txt", compDir, "Expenses.txt");
                download("My Documents/Companies/" + company + "_Sales.txt", compDir, "Sales.txt");

                upload("My Documents/Companies/" + company + "_checkup.txt", mainDir, "use.txt");
            }
            File.Delete(compDir + "/checkup.txt");
        }

        //Uploads
        public void uploadInfo(string user, string[] companies)
        {
            download("My Documents/Info/" + user + ".txt", infoDir, user + "_download.txt");
        }

        public void uploadAccount(string user)
        {
            download("My Documents/Accounts/" + user + ".txt", acntDir, user + "_download.txt");
        }

        public void uploadCompany(string company)
        {
            upload("My Documents/Companies/" + company + "_Employees.txt", compDir, "Employees.txt");
            upload("My Documents/Companies/" + company + "_Expenses.txt", compDir, "Expenses.txt");
            upload("My Documents/Companies/" + company + "_Sales.txt", compDir, "Sales.txt");

            upload("My Documents/Companies/" + company + "_checkup.txt", mainDir, "not.txt");

            File.Delete(compDir + "/Employees.txt");
            File.Delete(compDir + "/Expenses.txt");
            File.Delete(compDir + "/Sales.txt");
        }

        //Deletions
        public void deleteInfo(string user)
        {
            File.Delete(infoDir + "/" + user + "_download.txt");
        }

        public void deleteAccount(string user)
        {
            File.Delete(acntDir + "/" + user + "_download.txt");
        }
        
        //Load Companies
        public void companyList(string user)
        {
            int i = 0; int m = 0;
            string[] lines = File.ReadAllLines(infoDir + "/" + user + "_download.txt");
            foreach (string line in lines)
            {
                if (!(i == 0)) { info.Companies[m] = line; m++; }
                i++;
            }
        }

        //Write to Companies
        public void writeSales(string[] lines)
        {
            File.WriteAllLines(compDir + "/Sales.txt", lines);
        }

        public void writeExpenses(string[] lines)
        {
            File.WriteAllLines(compDir + "/Expenses.txt", lines);
        }

        public void writeEmployees(string[] lines)
        {
            File.WriteAllLines(compDir + "/Employees.txt", lines);
        }
    }
}
