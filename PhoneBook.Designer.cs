
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SPhoneDic
{
    partial class PhoneBook
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
            this.phoneBookGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.mailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.seedButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchPhoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneBookGridView
            // 
            this.phoneBookGridView.AllowUserToAddRows = false;
            this.phoneBookGridView.AllowUserToDeleteRows = false;
            this.phoneBookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneBookGridView.Location = new System.Drawing.Point(323, 129);
            this.phoneBookGridView.MultiSelect = false;
            this.phoneBookGridView.Name = "phoneBookGridView";
            this.phoneBookGridView.ReadOnly = true;
            this.phoneBookGridView.RowHeadersWidth = 51;
            this.phoneBookGridView.RowTemplate.Height = 24;
            this.phoneBookGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phoneBookGridView.Size = new System.Drawing.Size(472, 282);
            this.phoneBookGridView.TabIndex = 0;
            this.phoneBookGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phoneBookGridView_CellClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(655, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 28);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search by Name";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(72, 160);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(232, 22);
            this.nameText.TabIndex = 8;
            // 
            // mailText
            // 
            this.mailText.Location = new System.Drawing.Point(72, 204);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(232, 22);
            this.mailText.TabIndex = 8;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(72, 252);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(232, 22);
            this.phoneText.TabIndex = 8;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(72, 290);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(232, 22);
            this.addressText.TabIndex = 8;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(323, 56);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(317, 22);
            this.searchText.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(71, 347);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(242, 347);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Location = new System.Drawing.Point(72, 50);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(232, 70);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Clear All Contact";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter Name or Phone number  to search";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(152, 347);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Update";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(71, 347);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // seedButton
            // 
            this.seedButton.Location = new System.Drawing.Point(713, 417);
            this.seedButton.Name = "seedButton";
            this.seedButton.Size = new System.Drawing.Size(75, 23);
            this.seedButton.TabIndex = 16;
            this.seedButton.Text = "Seed Data";
            this.seedButton.UseVisualStyleBackColor = true;
            this.seedButton.Click += new System.EventHandler(this.seedButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 129);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 17);
            this.idLabel.TabIndex = 17;
            this.idLabel.Text = "Id";
            this.idLabel.Visible = false;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(72, 129);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(232, 22);
            this.idText.TabIndex = 18;
            this.idText.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "(*) = required";
            // 
            // searchPhoneButton
            // 
            this.searchPhoneButton.Location = new System.Drawing.Point(655, 92);
            this.searchPhoneButton.Name = "searchPhoneButton";
            this.searchPhoneButton.Size = new System.Drawing.Size(133, 28);
            this.searchPhoneButton.TabIndex = 20;
            this.searchPhoneButton.Text = "Search by Phone";
            this.searchPhoneButton.UseVisualStyleBackColor = true;
            this.searchPhoneButton.Click += new System.EventHandler(this.searchPhoneButton_Click);
            // 
            // PhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchPhoneButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.seedButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.phoneBookGridView);
            this.Name = "PhoneBook";
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.PhoneBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView phoneBookGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox mailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editButton;
        private Button clearButton;
        private Button seedButton;
        private Label idLabel;
        private TextBox idText;
        private Label label6;
        private Button searchPhoneButton;
    }
    
}

