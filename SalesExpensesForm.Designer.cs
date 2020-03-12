namespace AccountingFunctions
{
    partial class SalesExpensesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesExpensesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ShowSales = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ShowExpenses = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ValText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button02 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button05 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button10 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button12 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.companyText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DashboardButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.showingText = new System.Windows.Forms.Label();
            this.TrackerView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.UserCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatableCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TrackerView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ShowSales
            // 
            this.ShowSales.ActiveBorderThickness = 1;
            this.ShowSales.ActiveCornerRadius = 1;
            this.ShowSales.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.ShowSales.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.ShowSales.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.ShowSales.BackColor = System.Drawing.SystemColors.Control;
            this.ShowSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowSales.BackgroundImage")));
            this.ShowSales.ButtonText = "Sales";
            this.ShowSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSales.ForeColor = System.Drawing.Color.SeaGreen;
            this.ShowSales.IdleBorderThickness = 1;
            this.ShowSales.IdleCornerRadius = 1;
            this.ShowSales.IdleFillColor = System.Drawing.SystemColors.Control;
            this.ShowSales.IdleForecolor = System.Drawing.Color.DarkMagenta;
            this.ShowSales.IdleLineColor = System.Drawing.Color.DarkMagenta;
            this.ShowSales.Location = new System.Drawing.Point(372, 556);
            this.ShowSales.Margin = new System.Windows.Forms.Padding(5);
            this.ShowSales.Name = "ShowSales";
            this.ShowSales.Size = new System.Drawing.Size(324, 57);
            this.ShowSales.TabIndex = 3;
            this.ShowSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowSales.Click += new System.EventHandler(this.ShowSales_Click);
            // 
            // ShowExpenses
            // 
            this.ShowExpenses.ActiveBorderThickness = 1;
            this.ShowExpenses.ActiveCornerRadius = 1;
            this.ShowExpenses.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.ShowExpenses.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.ShowExpenses.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.ShowExpenses.BackColor = System.Drawing.SystemColors.Control;
            this.ShowExpenses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowExpenses.BackgroundImage")));
            this.ShowExpenses.ButtonText = "Expenses";
            this.ShowExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowExpenses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowExpenses.ForeColor = System.Drawing.Color.SeaGreen;
            this.ShowExpenses.IdleBorderThickness = 1;
            this.ShowExpenses.IdleCornerRadius = 1;
            this.ShowExpenses.IdleFillColor = System.Drawing.SystemColors.Control;
            this.ShowExpenses.IdleForecolor = System.Drawing.Color.DarkMagenta;
            this.ShowExpenses.IdleLineColor = System.Drawing.Color.DarkMagenta;
            this.ShowExpenses.Location = new System.Drawing.Point(706, 556);
            this.ShowExpenses.Margin = new System.Windows.Forms.Padding(5);
            this.ShowExpenses.Name = "ShowExpenses";
            this.ShowExpenses.Size = new System.Drawing.Size(324, 57);
            this.ShowExpenses.TabIndex = 3;
            this.ShowExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowExpenses.Click += new System.EventHandler(this.ShowExpenses_Click);
            // 
            // ValText
            // 
            this.ValText.BorderColorFocused = System.Drawing.Color.DarkMagenta;
            this.ValText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValText.BorderColorMouseHover = System.Drawing.Color.DarkMagenta;
            this.ValText.BorderThickness = 3;
            this.ValText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ValText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ValText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValText.isPassword = false;
            this.ValText.Location = new System.Drawing.Point(31, 237);
            this.ValText.Margin = new System.Windows.Forms.Padding(4);
            this.ValText.Name = "ValText";
            this.ValText.Size = new System.Drawing.Size(230, 44);
            this.ValText.TabIndex = 4;
            this.ValText.Text = "0";
            this.ValText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ValText.OnValueChanged += new System.EventHandler(this.ValText_OnValueChanged);
            // 
            // button02
            // 
            this.button02.ActiveBorderThickness = 1;
            this.button02.ActiveCornerRadius = 1;
            this.button02.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.button02.ActiveForecolor = System.Drawing.Color.DarkMagenta;
            this.button02.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.button02.BackColor = System.Drawing.SystemColors.Control;
            this.button02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button02.BackgroundImage")));
            this.button02.ButtonText = ".2%";
            this.button02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button02.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button02.ForeColor = System.Drawing.Color.SeaGreen;
            this.button02.IdleBorderThickness = 1;
            this.button02.IdleCornerRadius = 1;
            this.button02.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.button02.IdleForecolor = System.Drawing.SystemColors.Control;
            this.button02.IdleLineColor = System.Drawing.SystemColors.Control;
            this.button02.Location = new System.Drawing.Point(31, 290);
            this.button02.Margin = new System.Windows.Forms.Padding(5);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(107, 44);
            this.button02.TabIndex = 3;
            this.button02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // button05
            // 
            this.button05.ActiveBorderThickness = 1;
            this.button05.ActiveCornerRadius = 1;
            this.button05.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.button05.ActiveForecolor = System.Drawing.Color.DarkMagenta;
            this.button05.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.button05.BackColor = System.Drawing.SystemColors.Control;
            this.button05.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button05.BackgroundImage")));
            this.button05.ButtonText = ".5%";
            this.button05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button05.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button05.ForeColor = System.Drawing.Color.SeaGreen;
            this.button05.IdleBorderThickness = 1;
            this.button05.IdleCornerRadius = 1;
            this.button05.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.button05.IdleForecolor = System.Drawing.SystemColors.Control;
            this.button05.IdleLineColor = System.Drawing.SystemColors.Control;
            this.button05.Location = new System.Drawing.Point(154, 290);
            this.button05.Margin = new System.Windows.Forms.Padding(5);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(107, 44);
            this.button05.TabIndex = 3;
            this.button05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button05.Click += new System.EventHandler(this.button05_Click);
            // 
            // button10
            // 
            this.button10.ActiveBorderThickness = 1;
            this.button10.ActiveCornerRadius = 1;
            this.button10.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.button10.ActiveForecolor = System.Drawing.Color.DarkMagenta;
            this.button10.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.button10.BackColor = System.Drawing.SystemColors.Control;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.ButtonText = ".10%";
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.SeaGreen;
            this.button10.IdleBorderThickness = 1;
            this.button10.IdleCornerRadius = 1;
            this.button10.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.button10.IdleForecolor = System.Drawing.SystemColors.Control;
            this.button10.IdleLineColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(31, 331);
            this.button10.Margin = new System.Windows.Forms.Padding(5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 44);
            this.button10.TabIndex = 3;
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.ActiveBorderThickness = 1;
            this.button12.ActiveCornerRadius = 1;
            this.button12.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.button12.ActiveForecolor = System.Drawing.Color.DarkMagenta;
            this.button12.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.button12.BackColor = System.Drawing.SystemColors.Control;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.ButtonText = ".12%";
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.SeaGreen;
            this.button12.IdleBorderThickness = 1;
            this.button12.IdleCornerRadius = 1;
            this.button12.IdleFillColor = System.Drawing.Color.DarkMagenta;
            this.button12.IdleForecolor = System.Drawing.SystemColors.Control;
            this.button12.IdleLineColor = System.Drawing.SystemColors.Control;
            this.button12.Location = new System.Drawing.Point(154, 331);
            this.button12.Margin = new System.Windows.Forms.Padding(5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(107, 44);
            this.button12.TabIndex = 3;
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // NameText
            // 
            this.NameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameText.HintForeColor = System.Drawing.Color.Empty;
            this.NameText.HintText = "";
            this.NameText.isPassword = false;
            this.NameText.LineFocusedColor = System.Drawing.Color.Gray;
            this.NameText.LineIdleColor = System.Drawing.Color.Gray;
            this.NameText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.NameText.LineThickness = 3;
            this.NameText.Location = new System.Drawing.Point(31, 68);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(230, 44);
            this.NameText.TabIndex = 5;
            this.NameText.Text = "Name Placeholder";
            this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameText.OnValueChanged += new System.EventHandler(this.NameText_OnValueChanged);
            // 
            // companyText
            // 
            this.companyText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.companyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companyText.HintForeColor = System.Drawing.Color.Empty;
            this.companyText.HintText = "";
            this.companyText.isPassword = false;
            this.companyText.LineFocusedColor = System.Drawing.Color.Gray;
            this.companyText.LineIdleColor = System.Drawing.Color.Gray;
            this.companyText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.companyText.LineThickness = 3;
            this.companyText.Location = new System.Drawing.Point(31, 120);
            this.companyText.Margin = new System.Windows.Forms.Padding(4);
            this.companyText.Name = "companyText";
            this.companyText.Size = new System.Drawing.Size(230, 44);
            this.companyText.TabIndex = 5;
            this.companyText.Text = "Company Placeholder";
            this.companyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.companyText.OnValueChanged += new System.EventHandler(this.companyText_OnValueChanged);
            // 
            // DashboardButton
            // 
            this.DashboardButton.ActiveBorderThickness = 1;
            this.DashboardButton.ActiveCornerRadius = 1;
            this.DashboardButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.DashboardButton.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.DashboardButton.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.DashboardButton.BackColor = System.Drawing.SystemColors.Control;
            this.DashboardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashboardButton.BackgroundImage")));
            this.DashboardButton.ButtonText = "Dashboard";
            this.DashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.DashboardButton.IdleBorderThickness = 1;
            this.DashboardButton.IdleCornerRadius = 1;
            this.DashboardButton.IdleFillColor = System.Drawing.SystemColors.Control;
            this.DashboardButton.IdleForecolor = System.Drawing.Color.DarkMagenta;
            this.DashboardButton.IdleLineColor = System.Drawing.Color.DarkMagenta;
            this.DashboardButton.Location = new System.Drawing.Point(31, 451);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(5);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(230, 57);
            this.DashboardButton.TabIndex = 3;
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // showingText
            // 
            this.showingText.AutoSize = true;
            this.showingText.Cursor = System.Windows.Forms.Cursors.Default;
            this.showingText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingText.Location = new System.Drawing.Point(998, 529);
            this.showingText.Name = "showingText";
            this.showingText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showingText.Size = new System.Drawing.Size(35, 16);
            this.showingText.TabIndex = 7;
            this.showingText.Text = "Sales";
            // 
            // TrackerView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrackerView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TrackerView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TrackerView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrackerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TrackerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrackerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserCol,
            this.VatableCol,
            this.VatCol,
            this.TotalCol});
            this.TrackerView.DoubleBuffered = true;
            this.TrackerView.EnableHeadersVisualStyles = false;
            this.TrackerView.HeaderBgColor = System.Drawing.Color.DarkMagenta;
            this.TrackerView.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.TrackerView.Location = new System.Drawing.Point(283, 49);
            this.TrackerView.Name = "TrackerView";
            this.TrackerView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TrackerView.Size = new System.Drawing.Size(747, 477);
            this.TrackerView.TabIndex = 8;
            this.TrackerView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrackerView_CellEndEdit);
            // 
            // UserCol
            // 
            this.UserCol.HeaderText = "User";
            this.UserCol.Name = "UserCol";
            this.UserCol.ReadOnly = true;
            this.UserCol.Width = 254;
            // 
            // VatableCol
            // 
            this.VatableCol.HeaderText = "Vatable";
            this.VatableCol.Name = "VatableCol";
            this.VatableCol.Width = 150;
            // 
            // VatCol
            // 
            this.VatCol.HeaderText = "Vat";
            this.VatCol.Name = "VatCol";
            this.VatCol.Width = 150;
            // 
            // TotalCol
            // 
            this.TotalCol.HeaderText = "Total";
            this.TotalCol.Name = "TotalCol";
            this.TotalCol.Width = 150;
            // 
            // SalesExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 645);
            this.Controls.Add(this.TrackerView);
            this.Controls.Add(this.showingText);
            this.Controls.Add(this.companyText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ValText);
            this.Controls.Add(this.ShowExpenses);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.ShowSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesExpensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesExpensesForm";
            this.Load += new System.EventHandler(this.SalesExpensesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 ShowSales;
        private Bunifu.Framework.UI.BunifuThinButton2 ShowExpenses;
        private Bunifu.Framework.UI.BunifuMetroTextbox ValText;
        private Bunifu.Framework.UI.BunifuThinButton2 button12;
        private Bunifu.Framework.UI.BunifuThinButton2 button10;
        private Bunifu.Framework.UI.BunifuThinButton2 button05;
        private Bunifu.Framework.UI.BunifuThinButton2 button02;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameText;
        private Bunifu.Framework.UI.BunifuThinButton2 DashboardButton;
        private System.Windows.Forms.Label showingText;
        private Bunifu.Framework.UI.BunifuCustomDataGrid TrackerView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatableCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCol;
    }
}