namespace TeknoSatis
{
    partial class Sell
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
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtcsname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSell = new System.Windows.Forms.ListView();
            this.btncomplete = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(117, 48);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(153, 20);
            this.txtcname.TabIndex = 0;
            // 
            // txtcsname
            // 
            this.txtcsname.Location = new System.Drawing.Point(117, 97);
            this.txtcsname.Name = "txtcsname";
            this.txtcsname.Size = new System.Drawing.Size(153, 20);
            this.txtcsname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Surname";
            // 
            // lstSell
            // 
            this.lstSell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lstSell.GridLines = true;
            this.lstSell.Location = new System.Drawing.Point(333, 48);
            this.lstSell.Name = "lstSell";
            this.lstSell.Size = new System.Drawing.Size(393, 97);
            this.lstSell.TabIndex = 4;
            this.lstSell.UseCompatibleStateImageBehavior = false;
            this.lstSell.View = System.Windows.Forms.View.Details;
            // 
            // btncomplete
            // 
            this.btncomplete.Location = new System.Drawing.Point(117, 187);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(181, 49);
            this.btncomplete.TabIndex = 5;
            this.btncomplete.Text = "Complete Sell";
            this.btncomplete.UseVisualStyleBackColor = true;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductName";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UnitPrice";
            this.columnHeader3.Width = 210;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Price : ";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.HideSelection = false;
            this.txtPrice.Location = new System.Drawing.Point(118, 147);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(152, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 411);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.lstSell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcsname);
            this.Controls.Add(this.txtcname);
            this.Name = "Sell";
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.Sell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtcsname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstSell;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btncomplete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
    }
}