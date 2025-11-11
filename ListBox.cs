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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        static string ConnectionString =
         @"Server=127.0.0.1,1433;Database=psh;User Id=sa;Password=std001;TrustServerCertificate=True";

        SqlConnection Conn = new SqlConnection(ConnectionString);

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                Conn.Open();
                SqlCommand Cmd = new SqlCommand("select * from exam", Conn);

                SqlDataReader Dr;
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    string Rec = string.Format(
                        "부서 : {0}, 성명={1}, 학력={2}, 영어={3}, 수학={4}, 전형구분={5}, 수험번호={6}",
                        Dr["부서"], Dr["성명"], Dr["학력"], Dr["영어"], Dr["수학"], Dr["전형구분"], Dr["수험번호"]
                        );

                    listBox1.Items.Add(Rec);
                }

                Dr.Close();

            }
            catch (Exception ex)
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
