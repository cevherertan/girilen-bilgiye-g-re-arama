using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class baglanti
    {
        public static SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-0HLJ5NJ\SQLEXPRESS;Initial Catalog=ogr_isleri;Integrated Security=True");
        public static void ac()
        {
            baglan.Open();
        }
        public static void kapat()
        {
            baglan.Close();
        }
    }
}
