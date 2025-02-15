namespace Massenger
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.maskPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblTitlePinCode = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.picAddPerson = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pAddNewAccount = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.timeTitle = new System.Windows.Forms.Timer(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPerson)).BeginInit();
            this.pAddNewAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Phone : ";
            // 
            // maskPhone
            // 
            this.maskPhone.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskPhone.Location = new System.Drawing.Point(228, 166);
            this.maskPhone.Mask = "0000000000";
            this.maskPhone.Name = "maskPhone";
            this.maskPhone.Size = new System.Drawing.Size(137, 32);
            this.maskPhone.TabIndex = 14;
            this.maskPhone.ValidatingType = typeof(int);
            this.maskPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskPhone_MaskInputRejected);
            // 
            // lblTitlePinCode
            // 
            this.lblTitlePinCode.AutoSize = true;
            this.lblTitlePinCode.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePinCode.Location = new System.Drawing.Point(62, 296);
            this.lblTitlePinCode.Name = "lblTitlePinCode";
            this.lblTitlePinCode.Size = new System.Drawing.Size(167, 27);
            this.lblTitlePinCode.TabIndex = 15;
            this.lblTitlePinCode.Text = "Enter PinCode : ";
            this.lblTitlePinCode.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(173, 342);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(102, 27);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "0 Second";
            this.lblTimer.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.btnAccept.Location = new System.Drawing.Point(149, 215);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(117, 38);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.btnLogin.Location = new System.Drawing.Point(158, 372);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 38);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Enter += new System.EventHandler(this.btnLogin_Enter);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.txtPinCode.Location = new System.Drawing.Point(228, 296);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(100, 32);
            this.txtPinCode.TabIndex = 21;
            this.txtPinCode.Visible = false;
            this.txtPinCode.TextChanged += new System.EventHandler(this.txtPinCode_TextChanged);
            // 
            // picAddPerson
            // 
            this.picAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("picAddPerson.Image")));
            this.picAddPerson.Location = new System.Drawing.Point(67, 3);
            this.picAddPerson.Name = "picAddPerson";
            this.picAddPerson.Size = new System.Drawing.Size(44, 38);
            this.picAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddPerson.TabIndex = 22;
            this.picAddPerson.TabStop = false;
            this.picAddPerson.Click += new System.EventHandler(this.picAddPerson_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Add New Account";
            // 
            // pAddNewAccount
            // 
            this.pAddNewAccount.Controls.Add(this.picAddPerson);
            this.pAddNewAccount.Controls.Add(this.label2);
            this.pAddNewAccount.Location = new System.Drawing.Point(118, 68);
            this.pAddNewAccount.Name = "pAddNewAccount";
            this.pAddNewAccount.Size = new System.Drawing.Size(168, 80);
            this.pAddNewAccount.TabIndex = 24;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(111, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 37);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "Me";
            // 
            // timeTitle
            // 
            this.timeTitle.Interval = 1000;
            this.timeTitle.Tick += new System.EventHandler(this.timeTitle_Tick);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(159, 9);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 40);
            this.lbl2.TabIndex = 27;
            this.lbl2.Text = "ss";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(195, 9);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(69, 40);
            this.lbl3.TabIndex = 28;
            this.lbl3.Text = "eng";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(257, 9);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(46, 40);
            this.lbl4.TabIndex = 29;
            this.lbl4.Text = "er";
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(23, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(71, 75);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 30;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(319, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(71, 75);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 31;
            this.pic2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pAddNewAccount);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTitlePinCode);
            this.Controls.Add(this.maskPhone);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAddPerson)).EndInit();
            this.pAddNewAccount.ResumeLayout(false);
            this.pAddNewAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskPhone;
        private System.Windows.Forms.Label lblTitlePinCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.PictureBox picAddPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pAddNewAccount;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer timeTitle;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
    }
}