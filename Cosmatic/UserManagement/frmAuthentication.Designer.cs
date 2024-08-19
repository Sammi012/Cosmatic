namespace Cosmatic.UserManagement
{
    partial class Authentication
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usrActionBar1 = new Cosmatic.UserControls.usrActionBar();
            this.SuspendLayout();
            // 
            // usrActionBar1
            // 
            this.usrActionBar1.Location = new System.Drawing.Point(76, 53);
            this.usrActionBar1.Name = "usrActionBar1";
            this.usrActionBar1.Size = new System.Drawing.Size(8, 8);
            this.usrActionBar1.TabIndex = 0;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usrActionBar1);
            this.Name = "Authentication";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.usrActionBar usrActionBar1;
    }
}
