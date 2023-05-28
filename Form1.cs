using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.NetGiriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDAL _productDAL=new ProductDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
            //   dataGridView1.DataSource = _productDAL.GetAll();//list ile veri listeleme
            dataGridView1.DataSource = _productDAL.GetTable();//get table ile veri listeleme
        
        
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _productDAL.Add(new Product
                {
                    Name = txturun.Text,
                    Price = Convert.ToDecimal(txtfiyat.Text),
                    StockAmount = Convert.ToInt16(txtstok.Text),
                });
                //     dataGridView1.DataSource = _productDAL.GetAll();
                MessageBox.Show("Ürün Eklendi");
            }
            catch (Exception)//hatayı buranın içine atıyoruz 
            {
                MessageBox.Show("Hata oluştu");
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {

                _productDAL.Update(new Product
                {
                    Id = Convert.ToInt32(lblıd.Text),
                    Name = txturun.Text,
                    Price = Convert.ToDecimal(txtfiyat.Text),
                    StockAmount = Convert.ToInt16(txtstok.Text),
                });
                //     dataGridView1.DataSource = _productDAL.GetAll();
                MessageBox.Show("Ürün Güncellendi");
            }
            catch (Exception hata)//buyle hatanın kendisinide mesaj veya başka şekilde döndürebilirisn
            {

                MessageBox.Show("Hata Oluştu!"+hata.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txturun.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
       txtfiyat.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
       txtstok.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK);
            {
                _productDAL.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
              //  dataGridView1.DataSource = _productDAL.GetAll();
                MessageBox.Show("Ürün Silindi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmcategory fr = new Frmcategory();
            fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
