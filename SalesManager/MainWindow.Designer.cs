﻿namespace SalesManager
{
    partial class MainWindow
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
            this.titleLabe = new System.Windows.Forms.Label();
            this.createNewSale = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.addItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.report_product_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.report_product_code = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabe
            // 
            this.titleLabe.AutoSize = true;
            this.titleLabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabe.Location = new System.Drawing.Point(243, 9);
            this.titleLabe.Name = "titleLabe";
            this.titleLabe.Size = new System.Drawing.Size(287, 46);
            this.titleLabe.TabIndex = 0;
            this.titleLabe.Text = "Sales Manager";
            // 
            // createNewSale
            // 
            this.createNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.createNewSale.Location = new System.Drawing.Point(179, 194);
            this.createNewSale.Name = "createNewSale";
            this.createNewSale.Size = new System.Drawing.Size(158, 33);
            this.createNewSale.TabIndex = 1;
            this.createNewSale.TabStop = false;
            this.createNewSale.Text = "Create new sale";
            this.createNewSale.UseVisualStyleBackColor = true;
            this.createNewSale.Click += new System.EventHandler(this.createNewSale_Click);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(444, 58);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(479, 371);
            this.console.TabIndex = 2;
            this.console.Text = "";
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(241, 155);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(96, 33);
            this.addItem.TabIndex = 10;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(24, 104);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(313, 26);
            this.name.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 29);
            this.button2.TabIndex = 21;
            this.button2.Text = "GetSales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // report_product_name
            // 
            this.report_product_name.Location = new System.Drawing.Point(28, 268);
            this.report_product_name.Name = "report_product_name";
            this.report_product_name.Size = new System.Drawing.Size(147, 26);
            this.report_product_name.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Product Code";
            // 
            // report_product_code
            // 
            this.report_product_code.Location = new System.Drawing.Point(195, 268);
            this.report_product_code.Name = "report_product_code";
            this.report_product_code.Size = new System.Drawing.Size(147, 26);
            this.report_product_code.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Get Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "Show Amount Earned and Spent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(312, 29);
            this.button4.TabIndex = 28;
            this.button4.Text = "Show The product With biggest profit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Reports";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Register new sell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amount";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(24, 159);
            this.amount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(211, 26);
            this.amount.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 448);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.report_product_code);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.report_product_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.createNewSale);
            this.Controls.Add(this.titleLabe);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabe;
        private System.Windows.Forms.Button createNewSale;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox report_product_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox report_product_code;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amount;
    }
}

