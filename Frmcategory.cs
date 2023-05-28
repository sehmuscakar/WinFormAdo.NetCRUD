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
    public partial class Frmcategory : Form
    {
        public Frmcategory()
        {
            InitializeComponent();
        }
        CategoryDal _categoryDal = new CategoryDal();
        private void Frmcategory_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = _categoryDal.GetTable();
        }

        void Categoryveriyukle()
        {
            dataGridView2.DataSource=_categoryDal.GetTable();
        }


        private void btncategoryEkle_Click(object sender, EventArgs e)
        {
            //buda yontem

            _categoryDal.CategoryAdd(new Category
            {
                name = txtcategory.Text,

            });
            Categoryveriyukle();
                

            //buda yontem 

           // Category category = new Category
           // {
           //     name=txtcategory.Text,
           // };
           //_categoryDal.CategoryAdd(category);
            MessageBox.Show("Kayıt eklendi");
        }

        private void btncategoryguncelle_Click(object sender, EventArgs e)
        {
            _categoryDal.UpdateCategory(new Category

            {

                ıd = Convert.ToInt32(lblkategoriıd.Text),
                name=txtcategory.Text,

            });
            Categoryveriyukle();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblkategoriıd.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtcategory.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void btncategorySil_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(lblkategoriıd.Text);
            _categoryDal.CategoryDelete(deger);
            MessageBox.Show("Kayıt silidi");
            Categoryveriyukle();
        }
    }
}
