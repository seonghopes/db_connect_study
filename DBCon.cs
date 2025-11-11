using Microsoft.Data.SqlClient;


namespace dbConnect
{
    public partial class DBCon : Form
    {
        public DBCon()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.ConnectionString =
                //@"Server=PC100\SQLEXPRESS;database=psh;uid=sa;pwd=std001;";
                //@"Server=PC100\SQLEXPRESS;Database=psh;User Id=sa;Password=std001;Encrypt=False;"; ;
                @"Server=PC100\SQLEXPRESS;Database=psh;User Id=sa;Password=std001;TrustServerCertificate=True"; 


                Conn.Open();
                MessageBox.Show("연결성공");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"예외발생");
            }
            finally
            {
                if(Conn != null)
                {
                    Conn.Close();
                }
            }
        }
    }
}
