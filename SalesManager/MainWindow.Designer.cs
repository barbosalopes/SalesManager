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
            this.createNewSale.Location = new System.Drawing.Point(208, 410);
            this.createNewSale.Name = "createNewSale";
            this.createNewSale.Size = new System.Drawing.Size(200, 60);
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
            this.console.Size = new System.Drawing.Size(344, 412);
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
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade";
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
            this.Lucro.Size = new System.Drawing.Size(43, 20);
            this.Lucro.TabIndex = 19;
            this.Lucro.Text = "Taxa";
            // 
            // profit
            // 
            this.profit.DecimalPlaces = 2;
            this.profit.Location = new System.Drawing.Point(144, 361);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(108, 26);
            this.profit.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.Lucro);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.label4);
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
    }
}

