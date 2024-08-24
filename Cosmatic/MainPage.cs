using Cosmatic.Dashboard;
using Cosmatic.UserControls;
using Cosmatic.UserManagement;
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
    public partial class MainPage : Form
    {
        private int childFormNumber = 0;

        public MainPage()
        {
            InitializeComponent();
           
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

      



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChild();

            
        }
        void CloseAllChild()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Text = "Developed By Insert Solutions";
            using (var loginForm = new frmLogin())
            {
                // Show the login form as a modal dialog
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If login is unsuccessful, close the MDI form
                    this.menuStrip.Visible = true;
                    this.shortCutToolMenu.Visible = true;
                    this.statusStrip.Visible = true;
                    this.toolUserName.Text = loginForm.UserName;
                      ShowDashboard();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void ShowDashboard()
        {
            CloseAllChild();

            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.MdiParent = this;
            frmDashboard.WindowState = FormWindowState.Maximized;
            frmDashboard.Show();
        }

        


       


       
        private void dashboardMenu_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

       


        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
