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

namespace _0228_Jakó_Gergely
{
 
    public partial class Frm_vizsgazo : Form
    {
        public string ConnectionString { private get; set; }
        public Frm_vizsgazo()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = nyelviskola;";
            InitializeComponent();
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                new SqlCommand(
                    "INSERT INTO jelentkezesek VALUES " +
                    $"({ tb_id.Text }, " +
                    $"({ tb_nev.Text }, " +
                    $"({tb_telef.Text}, " +
                    $"({tb_szul.Text};", conn).ExecuteNonQuery();

            }
            this.Dispose();
        }

        private void Frm_vizsgazo_Load(object sender, EventArgs e)
        {

        }
    }
}

                    
