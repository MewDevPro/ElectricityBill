using System.Reflection;
using System.Windows.Forms;

namespace ElectricityBill
{
    partial class ElectricityLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectricityLayout));
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOldNumber = new System.Windows.Forms.Label();
            this.labelQuota = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelNewNumber = new System.Windows.Forms.Label();
            this.CName = new System.Windows.Forms.TextBox();
            this.CLocation = new System.Windows.Forms.ComboBox();
            this.COldNumber = new System.Windows.Forms.TextBox();
            this.CNewNumber = new System.Windows.Forms.TextBox();
            this.labelComsume = new System.Windows.Forms.Label();
            this.labelIntoMoney = new System.Windows.Forms.Label();
            this.RConsume = new System.Windows.Forms.Label();
            this.RMoney = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BillList = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientQuota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientOldNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientNewNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientConsuma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RQuota = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHeader.Location = new System.Drawing.Point(49, 26);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(111, 15);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Bảng tính tiền điện";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F);
            this.labelName.Location = new System.Drawing.Point(48, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Tên KH:";
            // 
            // labelOldNumber
            // 
            this.labelOldNumber.AutoSize = true;
            this.labelOldNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.labelOldNumber.Location = new System.Drawing.Point(48, 160);
            this.labelOldNumber.Name = "labelOldNumber";
            this.labelOldNumber.Size = new System.Drawing.Size(41, 15);
            this.labelOldNumber.TabIndex = 2;
            this.labelOldNumber.Text = "Số cũ:";
            // 
            // labelQuota
            // 
            this.labelQuota.AutoSize = true;
            this.labelQuota.Font = new System.Drawing.Font("Arial", 9F);
            this.labelQuota.Location = new System.Drawing.Point(48, 128);
            this.labelQuota.Name = "labelQuota";
            this.labelQuota.Size = new System.Drawing.Size(64, 15);
            this.labelQuota.TabIndex = 3;
            this.labelQuota.Text = "Định mức:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Arial", 9F);
            this.labelLocation.Location = new System.Drawing.Point(48, 96);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(54, 15);
            this.labelLocation.TabIndex = 4;
            this.labelLocation.Text = "Khu vực:";
            // 
            // labelNewNumber
            // 
            this.labelNewNumber.AutoSize = true;
            this.labelNewNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.labelNewNumber.Location = new System.Drawing.Point(48, 192);
            this.labelNewNumber.Name = "labelNewNumber";
            this.labelNewNumber.Size = new System.Drawing.Size(50, 15);
            this.labelNewNumber.TabIndex = 5;
            this.labelNewNumber.Text = "Số mới:";
            // 
            // CName
            // 
            this.CName.Font = new System.Drawing.Font("Arial", 9F);
            this.CName.Location = new System.Drawing.Point(160, 56);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(360, 21);
            this.CName.TabIndex = 6;
            // 
            // CLocation
            // 
            this.CLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CLocation.Font = new System.Drawing.Font("Arial", 9F);
            this.CLocation.FormattingEnabled = true;
            this.CLocation.Items.AddRange(new object[] {
            "Khu vực 1",
            "Khu vực 2",
            "Khu vực 3",
            "Khu vực 4",
            "Khu vực 5"});
            this.CLocation.Location = new System.Drawing.Point(160, 88);
            this.CLocation.Name = "CLocation";
            this.CLocation.Size = new System.Drawing.Size(360, 23);
            this.CLocation.TabIndex = 7;
            // 
            // COldNumber
            // 
            this.COldNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.COldNumber.Location = new System.Drawing.Point(160, 152);
            this.COldNumber.Name = "COldNumber";
            this.COldNumber.Size = new System.Drawing.Size(360, 21);
            this.COldNumber.TabIndex = 9;
            // 
            // CNewNumber
            // 
            this.CNewNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.CNewNumber.Location = new System.Drawing.Point(160, 184);
            this.CNewNumber.Name = "CNewNumber";
            this.CNewNumber.Size = new System.Drawing.Size(360, 21);
            this.CNewNumber.TabIndex = 10;
            // 
            // labelComsume
            // 
            this.labelComsume.AutoSize = true;
            this.labelComsume.Font = new System.Drawing.Font("Arial", 9F);
            this.labelComsume.Location = new System.Drawing.Point(48, 224);
            this.labelComsume.Name = "labelComsume";
            this.labelComsume.Size = new System.Drawing.Size(79, 15);
            this.labelComsume.TabIndex = 11;
            this.labelComsume.Text = "Điện tiêu thụ:";
            // 
            // labelIntoMoney
            // 
            this.labelIntoMoney.AutoSize = true;
            this.labelIntoMoney.Font = new System.Drawing.Font("Arial", 9F);
            this.labelIntoMoney.Location = new System.Drawing.Point(48, 256);
            this.labelIntoMoney.Name = "labelIntoMoney";
            this.labelIntoMoney.Size = new System.Drawing.Size(68, 15);
            this.labelIntoMoney.TabIndex = 12;
            this.labelIntoMoney.Text = "Thành tiền:";
            // 
            // RConsume
            // 
            this.RConsume.AutoSize = true;
            this.RConsume.Font = new System.Drawing.Font("Arial", 9F);
            this.RConsume.Location = new System.Drawing.Point(160, 224);
            this.RConsume.Name = "RConsume";
            this.RConsume.Size = new System.Drawing.Size(0, 15);
            this.RConsume.TabIndex = 13;
            // 
            // RMoney
            // 
            this.RMoney.AutoSize = true;
            this.RMoney.Font = new System.Drawing.Font("Arial", 9F);
            this.RMoney.Location = new System.Drawing.Point(160, 256);
            this.RMoney.Name = "RMoney";
            this.RMoney.Size = new System.Drawing.Size(0, 15);
            this.RMoney.TabIndex = 14;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Arial", 10F);
            this.BtnCalc.Location = new System.Drawing.Point(584, 56);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(176, 56);
            this.BtnCalc.TabIndex = 15;
            this.BtnCalc.Text = "Tính tiền";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Arial", 10F);
            this.BtnAdd.Location = new System.Drawing.Point(584, 152);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(176, 56);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BillList
            // 
            this.BillList.AutoArrange = false;
            this.BillList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.ClientName,
            this.ClientLocation,
            this.ClientQuota,
            this.ClientOldNumber,
            this.ClientNewNumber,
            this.ClientConsuma,
            this.ClientMoney});
            this.BillList.Font = new System.Drawing.Font("Arial", 9F);
            this.BillList.HideSelection = false;
            this.BillList.Location = new System.Drawing.Point(48, 296);
            this.BillList.Name = "BillList";
            this.BillList.Scrollable = false;
            this.BillList.Size = new System.Drawing.Size(712, 312);
            this.BillList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.BillList.TabIndex = 17;
            this.BillList.UseCompatibleStateImageBehavior = false;
            this.BillList.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Text = "STT";
            this.Index.Width = 40;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Tên khách hàng";
            this.ClientName.Width = 150;
            // 
            // ClientLocation
            // 
            this.ClientLocation.Text = "Khu vực";
            this.ClientLocation.Width = 75;
            // 
            // ClientQuota
            // 
            this.ClientQuota.Text = "Định mức";
            this.ClientQuota.Width = 104;
            // 
            // ClientOldNumber
            // 
            this.ClientOldNumber.Text = "Số cũ";
            // 
            // ClientNewNumber
            // 
            this.ClientNewNumber.Text = "Số mới";
            // 
            // ClientConsuma
            // 
            this.ClientConsuma.Text = "Điện tiêu thụ";
            this.ClientConsuma.Width = 85;
            // 
            // ClientMoney
            // 
            this.ClientMoney.Text = "Thành tiền";
            this.ClientMoney.Width = 135;
            // 
            // RQuota
            // 
            this.RQuota.AutoSize = true;
            this.RQuota.Font = new System.Drawing.Font("Arial", 9F);
            this.RQuota.Location = new System.Drawing.Point(160, 128);
            this.RQuota.Name = "RQuota";
            this.RQuota.Size = new System.Drawing.Size(0, 15);
            this.RQuota.TabIndex = 18;
            // 
            // Copyright
            // 
            this.Copyright.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Copyright.AutoSize = true;
            this.Copyright.LinkColor = System.Drawing.Color.Black;
            this.Copyright.Location = new System.Drawing.Point(328, 624);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(151, 13);
            this.Copyright.TabIndex = 19;
            this.Copyright.TabStop = true;
            this.Copyright.Text = "Copyright ©️ 2023 MeewMeew";
            this.Copyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Copyright_LinkClicked);
            // 
            // ElectricityLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 649);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.RQuota);
            this.Controls.Add(this.BillList);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.RMoney);
            this.Controls.Add(this.RConsume);
            this.Controls.Add(this.labelIntoMoney);
            this.Controls.Add(this.labelComsume);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.CNewNumber);
            this.Controls.Add(this.COldNumber);
            this.Controls.Add(this.CLocation);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.labelNewNumber);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelQuota);
            this.Controls.Add(this.labelOldNumber);
            this.Controls.Add(this.labelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElectricityLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electricity Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOldNumber;
        private System.Windows.Forms.Label labelQuota;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelNewNumber;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.ComboBox CLocation;
        private System.Windows.Forms.TextBox COldNumber;
        private System.Windows.Forms.TextBox CNewNumber;
        private System.Windows.Forms.Label labelComsume;
        private System.Windows.Forms.Label labelIntoMoney;
        private System.Windows.Forms.Label RConsume;
        private System.Windows.Forms.Label RMoney;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListView BillList;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader ClientLocation;
        private System.Windows.Forms.ColumnHeader ClientQuota;
        private System.Windows.Forms.ColumnHeader ClientOldNumber;
        private System.Windows.Forms.ColumnHeader ClientNewNumber;
        private System.Windows.Forms.ColumnHeader ClientConsuma;
        private System.Windows.Forms.ColumnHeader ClientMoney;
        private System.Windows.Forms.Label RQuota;
        private System.Windows.Forms.LinkLabel Copyright;
    }
}

