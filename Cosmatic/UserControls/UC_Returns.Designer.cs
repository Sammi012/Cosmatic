namespace Cosmatic.UserControls
{
    partial class UC_Returns
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReturns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReturns
            // 
            this.lblReturns.AutoSize = true;
            this.lblReturns.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturns.Location = new System.Drawing.Point(245, 115);
            this.lblReturns.Name = "lblReturns";
            this.lblReturns.Size = new System.Drawing.Size(89, 25);
            this.lblReturns.TabIndex = 0;
            this.lblReturns.Text = "Returns";
            // 
            // UC_Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReturns);
            this.Name = "UC_Returns";
            this.Text = "UC_Returns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturns;
    }
}