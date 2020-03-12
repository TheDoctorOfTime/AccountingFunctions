namespace AccountingFunctions
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CompaniesDrop = new System.Windows.Forms.ComboBox();
            this.BankingButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ReportsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InvoiceButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SalesButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.svg = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svg)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // NameText
            // 
            this.NameText.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameText.HintForeColor = System.Drawing.Color.Empty;
            this.NameText.HintText = "";
            this.NameText.isPassword = false;
            this.NameText.LineFocusedColor = System.Drawing.Color.Gray;
            this.NameText.LineIdleColor = System.Drawing.Color.Gray;
            this.NameText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.NameText.LineThickness = 3;
            this.NameText.Location = new System.Drawing.Point(171, 95);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(299, 44);
            this.NameText.TabIndex = 4;
            this.NameText.Text = "Name Placeholder";
            this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameText.OnValueChanged += new System.EventHandler(this.NameText_OnValueChanged);
            // 
            // CompaniesDrop
            // 
            this.CompaniesDrop.BackColor = System.Drawing.SystemColors.Control;
            this.CompaniesDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompaniesDrop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CompaniesDrop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompaniesDrop.FormattingEnabled = true;
            this.CompaniesDrop.Location = new System.Drawing.Point(74, 191);
            this.CompaniesDrop.Name = "CompaniesDrop";
            this.CompaniesDrop.Size = new System.Drawing.Size(396, 29);
            this.CompaniesDrop.TabIndex = 5;
            this.CompaniesDrop.SelectedIndexChanged += new System.EventHandler(this.CompaniesDrop_SelectedIndexChanged);
            this.CompaniesDrop.TextUpdate += new System.EventHandler(this.CompaniesDrop_TextUpdate);
            // 
            // BankingButton
            // 
            this.BankingButton.ActiveBorderThickness = 1;
            this.BankingButton.ActiveCornerRadius = 1;
            this.BankingButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.BankingButton.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.BankingButton.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.BankingButton.BackColor = System.Drawing.SystemColors.Control;
            this.BankingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BankingButton.BackgroundImage")));
            this.BankingButton.ButtonText = "Banking";
            this.BankingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BankingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankingButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.BankingButton.IdleBorderThickness = 1;
            this.BankingButton.IdleCornerRadius = 1;
            this.BankingButton.IdleFillColor = System.Drawing.SystemColors.Control;
            this.BankingButton.IdleForecolor = System.Drawing.Color.DarkMagenta;
            this.BankingButton.IdleLineColor = System.Drawing.Color.DarkMagenta;
            this.BankingButton.Location = new System.Drawing.Point(74, 254);
            this.BankingButton.Margin = new System.Windows.Forms.Padding(5);
            this.BankingButton.Name = "BankingButton";
            this.BankingButton.Size = new System.Drawing.Size(396, 57);
            this.BankingButton.TabIndex = 2;
            this.BankingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BankingButton.Click += new System.EventHandler(this.BankingButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.ActiveBorderThickness = 1;
            this.ReportsButton.ActiveCornerRadius = 1;
            this.ReportsButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.ReportsButton.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.ReportsButton.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.ReportsButton.BackColor = System.Drawing.SystemColors.Control;
            this.ReportsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReportsButton.BackgroundImage")));
            this.ReportsButton.ButtonText = "Reports";
            this.ReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.ReportsButton.IdleBorderThickness = 1;
            this.ReportsButton.IdleCornerRadius = 1;
            this.ReportsButton.IdleFillColor = System.Drawing.SystemColors.Control;
            this.ReportsButton.IdleForecolor = System.Drawing.Color.DarkMagenta;
            this.ReportsButton.IdleLineColor = System.Drawing.Color.DarkMagenta;
            this.ReportsButton.Location = new System.Drawing.Point(74, 455);
            this.ReportsButton.Margin = new System.Windows.Forms.Padding(5);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(396, 57);
            this.ReportsButton.TabIndex = 2;
            this.ReportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.ActiveBorderThickness = 1;
            this.InvoiceButton.ActiveCornerRadius = 1;
            this.InvoiceButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.InvoiceButton.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.InvoiceButton.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.InvoiceButton.BackColor = System.Drawing.SystemColors.Control;
            this.InvoiceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InvoiceButton.BackgroundImage")));
            this.InvoiceButton.ButtonText = "Sales Invoice";
            this.InvoiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.InvoiceButton.IdleBorderThickness = 1;
            this.InvoiceButton.IdleCornerRadius = 1;
            this.InvoiceButton.IdleFillColor = System.Drawing.SystemColors.Control;
            this.InvoiceButton.IdleForecolor = System.Drawing.Color.DarkMagenta;
            this.InvoiceButton.IdleLineColor = System.Drawing.Color.DarkMagenta;
            this.InvoiceButton.Location = new System.Drawing.Point(74, 388);
            this.InvoiceButton.Margin = new System.Windows.Forms.Padding(5);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(396, 57);
            this.InvoiceButton.TabIndex = 2;
            this.InvoiceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.ActiveBorderThickness = 1;
            this.SalesButton.ActiveCornerRadius = 1;
            this.SalesButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.SalesButton.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.SalesButton.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.SalesButton.BackColor = System.Drawing.SystemColors.Control;
            this.SalesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalesButton.BackgroundImage")));
            this.SalesButton.ButtonText = "Sales/Expenses";
            this.SalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SalesButton.IdleBorderThickness = 1;
            this.SalesButton.IdleCornerRadius = 1;
            this.SalesButton.IdleFillColor = System.Drawing.SystemColors.Control;
            this.SalesButton.IdleForecolor = System.Drawing.Color.DarkMagenta;
            this.SalesButton.IdleLineColor = System.Drawing.Color.DarkMagenta;
            this.SalesButton.Location = new System.Drawing.Point(74, 321);
            this.SalesButton.Margin = new System.Windows.Forms.Padding(5);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(396, 57);
            this.SalesButton.TabIndex = 2;
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // UserPic
            // 
            this.UserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserPic.Image = global::AccountingFunctions.Properties.Resources.account;
            this.UserPic.Location = new System.Drawing.Point(74, 60);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(90, 90);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPic.TabIndex = 1;
            this.UserPic.TabStop = false;
            // 
            // svg
            // 
            this.svg.Image = global::AccountingFunctions.Properties.Resources.accounting;
            this.svg.Location = new System.Drawing.Point(547, 56);
            this.svg.Name = "svg";
            this.svg.Size = new System.Drawing.Size(455, 515);
            this.svg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.svg.TabIndex = 1;
            this.svg.TabStop = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(74, 557);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 16);
            this.exit.TabIndex = 6;
            this.exit.Text = "exit application";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Active Company";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.CompaniesDrop);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.BankingButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.UserPic);
            this.Controls.Add(this.svg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 BankingButton;
        private Bunifu.Framework.UI.BunifuThinButton2 ReportsButton;
        private Bunifu.Framework.UI.BunifuThinButton2 InvoiceButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SalesButton;
        private System.Windows.Forms.PictureBox UserPic;
        private System.Windows.Forms.PictureBox svg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameText;
        private System.Windows.Forms.ComboBox CompaniesDrop;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
    }
}

