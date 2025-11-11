using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbConnect
{
    public partial class ExcuteScalar : Form
    {
        public ExcuteScalar()
        {
            InitializeComponent();
        }


        //static string ConnectionString =
        //    @"Server=PC100\SQLEXPRESS;Database=psh;User Id=sa;Password=std001;TrustServerCertificate=True";

        static string ConnectionString =
          @"Server=127.0.0.1,1433;Database=psh;User Id=sa;Password=std001;TrustServerCertificate=True";

        SqlConnection Conn = new SqlConnection(ConnectionString);

        private void ExcuteScalar_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();

                string StrSQL = "select 성명 from exam_emp where 수험번호=@txt_no";
                SqlCommand Cmd = new SqlCommand(StrSQL, Conn);
                Cmd.CommandType = CommandType.Text;

                SqlParameter p1 = new SqlParameter(@"txt_no", SqlDbType.Int);
                p1.Value = Int32.Parse(tbTxt_NO.Text);

                Cmd.Parameters.Add(p1);

                object scalarValue = Cmd.ExecuteScalar();
                MessageBox.Show("성명 : " + scalarValue);

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

        private void btbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
