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
    public partial class Frm_main : Form
    {
        public string ConnectionString { private get; set; }
        public Frm_main()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = nyelviskola;";
            InitializeComponent();
        }
        private void FillDGV()
        {
            dgv.Rows.Clear();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                var r = new SqlCommand(
                    "SELECT nyelvek.id, jelentkezesek.nev, nyelvek.nyelv, vizsgak.szint " +
                    "FROM nyelvek, vizsgak, jelentkezesek " +
                    "WHERE nyelvek.id = vizsgak.nyelvid AND vizsgak.sorsz = jelentkezesek.vizsga;", c).ExecuteReader();

                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }
            }
        }
            private void menu_ujvizsga_Click(object sender, EventArgs e)
        => new Frm_vizsgazo().ShowDialog();

        private void menu_vizsga_Click(object sender, EventArgs e)
        => new Frm_Kereso().ShowDialog();

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            FillDGV();
        }
    }
}
