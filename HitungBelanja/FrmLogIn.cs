using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace HitungBelanja
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        string sqlString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HitungBelanja; Integrated Security = True;";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dao = new AkunDAO(sqlString))
                {
                    Akun temp = dao.GetDataCustomerByUsername(txtUsername.Text);
                    
                    if (temp.Password.Equals(txtPassword.Text))
                    {
                        FrmTampilBarang frm = new FrmTampilBarang(temp);
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception )
            {
                this.lblAccountError.Visible = true;
                this.txtUsername.Text = "";
                this.txtPassword.Text = "";
                this.txtUsername.Focus();
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";
            this.lblAccountError.Visible = false;
            this.txtUsername.Focus();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
