namespace Lopputyo
{
    partial class Inventory
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
            this.itemsList = new System.Windows.Forms.ListBox();
            this.sellbtn = new System.Windows.Forms.Button();
            this.sellallbtn = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.worth = new System.Windows.Forms.Label();
            this.itemworth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsList
            // 
            this.itemsList.FormattingEnabled = true;
            this.itemsList.ItemHeight = 16;
            this.itemsList.Location = new System.Drawing.Point(16, 22);
            this.itemsList.Margin = new System.Windows.Forms.Padding(4);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(292, 516);
            this.itemsList.TabIndex = 0;
            // 
            // sellbtn
            // 
            this.sellbtn.Location = new System.Drawing.Point(315, 515);
            this.sellbtn.Name = "sellbtn";
            this.sellbtn.Size = new System.Drawing.Size(101, 23);
            this.sellbtn.TabIndex = 1;
            this.sellbtn.Text = "Sell Selected";
            this.sellbtn.UseVisualStyleBackColor = true;
            this.sellbtn.Click += new System.EventHandler(this.sellbtn_Click);
            // 
            // sellallbtn
            // 
            this.sellallbtn.Location = new System.Drawing.Point(315, 486);
            this.sellallbtn.Name = "sellallbtn";
            this.sellallbtn.Size = new System.Drawing.Size(101, 23);
            this.sellallbtn.TabIndex = 1;
            this.sellallbtn.Text = "Sell All";
            this.sellallbtn.UseVisualStyleBackColor = true;
            this.sellallbtn.Click += new System.EventHandler(this.sellallbtn_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(905, 9);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(63, 16);
            this.balance.TabIndex = 2;
            this.balance.Text = "Balance: ";
            // 
            // worth
            // 
            this.worth.AutoSize = true;
            this.worth.Location = new System.Drawing.Point(315, 9);
            this.worth.Name = "worth";
            this.worth.Size = new System.Drawing.Size(101, 16);
            this.worth.TabIndex = 2;
            this.worth.Text = "Inventory worth: ";
            // 
            // itemworth
            // 
            this.itemworth.AutoSize = true;
            this.itemworth.Location = new System.Drawing.Point(315, 34);
            this.itemworth.Name = "itemworth";
            this.itemworth.Size = new System.Drawing.Size(129, 16);
            this.itemworth.TabIndex = 2;
            this.itemworth.Text = "Selected item worth: ";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.itemworth);
            this.Controls.Add(this.worth);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.sellallbtn);
            this.Controls.Add(this.sellbtn);
            this.Controls.Add(this.itemsList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.Button sellbtn;
        private System.Windows.Forms.Button sellallbtn;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label worth;
        private System.Windows.Forms.Label itemworth;
    }
}