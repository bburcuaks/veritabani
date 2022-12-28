using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magazaOtomasyonu
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;DataBase=MagazaOtomasyonu;user ID=postgres;password=burcu1627");
        private void BtnList_Click(object sender, EventArgs e)
        {

            string sorgu = "select *from urun";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            if (TxtUrnID.Text == "" || TxtUrnAd.Text == "" || TxtPersonel.Text == "" || TxtMagaza.Text == "" || comboBoxKateg.Text == "" || TxtBrmFyt.Text == "" || numericUpDown1.Text == "")
            {
                MessageBox.Show("EKLEME BAŞARISIZ LÜTFEN BÜTÜN BOŞLUKLARI DOLDURUNUZ");

            }
            


            else

            {

                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into urun(urun_id,urun_ad,personel,magaza,kategori,birim_fiyat,stok_miktar) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7) ", baglanti);
                komut.Parameters.AddWithValue("@p1", int.Parse(TxtUrnID.Text));
                komut.Parameters.AddWithValue("@p2", TxtUrnAd.Text);
                komut.Parameters.AddWithValue("@p3", int.Parse(TxtPersonel.Text));
                komut.Parameters.AddWithValue("@p4", int.Parse(TxtMagaza.Text));
                komut.Parameters.AddWithValue("@p6", int.Parse(numericUpDown1.Value.ToString()));
                komut.Parameters.AddWithValue("@p7", int.Parse(TxtBrmFyt.Text));
                komut.Parameters.AddWithValue("@p5", int.Parse(comboBoxKateg.SelectedValue.ToString()));

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün ekleme işlemi  başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);






            }


        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select *from kategori", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxKateg.DisplayMember = "kategori_ad"; // ön tarafta
            comboBoxKateg.ValueMember = "kategori_id"; // arka tarafta
            comboBoxKateg.DataSource = dt;
            baglanti.Close();





        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from urun where urun_id=@p1",baglanti );
            komut2.Parameters.AddWithValue("@p1",int.Parse(TxtUrnID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silme işlemi başarılı bir şekilde gerçekleşti.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            

        }

        private void BtnGuncel_Click(object sender, EventArgs e)
        {



            
            
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("update urun set urun_ad=@p1,personel=@p2,magaza=@p3,kategori=@p4,birim_fiyat=@p5,stok_miktar=@p6 where urun_id=@p7", baglanti);
                komut3.Parameters.AddWithValue("@p1", TxtUrnAd.Text);
                komut3.Parameters.AddWithValue("@p2", int.Parse(TxtPersonel.Text));
                komut3.Parameters.AddWithValue("p3", int.Parse(TxtMagaza.Text));
                komut3.Parameters.AddWithValue("@p4", int.Parse(comboBoxKateg.SelectedValue.ToString()));
                komut3.Parameters.AddWithValue("@p5", int.Parse(TxtBrmFyt.Text));
                komut3.Parameters.AddWithValue("@p6", int.Parse(numericUpDown1.Value.ToString()));
                komut3.Parameters.AddWithValue("@p7", int.Parse(TxtUrnID.Text));
                komut3.ExecuteNonQuery();
                MessageBox.Show("Ürün güncelleme işlemi başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                baglanti.Close();
            


        }

       private void BtnAra_Click(object sender, EventArgs e)
       {

           
             baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select *from urun where urun_ad  like '%" +TxtUrnAd.Text+"%'",baglanti);
            NpgsqlDataAdapter da=new NpgsqlDataAdapter(komut4);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
            baglanti.Close();


             


          

        }

        private void BtnSilinenUrun_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select*from silinen_urun order by urun_id_s",baglanti);
            NpgsqlDataAdapter  da=new NpgsqlDataAdapter(komut5);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();





        }

       
    }
}
