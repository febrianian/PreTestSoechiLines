namespace PreTestSoechiLines.FormMaster
{
    partial class Transaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtitemdesc = new System.Windows.Forms.TextBox();
            this.txtuom = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtdiscountamt = new System.Windows.Forms.TextBox();
            this.txtrates = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtqtykecil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Desc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "UOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "QTY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount Amt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // txtitemdesc
            // 
            this.txtitemdesc.Location = new System.Drawing.Point(125, 22);
            this.txtitemdesc.Name = "txtitemdesc";
            this.txtitemdesc.Size = new System.Drawing.Size(182, 22);
            this.txtitemdesc.TabIndex = 7;
            // 
            // txtuom
            // 
            this.txtuom.Location = new System.Drawing.Point(125, 50);
            this.txtuom.Name = "txtuom";
            this.txtuom.Size = new System.Drawing.Size(182, 22);
            this.txtuom.TabIndex = 8;
            this.txtuom.TextChanged += new System.EventHandler(this.txtuom_TextChanged);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(125, 78);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(182, 22);
            this.txtqty.TabIndex = 9;
            this.txtqty.Text = "0";
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(125, 109);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(182, 22);
            this.txtunitprice.TabIndex = 10;
            this.txtunitprice.Text = "0";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(125, 193);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(182, 22);
            this.txttotal.TabIndex = 11;
            this.txttotal.Text = "0";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(125, 137);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(182, 22);
            this.txtdiscount.TabIndex = 12;
            this.txtdiscount.Text = "0";
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // txtdiscountamt
            // 
            this.txtdiscountamt.Enabled = false;
            this.txtdiscountamt.Location = new System.Drawing.Point(125, 165);
            this.txtdiscountamt.Name = "txtdiscountamt";
            this.txtdiscountamt.Size = new System.Drawing.Size(182, 22);
            this.txtdiscountamt.TabIndex = 13;
            this.txtdiscountamt.Text = "0";
            // 
            // txtrates
            // 
            this.txtrates.Enabled = false;
            this.txtrates.Location = new System.Drawing.Point(393, 50);
            this.txtrates.Name = "txtrates";
            this.txtrates.Size = new System.Drawing.Size(96, 22);
            this.txtrates.TabIndex = 14;
            this.txtrates.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Qty Kecil";
            // 
            // txtqtykecil
            // 
            this.txtqtykecil.Enabled = false;
            this.txtqtykecil.Location = new System.Drawing.Point(393, 78);
            this.txtqtykecil.Name = "txtqtykecil";
            this.txtqtykecil.Size = new System.Drawing.Size(96, 22);
            this.txtqtykecil.TabIndex = 16;
            this.txtqtykecil.Text = "0";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 237);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtqtykecil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtrates);
            this.Controls.Add(this.txtdiscountamt);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtuom);
            this.Controls.Add(this.txtitemdesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtitemdesc;
        private System.Windows.Forms.TextBox txtuom;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtdiscountamt;
        private System.Windows.Forms.TextBox txtrates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtqtykecil;
    }
}