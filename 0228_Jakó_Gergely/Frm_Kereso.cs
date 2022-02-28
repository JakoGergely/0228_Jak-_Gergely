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
    public partial class Frm_Kereso : Form
    {
        public string ConnectionString { private get; set; }
        public Frm_Kereso()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = nyelviskola;";
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT nyelv " +
                    "FROM nyelvek " +
                    "Group by nyelv;", c)
                    .ExecuteReader();
                while (r.Read()) cb_nyelv.Items.Add(r);
                c.Close();
            }
        }

        private void Frm_Kereso_Load(object sender, EventArgs e)
        {
            dgv.Rows.Clear();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                var r = new SqlCommand(
                    "SELECT nyelvek.id, jelentkezesek.nev, nyelvek.nyelv, vizsgak.szint " +
                    "FROM nyelvek, vizsgak, jelentkezesek " +
                    "WHERE nyelvek.id = vizsgak.nyelvid AND vizsgak.sorsz = jelentkezesek.vizsga " +
                    "AND nyelvek.nyelv LIKE '"cb_nyelv.Text"';", c).ExecuteReader();

                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }
            }
        }
    }
}
