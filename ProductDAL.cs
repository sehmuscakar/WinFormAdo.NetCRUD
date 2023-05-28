using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Ado.NetGiriş
{
    public class ProductDAL
    {
     public    SqlConnection _connetion = new SqlConnection(@"server=DESKTOP-PBFD0LU;  initial catalog=StokTakipSistemi;Integrated Security=True");//initial catalog veritabanı ismi,Intergrated Security=True buda kendi local server i kullandığı için gövenli bağlantı anlamında windows authentication yani kendi localini kullan
     public   void ConnectionKontrol()
        {
            if (_connetion.State == ConnectionState.Closed)//bağlantı kapalıysa aç anlamında 
            {
                _connetion.Open();
            }

        }

        public void Add(Product product)
        {
            try
            {
                ConnectionKontrol();
                SqlCommand komut = new SqlCommand("insert into Urunler values ( @UrunAdi,@UrunFiyatı,@StokMiktarı)", _connetion);
                komut.Parameters.AddWithValue("@UrunAdi", product.Name);
                komut.Parameters.AddWithValue("@UrunFiyatı", product.Price);
                komut.Parameters.AddWithValue("StokMiktarı", product.StockAmount);
                komut.ExecuteNonQuery();
            }
            catch (Exception error)
            {

              //burası error. veritabanına kaydedebiliriz
            }

            finally
            {
                //burası son durak
                _connetion.Close();
            }
          

        }


        //public List<Product> GetAll()
        //{
        //    List<Product> products = new List<Product>();
        //    ConnectionKontrol();
        //    SqlCommand komut2 = new SqlCommand("select * from Urunler", _connetion);
        //    SqlDataReader oku = komut2.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        Product product = new Product
        //        {
        //            Id = Convert.ToInt32(oku["ıd"]),
        //            Name = oku["UrunAdı"].ToString(),
        //            StockAmount = Convert.ToInt32(oku["StokMiktarı"]),
        //            Price = Convert.ToDecimal(oku["UrunFiyatı"]),
        //        };
        //        products.Add(product);
        //    }
        //    _connetion.Close();
        //    return products;
        //}//liste ile veri listeleme

        public DataTable GetTable()//date-table ile verileri listeleme
        {
            ConnectionKontrol();
            SqlCommand komut2 = new SqlCommand("select * from Urunler", _connetion);
            SqlDataReader oku = komut2.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(oku);
            _connetion.Close();

            return table;
        }


        public void Update(Product product)
        {
            ConnectionKontrol();
            SqlCommand komut = new SqlCommand("Update Urunler set UrunAdı=@p1,UrunFiyatı=@p2,StokMiktarı=@p3 where ıd=@ID", _connetion);
            komut.Parameters.AddWithValue("@P1", product.Name);
            komut.Parameters.AddWithValue("@P2", product.Price);
            komut.Parameters.AddWithValue("@P3", product.StockAmount);
            komut.Parameters.AddWithValue("@ID", product.Id);
            komut.ExecuteNonQuery();
            _connetion.Close();
        }

        public void Delete(int id)
        {
            ConnectionKontrol();
            SqlCommand komut = new SqlCommand("delete from Urunler where ID=@ıd", _connetion);
            komut.Parameters.AddWithValue("@ıd", id);
            komut.ExecuteNonQuery();
            _connetion.Close();
        }



    }
}
