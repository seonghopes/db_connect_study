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
    public partial class ExecuteNonQuery : Form
    {
        public ExecuteNonQuery()
        {
            InitializeComponent();
        }

        static string ConnectionString =
          @"Server=127.0.0.1,1433;Database=psh;User Id=sa;Password=std001;TrustServerCertificate=True";


        // 오버로딩
        private void ExecuteSP(string SPName)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();
                SqlCommand Cmd = new SqlCommand(SPName, conn);
                Cmd.CommandType = CommandType.StoredProcedure;

                int RowEffect = Cmd.ExecuteNonQuery();
                MessageBox.Show("결과 : " + RowEffect.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외발생 : " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }

        // 오버로딩
        private void ExecuteSP(string SPName, int Id, String Name)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();
                SqlCommand Cmd = new SqlCommand(SPName, conn);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pInput1 = new SqlParameter("@id", SqlDbType.Int);
                pInput1.Direction = ParameterDirection.Input;
                pInput1.Value = Id;
                Cmd.Parameters.Add(pInput1);

                SqlParameter pInput2 = new SqlParameter("@Name", SqlDbType.VarChar);
                pInput2.Direction = ParameterDirection.Input;
                pInput2.Value = Name;
                Cmd.Parameters.Add(pInput2);

                int RowEffect = Cmd.ExecuteNonQuery();
                MessageBox.Show("결과 : " + RowEffect.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외발생 : " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ExecuteSP("CreateTable");
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            ExecuteSP("CreateTable2", Int32.Parse(tbId.Text), tbName.Text);
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            ExecuteSP("DropTable");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
