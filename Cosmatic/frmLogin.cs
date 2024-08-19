using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmatic
{
    public partial class frmLogin : Form
    {
        public string UserName { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            this.UserName = txtUsername.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
           
                
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (ShowPassword.Checked)
            //    txtPassword.UseSystemPasswordChar = false;
            //else
            //    txtPassword.UseSystemPasswordChar = true;

            //txtPassword.UseSystemPasswordChar = ShowPassword.Checked ? false : true;

            txtPassword.UseSystemPasswordChar = !ShowPassword.Checked;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {

            // this.DialogResult = DialogResult.Cancel;
           // MessageBox.Show("Exit");
            Application.Exit();
        }
    }
}
