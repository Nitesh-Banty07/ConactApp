using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConactAppp
{
    public partial class ConactApp : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public ConactApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                GetUsers();
                this.Refresh();
                this.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser Au = new AddUser();
                Au.ShowDialog();
                this.GetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public void GetUsers()
        {
            try
            {   
                using (SqlConnection con = new SqlConnection(conString))
                {   
                    using (SqlCommand comnd = new SqlCommand("SP_Users", con))
                    {
                        comnd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter sd = new SqlDataAdapter(comnd);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dgvUsers.DataSource = dt;
                        dgvUsers.Refresh();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                GetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditUser Eu = new EditUser();
                Eu.txtName.Text = this.dgvUsers.CurrentRow.Cells[0].Value.ToString();
                Eu.txtMobileNomber.Text = this.dgvUsers.CurrentRow.Cells[1].Value.ToString();
                Eu.txtAdress.Text = this.dgvUsers.CurrentRow.Cells[2].Value.ToString();
                Eu.ShowDialog();
                GetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EditUser Eu = new EditUser();
                Eu.txtName.Text = this.dgvUsers.CurrentRow.Cells[0].Value.ToString();
                Eu.txtMobileNomber.Text = this.dgvUsers.CurrentRow.Cells[1].Value.ToString();
                Eu.txtAdress.Text = this.dgvUsers.CurrentRow.Cells[2].Value.ToString();
                Eu.ShowDialog();
                GetUsers();
                this.dgvUsers.Sort(this.dgvUsers.Columns["Name"], ListSortDirection.Ascending);
                this.dgvUsers.Sort(this.dgvUsers.Columns["mobile_nom"],ListSortDirection.Ascending);
                this.dgvUsers.Sort(this.dgvUsers.Columns["user_Address"], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search Su = new Search();
            Su.PassDataEvent += Su_PassDataEvent;
            Su.ShowDialog();
        }

        private void Su_PassDataEvent(object sender, Search.PassDataEventArgs e)
        {
            try
            {
                
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand comnd = new SqlCommand("SP_SearchUser", con))
                    {
                        comnd.CommandType = CommandType.StoredProcedure;
                        SqlParameter name = comnd.Parameters.Add("@name", SqlDbType.VarChar);
                        name.Value =e.Name;
                        SqlParameter address = comnd.Parameters.Add("@address", SqlDbType.VarChar);
                        address.Value = e.Address;
                        SqlDataAdapter sd = new SqlDataAdapter(comnd);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dgvUsers.DataSource = dt;
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand comnd = new SqlCommand("SP_DeleteUser", con);
                comnd.CommandType = CommandType.StoredProcedure;
                SqlParameter this_user = comnd.Parameters.Add("@name", SqlDbType.VarChar);
                this_user.Value = this.dgvUsers.CurrentRow.Cells[0].Value;
                comnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" succesfully delete user ");
                GetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 
    }
}
