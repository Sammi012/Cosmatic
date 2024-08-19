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

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
                    this.toolStrip.Visible = true;
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

        

        private void editMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void databaseToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
       

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Transactions uc = new UC_Transactions();
            this.DialogResult = DialogResult.OK;
           // MessageBox.Show(UC_Transactions);

        }

       
        private void dashboardMenu_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserRegistration();
        }

        private void ShowUserRegistration()
        {
            CloseAllChild();

            //frmAuthentication frmAuthentication = new frmAuthentication();
            //frmAuthentication.MdiParent = this;
            //frmAuthentication.WindowState = FormWindowState.Maximized;
            //frmAuthentication.Show();
        }

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNumbersoforders_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
