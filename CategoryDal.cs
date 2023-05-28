using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NetGiriş
{//date table ile verileri çağırdık ve kalan crud işlmelerini date table listesini kullanarak yaptık
 //
    public class CategoryDal
    {
        ProductDAL _product = new ProductDAL();//direk product taki bağlantı adreslerinin  üzerinden connetion sağlamyı yaptık 
     
        public DataTable GetTable()//date-table ile verileri listeleme
        {
            _product.ConnectionKontrol();
            SqlCommand komut2 = new SqlCommand("select * from kategori", _product._connetion);
            SqlDataReader oku = komut2.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(oku);
            _product._connetion.Close();
            return table;
        }

        public void CategoryAdd(Category category)
        {
            _product.ConnectionKontrol();
        
            SqlCommand komut = new SqlCommand("insert into kategori(KategoriAdı) values (@p1)",_product._connetion);
            komut.Parameters.AddWithValue("@p1", category.name);
            komut.ExecuteNonQuery();
           _product._connetion.Close();     
        }


        public void UpdateCategory(Category entity)
        {
            _product.ConnectionKontrol();
            SqlCommand komut = new SqlCommand("Update kategori set KategoriAdı=@p1 where ıd=@ID", _product._connetion);
            komut.Parameters.AddWithValue("@P1", entity.name);
          
            komut.Parameters.AddWithValue("@ID", entity.ıd);
            komut.ExecuteNonQuery();
            _product._connetion.Close();
        }

        public void CategoryDelete(int id)
        {
            _product.ConnectionKontrol();
            SqlCommand komut = new SqlCommand("delete from kategori where ID=@ıd", _product._connetion);
            komut.Parameters.AddWithValue("@ıd", id);
            komut.ExecuteNonQuery();
            _product._connetion.Close();
        }
    }
}
