using System;
using System.Configuration;
using System.Windows.Forms;

namespace ConactAppp
{
    public partial class Search : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public event PassDataEventHadler PassDataEvent;
        public delegate void PassDataEventHadler(object sender, PassDataEventArgs e);
        public Search()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                PassDataEvent(this, new PassDataEventArgs(
                txtName.Text,txtAdress.Text));
                
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
        public class PassDataEventArgs : EventArgs
        {
            public string Name;
            public string Address;

            public PassDataEventArgs(string _name, string _address)
            {
                try
                {
                    if (_name == "" & _address == "")
                    {
                        Name = null;
                        Address = null;
                    }
                    if (_name == "")
                    {
                        Name = null;
                        Address = _address;
                    }
                    if (_address == "")
                    {
                        Name = _name;
                        Address = null;
                    }
                    if (_name != "" & _address != "")
                    {
                        Name = _name;
                        Address =_address;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

       
    }
}
