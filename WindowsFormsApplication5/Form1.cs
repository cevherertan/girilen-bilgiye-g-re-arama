using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void listele()
        {
            baglanti.ac();
            SqlCommand komut = new SqlCommand("select ogrenci.ONo,ogrenci.OAdi,Ogrenci.OSoyadi,Bolum.BAdi,Ders.DAdi,Puan.Vize*0.4+Puan.Final*0.6 as Ortalama From Ogrenci inner join Puan on Puan.Ono=Ogrenci.Ono inner join Ders on Ders.Dno=Puan.Dno inner join Bolum on Bolum.Bno=Ders.Bno Where Ogrenci.oAdi like @a or Ogrenci.OSoyadi like @a or Bolum.Badi like @a or Ders.Dadi like @a or Ogrenci.ONo like @a",baglanti.baglan);
            komut.Parameters.AddWithValue("@a","%"+textBox1.Text+"%");
            DataTable liste = new DataTable();
            liste.Load(komut.ExecuteReader());
            dataGridView1.DataSource = liste;
            baglanti.kapat();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listele();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
