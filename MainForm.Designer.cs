/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


namespace Shoppinglist
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Amount = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.AmountTXTBox = new System.Windows.Forms.TextBox();
            this.DescriptionTXTBox = new System.Windows.Forms.TextBox();
            this.listOfItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.cmbUnit);
            this.groupBox1.Controls.Add(this.AmountTXTBox);
            this.groupBox1.Controls.Add(this.DescriptionTXTBox);
            this.groupBox1.Location = new System.Drawing.Point(29, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(10, 73);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "Amount";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(7, 26);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description";
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(222, 66);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbUnit.TabIndex = 2;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.CmbUnit_SelectedIndexChanged);
            // 
            // AmountTXTBox
            // 
            this.AmountTXTBox.Location = new System.Drawing.Point(116, 67);
            this.AmountTXTBox.Name = "AmountTXTBox";
            this.AmountTXTBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTXTBox.TabIndex = 1;
            // 
            // DescriptionTXTBox
            // 
            this.DescriptionTXTBox.Location = new System.Drawing.Point(116, 20);
            this.DescriptionTXTBox.Name = "DescriptionTXTBox";
            this.DescriptionTXTBox.Size = new System.Drawing.Size(227, 20);
            this.DescriptionTXTBox.TabIndex = 0;
            // 
            // listOfItems
            // 
            this.listOfItems.FormattingEnabled = true;
            this.listOfItems.Location = new System.Drawing.Point(29, 191);
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.Size = new System.Drawing.Size(619, 316);
            this.listOfItems.TabIndex = 1;
            this.listOfItems.SelectedIndexChanged += new System.EventHandler(this.ListOfItems_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(470, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(470, 71);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(129, 42);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = true;
           // this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(470, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 42);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 528);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listOfItems);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Shoppinglist";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox AmountTXTBox;
        private System.Windows.Forms.TextBox DescriptionTXTBox;
        private System.Windows.Forms.ListBox listOfItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}

