namespace SalesManager
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
            this.food = new System.Windows.Forms.RadioButton();
            this.drink = new System.Windows.Forms.RadioButton();
            this.domesticUtensil = new System.Windows.Forms.RadioButton();
            this.officeSupplie = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.addItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.basePrice = new System.Windows.Forms.NumericUpDown();
            this.tax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Lucro = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.report_product_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.report_product_code = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profit)).BeginInit();
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
            this.createNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createNewSale.Location = new System.Drawing.Point(144, 393);
            this.createNewSale.Name = "createNewSale";
            this.createNewSale.Size = new System.Drawing.Size(202, 44);
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
            this.console.Size = new System.Drawing.Size(479, 622);
            this.console.TabIndex = 2;
            this.console.Text = "";
            // 
            // food
            // 
            this.food.AutoSize = true;
            this.food.Location = new System.Drawing.Point(33, 105);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(88, 24);
            this.food.TabIndex = 3;
            this.food.Text = "Comida";
            this.food.UseVisualStyleBackColor = true;
            // 
            // drink
            // 
            this.drink.AutoSize = true;
            this.drink.Checked = true;
            this.drink.Location = new System.Drawing.Point(33, 75);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(84, 24);
            this.drink.TabIndex = 4;
            this.drink.TabStop = true;
            this.drink.Text = "Bebida";
            this.drink.UseVisualStyleBackColor = true;
            // 
            // domesticUtensil
            // 
            this.domesticUtensil.AutoSize = true;
            this.domesticUtensil.Location = new System.Drawing.Point(33, 165);
            this.domesticUtensil.Name = "domesticUtensil";
            this.domesticUtensil.Size = new System.Drawing.Size(191, 24);
            this.domesticUtensil.TabIndex = 5;
            this.domesticUtensil.Text = "Utensílios Domesticos";
            this.domesticUtensil.UseVisualStyleBackColor = true;
            // 
            // officeSupplie
            // 
            this.officeSupplie.AutoSize = true;
            this.officeSupplie.Location = new System.Drawing.Point(33, 135);
            this.officeSupplie.Name = "officeSupplie";
            this.officeSupplie.Size = new System.Drawing.Size(180, 24);
            this.officeSupplie.TabIndex = 6;
            this.officeSupplie.Text = "Material de escritório";
            this.officeSupplie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amount";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(29, 361);
            this.amount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(109, 26);
            this.amount.TabIndex = 9;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(29, 393);
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
            this.label2.Location = new System.Drawing.Point(29, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(29, 228);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(224, 26);
            this.name.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Preço Base";
            // 
            // basePrice
            // 
            this.basePrice.DecimalPlaces = 2;
            this.basePrice.Location = new System.Drawing.Point(29, 290);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(109, 26);
            this.basePrice.TabIndex = 15;
            // 
            // tax
            // 
            this.tax.DecimalPlaces = 2;
            this.tax.Location = new System.Drawing.Point(145, 289);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(108, 26);
            this.tax.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lucro";
            // 
            // Lucro
            // 
            this.Lucro.AutoSize = true;
            this.Lucro.Location = new System.Drawing.Point(144, 339);
            this.Lucro.Name = "Lucro";
            this.Lucro.Size = new System.Drawing.Size(34, 20);
            this.Lucro.TabIndex = 19;
            this.Lucro.Text = "Tax";
            // 
            // profit
            // 
            this.profit.DecimalPlaces = 2;
            this.profit.Location = new System.Drawing.Point(144, 361);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(108, 26);
            this.profit.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 29);
            this.button2.TabIndex = 21;
            this.button2.Text = "GetSales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // report_product_name
            // 
            this.report_product_name.Location = new System.Drawing.Point(28, 480);
            this.report_product_name.Name = "report_product_name";
            this.report_product_name.Size = new System.Drawing.Size(147, 26);
            this.report_product_name.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Product Code";
            // 
            // report_product_code
            // 
            this.report_product_code.Location = new System.Drawing.Point(195, 480);
            this.report_product_code.Name = "report_product_code";
            this.report_product_code.Size = new System.Drawing.Size(147, 26);
            this.report_product_code.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Get Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "Show Amount Earned and Spent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 692);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.report_product_code);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.report_product_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lucro);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.basePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.officeSupplie);
            this.Controls.Add(this.domesticUtensil);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.food);
            this.Controls.Add(this.console);
            this.Controls.Add(this.createNewSale);
            this.Controls.Add(this.titleLabe);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabe;
        private System.Windows.Forms.Button createNewSale;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.RadioButton food;
        private System.Windows.Forms.RadioButton drink;
        private System.Windows.Forms.RadioButton domesticUtensil;
        private System.Windows.Forms.RadioButton officeSupplie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown basePrice;
        private System.Windows.Forms.NumericUpDown tax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lucro;
        private System.Windows.Forms.NumericUpDown profit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox report_product_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox report_product_code;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

