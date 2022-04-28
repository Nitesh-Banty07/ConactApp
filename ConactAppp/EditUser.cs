using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConactAppp
{
    public partial class EditUser : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public EditUser()
        {
            InitializeComponent();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand comnd = new SqlCommand("SP_UpdateUser", con))
                    {
                        comnd.CommandType = CommandType.StoredProcedure;
                        SqlParameter user_name = comnd.Parameters.Add("@name", SqlDbType.VarChar);
                        user_name.Value = txtName.Text;
                        SqlParameter user_mobile = comnd.Parameters.Add("@mobileNom", SqlDbType.VarChar);
                        user_mobile.Value = txtMobileNomber.Text;
                        SqlParameter user_Address = comnd.Parameters.Add("@Address", SqlDbType.VarChar);
                        user_Address.Value = txtAdress.Text;
                        comnd.ExecuteNonQuery();
                        MessageBox.Show("updated data ");
                        ConactApp app = new ConactApp();
                        app.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
