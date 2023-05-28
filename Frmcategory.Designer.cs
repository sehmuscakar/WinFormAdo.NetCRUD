namespace Ado.NetGiriş
{
    partial class Frmcategory
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
            this.btncategorySil = new System.Windows.Forms.Button();
            this.btncategoryguncelle = new System.Windows.Forms.Button();
            this.btncategoryEkle = new System.Windows.Forms.Button();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkategoriıd = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncategorySil);
            this.groupBox1.Controls.Add(this.btncategoryguncelle);
            this.groupBox1.Controls.Add(this.btncategoryEkle);
            this.groupBox1.Controls.Add(this.txtcategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblkategoriıd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(46, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Kayıt";
            // 
            // btncategorySil
            // 
            this.btncategorySil.Location = new System.Drawing.Point(391, 230);
            this.btncategorySil.Name = "btncategorySil";
            this.btncategorySil.Size = new System.Drawing.Size(133, 41);
            this.btncategorySil.TabIndex = 9;
            this.btncategorySil.Text = "Sil";
            this.btncategorySil.UseVisualStyleBackColor = true;
            this.btncategorySil.Click += new System.EventHandler(this.btncategorySil_Click);
            // 
            // btncategoryguncelle
            // 
            this.btncategoryguncelle.Location = new System.Drawing.Point(230, 230);
            this.btncategoryguncelle.Name = "btncategoryguncelle";
            this.btncategoryguncelle.Size = new System.Drawing.Size(133, 41);
            this.btncategoryguncelle.TabIndex = 8;
            this.btncategoryguncelle.Text = "Güncelle";
            this.btncategoryguncelle.UseVisualStyleBackColor = true;
            this.btncategoryguncelle.Click += new System.EventHandler(this.btncategoryguncelle_Click);
            // 
            // btncategoryEkle
            // 
            this.btncategoryEkle.Location = new System.Drawing.Point(67, 230);
            this.btncategoryEkle.Name = "btncategoryEkle";
            this.btncategoryEkle.Size = new System.Drawing.Size(133, 41);
            this.btncategoryEkle.TabIndex = 7;
            this.btncategoryEkle.Text = "Kaydet";
            this.btncategoryEkle.UseVisualStyleBackColor = true;
            this.btncategoryEkle.Click += new System.EventHandler(this.btncategoryEkle_Click);
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(159, 116);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(164, 34);
            this.txtcategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori:";
            // 
            // lblkategoriıd
            // 
            this.lblkategoriıd.AutoSize = true;
            this.lblkategoriıd.Location = new System.Drawing.Point(30, 45);
            this.lblkategoriıd.Name = "lblkategoriıd";
            this.lblkategoriıd.Size = new System.Drawing.Size(26, 29);
            this.lblkategoriıd.TabIndex = 0;
            this.lblkategoriıd.Text = "0";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(37, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(556, 237);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Frmcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 728);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Frmcategory";
            this.Text = "Frmcategory";
            this.Load += new System.EventHandler(this.Frmcategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncategorySil;
        private System.Windows.Forms.Button btncategoryguncelle;
        private System.Windows.Forms.Button btncategoryEkle;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkategoriıd;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}