using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbConnect
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        static string ConnectionString =
       @"Server=127.0.0.1,1433;Database=psh;User Id=sa;Password=std001;TrustServerCertificate=True";

        SqlConnection Conn = new SqlConnection(ConnectionString);

        private void ListView_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                listView1.Items.Clear();

                SqlCommand cmd = new SqlCommand("select 수험번호, 성명, 부서 from exam", Conn);
                SqlDataReader Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {
                    ListViewItem item;
                    item = new ListViewItem(Dr.GetValue(0).ToString());
                    item.SubItems.Add(Dr.GetValue(1).ToString());
                    item.SubItems.Add(Dr.GetValue(2).ToString());
                    listView1.Items.Add(item);
                }
                Dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("예외발생 : " + ex.Message);
            }
            finally
            {
                Conn?.Close();
            }
        }
    }
}
