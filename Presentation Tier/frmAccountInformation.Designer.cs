namespace Massenger
{
    partial class frmAccountInformation
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
            this.ctrlPersonInfo1 = new Massenger.ctrlPersonInfo();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(884, 225);
            this.ctrlPersonInfo1.TabIndex = 0;
            this.ctrlPersonInfo1.OnClose += new System.Action(this.ctrlPersonInfo1_OnClose);
            this.ctrlPersonInfo1.OnEditInformation += new System.Action<BusinesseTier.clsBusniesePerson>(this.ctrlPersonInfo1_OnEditInformation);
            this.ctrlPersonInfo1.Load += new System.EventHandler(this.ctrlPersonInfo1_Load);
            // 
            // frmAccountInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 245);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Name = "frmAccountInformation";
            this.Text = "frmAccountInformation";
            this.Load += new System.EventHandler(this.frmAccountInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
    }
}