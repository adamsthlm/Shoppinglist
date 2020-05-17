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
            this.listOfItems.Location = new System.Drawing.Point(29, 160);
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.Size = new System.Drawing.Size(619, 264);
            this.listOfItems.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(459, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
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
    }
}

