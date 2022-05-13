
namespace BarAmaldiGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.foodList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sauceList = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heatedList = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeButton = new System.Windows.Forms.Button();
            this.quantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.printButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // foodList
            // 
            this.foodList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.foodList.HideSelection = false;
            this.foodList.Location = new System.Drawing.Point(12, 12);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(294, 405);
            this.foodList.TabIndex = 0;
            this.foodList.UseCompatibleStateImageBehavior = false;
            this.foodList.View = System.Windows.Forms.View.Details;
            this.foodList.SelectedIndexChanged += new System.EventHandler(this.foodList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 23;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrizione";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salse";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Riscaldabile";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prezzo";
            // 
            // sauceList
            // 
            this.sauceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.sauceList.HideSelection = false;
            this.sauceList.Location = new System.Drawing.Point(313, 12);
            this.sauceList.Name = "sauceList";
            this.sauceList.Size = new System.Drawing.Size(153, 109);
            this.sauceList.TabIndex = 1;
            this.sauceList.UseCompatibleStateImageBehavior = false;
            this.sauceList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Salse";
            this.columnHeader6.Width = 146;
            // 
            // heatedList
            // 
            this.heatedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.heatedList.HideSelection = false;
            this.heatedList.Location = new System.Drawing.Point(313, 127);
            this.heatedList.Name = "heatedList";
            this.heatedList.Size = new System.Drawing.Size(154, 109);
            this.heatedList.TabIndex = 2;
            this.heatedList.UseCompatibleStateImageBehavior = false;
            this.heatedList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Riscaldato";
            this.columnHeader7.Width = 147;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(313, 268);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(154, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Aggiungi all\'ordine";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // orderList
            // 
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8});
            this.orderList.HideSelection = false;
            this.orderList.Location = new System.Drawing.Point(473, 12);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(316, 405);
            this.orderList.TabIndex = 4;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.orderList_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ordine";
            this.columnHeader8.Width = 310;
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(313, 297);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(154, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Rimuovi dall\'ordine";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // quantityNumeric
            // 
            this.quantityNumeric.Location = new System.Drawing.Point(313, 242);
            this.quantityNumeric.Name = "quantityNumeric";
            this.quantityNumeric.Size = new System.Drawing.Size(153, 20);
            this.quantityNumeric.TabIndex = 6;
            // 
            // printButton
            // 
            this.printButton.Enabled = false;
            this.printButton.Location = new System.Drawing.Point(313, 326);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(153, 23);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Stampa l\'ordine";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(470, 420);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(319, 23);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Prezzo totale: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.quantityNumeric);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.heatedList);
            this.Controls.Add(this.sauceList);
            this.Controls.Add(this.foodList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView foodList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView sauceList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView heatedList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.NumericUpDown quantityNumeric;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label priceLabel;
    }
}

