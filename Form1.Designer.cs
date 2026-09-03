namespace Lopputyo
{
    partial class Form1
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
            this.openbtn = new System.Windows.Forms.Button();
            this.opened = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.invbtn = new System.Windows.Forms.Button();
            this.openbtnbox2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openbtnbox3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openbtn
            // 
            this.openbtn.Location = new System.Drawing.Point(347, 207);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(75, 23);
            this.openbtn.TabIndex = 0;
            this.openbtn.Text = "Open";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // opened
            // 
            this.opened.Location = new System.Drawing.Point(10, 17);
            this.opened.Name = "opened";
            this.opened.Size = new System.Drawing.Size(213, 25);
            this.opened.TabIndex = 1;
            this.opened.Text = "Opened: ";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(674, 17);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(52, 13);
            this.balance.TabIndex = 2;
            this.balance.Text = "Balance: ";
            // 
            // invbtn
            // 
            this.invbtn.Location = new System.Drawing.Point(350, 316);
            this.invbtn.Name = "invbtn";
            this.invbtn.Size = new System.Drawing.Size(75, 23);
            this.invbtn.TabIndex = 3;
            this.invbtn.Text = "Inventory";
            this.invbtn.UseVisualStyleBackColor = true;
            this.invbtn.Click += new System.EventHandler(this.InvBtn_Click);
            // 
            // openbtnbox2
            // 
            this.openbtnbox2.Location = new System.Drawing.Point(529, 207);
            this.openbtnbox2.Name = "openbtnbox2";
            this.openbtnbox2.Size = new System.Drawing.Size(75, 23);
            this.openbtnbox2.TabIndex = 0;
            this.openbtnbox2.Text = "Open";
            this.openbtnbox2.UseVisualStyleBackColor = true;
            this.openbtnbox2.Click += new System.EventHandler(this.OpenBox2Btn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(345, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Free box";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(526, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rare Box [50 Coins]";
            // 
            // openbtnbox3
            // 
            this.openbtnbox3.Location = new System.Drawing.Point(160, 207);
            this.openbtnbox3.Name = "openbtnbox3";
            this.openbtnbox3.Size = new System.Drawing.Size(75, 23);
            this.openbtnbox3.TabIndex = 0;
            this.openbtnbox3.Text = "Open";
            this.openbtnbox3.UseVisualStyleBackColor = true;
            this.openbtnbox3.Click += new System.EventHandler(this.OpenBox1Btn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(158, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Common Box [20 Coins]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invbtn);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opened);
            this.Controls.Add(this.openbtnbox3);
            this.Controls.Add(this.openbtnbox2);
            this.Controls.Add(this.openbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.Label opened;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button invbtn;
        private System.Windows.Forms.Button openbtnbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openbtnbox3;
        private System.Windows.Forms.Label label3;
    }
}