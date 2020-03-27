namespace AccountingFunctions
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TrackerView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.AccCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSSCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagibigCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DashboardButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exit = new System.Windows.Forms.Label();
            this.showingText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackerView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TrackerView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrackerView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TrackerView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TrackerView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrackerView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrackerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TrackerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrackerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccCol,
            this.BasicCol,
            this.SSSCol,
            this.PhDeduction,
            this.PagibigCol,
            this.TotalCol});
            this.TrackerView.DoubleBuffered = true;
            this.TrackerView.EnableHeadersVisualStyles = false;
            this.TrackerView.HeaderBgColor = System.Drawing.Color.DarkMagenta;
            this.TrackerView.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.TrackerView.Location = new System.Drawing.Point(283, 49);
            this.TrackerView.Name = "TrackerView";
            this.TrackerView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TrackerView.Size = new System.Drawing.Size(747, 524);
            this.TrackerView.TabIndex = 12;
            // 
            // AccCol
            // 
            this.AccCol.HeaderText = "Employee Account";
            this.AccCol.Name = "AccCol";
            this.AccCol.ReadOnly = true;
            this.AccCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AccCol.Width = 226;
            // 
            // BasicCol
            // 
            this.BasicCol.HeaderText = "Basic Pay";
            this.BasicCol.Name = "BasicCol";
            this.BasicCol.Width = 125;
            // 
            // SSSCol
            // 
            this.SSSCol.HeaderText = "SSS deduction";
            this.SSSCol.Name = "SSSCol";
            this.SSSCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SSSCol.Width = 75;
            // 
            // PhDeduction
            // 
            this.PhDeduction.HeaderText = "PhilHealth Deduction";
            this.PhDeduction.Name = "PhDeduction";
            this.PhDeduction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PhDeduction.Width = 75;
            // 
            // PagibigCol
            // 
            this.PagibigCol.HeaderText = "Pagibig Deduction";
            this.PagibigCol.Name = "PagibigCol";
            this.PagibigCol.Width = 75;
            // 
            // TotalCol
            // 
            this.TotalCol.HeaderText = "Total Pay";
            this.TotalCol.Name = "TotalCol";
            this.TotalCol.ReadOnly = true;
            this.TotalCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalCol.Width = 130;
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
            this.companyText.Location = new System.Drawing.Point(33, 120);
            this.companyText.Margin = new System.Windows.Forms.Padding(4);
            this.companyText.Name = "companyText";
            this.companyText.Size = new System.Drawing.Size(230, 44);
            this.companyText.TabIndex = 10;
            this.companyText.Text = "Company Placeholder";
            this.companyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.NameText.TabIndex = 11;
            this.NameText.Text = "Name Placeholder";
            this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.DashboardButton.TabIndex = 9;
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(74, 557);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 16);
            this.exit.TabIndex = 13;
            this.exit.Text = "exit application";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // showingText
            // 
            this.showingText.AutoSize = true;
            this.showingText.Cursor = System.Windows.Forms.Cursors.Default;
            this.showingText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingText.Location = new System.Drawing.Point(945, 576);
            this.showingText.Name = "showingText";
            this.showingText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showingText.Size = new System.Drawing.Size(88, 16);
            this.showingText.TabIndex = 14;
            this.showingText.Text = "Philippine Peso";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 645);
            this.Controls.Add(this.showingText);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.TrackerView);
            this.Controls.Add(this.companyText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.DashboardButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid TrackerView;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameText;
        private Bunifu.Framework.UI.BunifuThinButton2 DashboardButton;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSSCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagibigCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCol;
        private System.Windows.Forms.Label showingText;
    }
}