using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConactAppp
{
    public partial class AddUser : Form
    {
        ConactApp app = new ConactApp();
        public AddUser()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand comnd = new SqlCommand("SP_AddUsers", con);
                comnd.CommandType = CommandType.StoredProcedure;
                SqlParameter user_name = comnd.Parameters.Add("@name", SqlDbType.VarChar);
                user_name.Value = txtName.Text;
                SqlParameter user_mobile = comnd.Parameters.Add("@mobileNom", SqlDbType.VarChar);
                user_mobile.Value = txtMobileNomber.Text;
                SqlParameter user_Address = comnd.Parameters.Add("@Address", SqlDbType.VarChar);
                user_Address.Value = txtAdress.Text;
                comnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add user SuccesFully");
                app.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {     
                this.Close();
            }
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    e.Cancel = true;
                    txtName.Focus();
                    errorProvider1.SetError(txtName, "Name should not be left blank!");
                    BtnSave.Visible = false;
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtName, "");
                    BtnSave.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    MessageBox.Show(txtName.Text, "Demo App - Message!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtMobileNomber_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMobileNomber.Text))
                {
                    e.Cancel = true;
                    txtMobileNomber.Focus();
                    errorProvider1.SetError(txtName, "Name should not be left blank!");
                    BtnSave.Visible = false;
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtMobileNomber, "");
                    BtnSave.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
