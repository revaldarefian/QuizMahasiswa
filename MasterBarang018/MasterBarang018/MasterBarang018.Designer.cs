namespace MasterBarang018
{
    partial class MasterBarang018
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
            this.cbSupp = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSupp
            // 
            this.cbSupp.FormattingEnabled = true;
            this.cbSupp.Location = new System.Drawing.Point(195, 265);
            this.cbSupp.Name = "cbSupp";
            this.cbSupp.Size = new System.Drawing.Size(121, 21);
            this.cbSupp.TabIndex = 15;
            this.cbSupp.SelectedIndexChanged += new System.EventHandler(this.cbSupp_SelectedIndexChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(195, 228);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 11;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(195, 193);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 12;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(195, 154);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(100, 20);
            this.txtNamaBarang.TabIndex = 13;
            this.txtNamaBarang.TextChanged += new System.EventHandler(this.txtNamaBarang_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(195, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 14;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(151, 326);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "NAMA SUPPLIER";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "STOCK";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "HARGA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NAMA BARANG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID BARANG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "FORM INPUT BARANG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MasterBarang018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.cbSupp);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MasterBarang018";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MasterBarang018_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSupp;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

