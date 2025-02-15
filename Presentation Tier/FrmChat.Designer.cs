namespace Massenger
{
    partial class FrmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChat));
            this.txtTextMessage = new System.Windows.Forms.TextBox();
            this.picSendMessage = new System.Windows.Forms.PictureBox();
            this.cmsMessage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pMessage = new System.Windows.Forms.Panel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSenderInfo = new System.Windows.Forms.Label();
            this.lblReciverInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitlePanelMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pImagesIron = new System.Windows.Forms.Panel();
            this.pReciver = new System.Windows.Forms.Panel();
            this.picSendPhoto = new System.Windows.Forms.PictureBox();
            this.lblReciverName = new System.Windows.Forms.Label();
            this.lblTitleGradeView = new System.Windows.Forms.Label();
            this.pUpdateMessage = new System.Windows.Forms.Panel();
            this.btnUpdatePhoto = new System.Windows.Forms.Button();
            this.picCurrentPhoto = new System.Windows.Forms.PictureBox();
            this.btnUpdateMessage = new System.Windows.Forms.Button();
            this.txtNewMessage = new System.Windows.Forms.TextBox();
            this.lblSetNewMessge = new System.Windows.Forms.Label();
            this.lblCurrentMessage = new System.Windows.Forms.Label();
            this.lblTitlePanel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picPhoto2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSendMessage)).BeginInit();
            this.cmsMessage.SuspendLayout();
            this.pMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pImagesIron.SuspendLayout();
            this.pReciver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSendPhoto)).BeginInit();
            this.pUpdateMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTextMessage
            // 
            this.txtTextMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextMessage.Location = new System.Drawing.Point(67, 105);
            this.txtTextMessage.Multiline = true;
            this.txtTextMessage.Name = "txtTextMessage";
            this.txtTextMessage.ReadOnly = true;
            this.txtTextMessage.Size = new System.Drawing.Size(224, 44);
            this.txtTextMessage.TabIndex = 3;
            this.txtTextMessage.Tag = "?";
            this.txtTextMessage.Text = "Send Message";
            this.txtTextMessage.TextChanged += new System.EventHandler(this.txtTextMessage_TextChanged);
            this.txtTextMessage.MouseEnter += new System.EventHandler(this.txtTextMessage_MouseEnter);
            // 
            // picSendMessage
            // 
            this.picSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSendMessage.Image = ((System.Drawing.Image)(resources.GetObject("picSendMessage.Image")));
            this.picSendMessage.Location = new System.Drawing.Point(297, 105);
            this.picSendMessage.Name = "picSendMessage";
            this.picSendMessage.Size = new System.Drawing.Size(48, 44);
            this.picSendMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSendMessage.TabIndex = 8;
            this.picSendMessage.TabStop = false;
            this.picSendMessage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmsMessage
            // 
            this.cmsMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.cmsMessage.Name = "contextMenuStrip1";
            this.cmsMessage.Size = new System.Drawing.Size(113, 76);
            this.cmsMessage.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMessage_Opening);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.chatToolStripMenuItem.Text = "Replay";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F);
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "to : ";
            // 
            // pMessage
            // 
            this.pMessage.BackColor = System.Drawing.Color.Tan;
            this.pMessage.Controls.Add(this.picPhoto);
            this.pMessage.Controls.Add(this.lblTime);
            this.pMessage.Controls.Add(this.label7);
            this.pMessage.Controls.Add(this.lblMessage);
            this.pMessage.Controls.Add(this.label5);
            this.pMessage.Controls.Add(this.lblSenderInfo);
            this.pMessage.Controls.Add(this.lblReciverInfo);
            this.pMessage.Controls.Add(this.label4);
            this.pMessage.Controls.Add(this.label3);
            this.pMessage.Controls.Add(this.lblTitlePanelMessage);
            this.pMessage.Location = new System.Drawing.Point(44, 166);
            this.pMessage.Name = "pMessage";
            this.pMessage.Size = new System.Drawing.Size(278, 315);
            this.pMessage.TabIndex = 11;
            this.pMessage.Visible = false;
            // 
            // picPhoto
            // 
            this.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.Location = new System.Drawing.Point(120, 206);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(55, 44);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 15;
            this.picPhoto.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(152, 139);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 32);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "00 : 00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Time : ";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(3, 203);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(272, 70);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "message...\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Message : ";
            // 
            // lblSenderInfo
            // 
            this.lblSenderInfo.AutoSize = true;
            this.lblSenderInfo.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSenderInfo.Location = new System.Drawing.Point(160, 53);
            this.lblSenderInfo.Name = "lblSenderInfo";
            this.lblSenderInfo.Size = new System.Drawing.Size(88, 32);
            this.lblSenderInfo.TabIndex = 15;
            this.lblSenderInfo.Text = "Sender";
            // 
            // lblReciverInfo
            // 
            this.lblReciverInfo.AutoSize = true;
            this.lblReciverInfo.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReciverInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReciverInfo.Location = new System.Drawing.Point(152, 95);
            this.lblReciverInfo.Name = "lblReciverInfo";
            this.lblReciverInfo.Size = new System.Drawing.Size(96, 32);
            this.lblReciverInfo.TabIndex = 12;
            this.lblReciverInfo.Text = "Reciver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "to : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "From : ";
            // 
            // lblTitlePanelMessage
            // 
            this.lblTitlePanelMessage.AutoSize = true;
            this.lblTitlePanelMessage.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePanelMessage.Location = new System.Drawing.Point(23, 9);
            this.lblTitlePanelMessage.Name = "lblTitlePanelMessage";
            this.lblTitlePanelMessage.Size = new System.Drawing.Size(225, 36);
            this.lblTitlePanelMessage.TabIndex = 12;
            this.lblTitlePanelMessage.Text = "Message Info : ";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(1131, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 44);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.AllowUserToOrderColumns = true;
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.ContextMenuStrip = this.cmsMessage;
            this.dgvMessages.Location = new System.Drawing.Point(564, 65);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.Size = new System.Drawing.Size(593, 496);
            this.dgvMessages.TabIndex = 13;
            this.dgvMessages.DoubleClick += new System.EventHandler(this.dgvMessages_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Tan;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 134);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Tan;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 279);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Tan;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 419);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(121, 146);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pImagesIron
            // 
            this.pImagesIron.Controls.Add(this.pictureBox5);
            this.pImagesIron.Controls.Add(this.pictureBox2);
            this.pImagesIron.Controls.Add(this.pictureBox3);
            this.pImagesIron.Controls.Add(this.pictureBox4);
            this.pImagesIron.Location = new System.Drawing.Point(424, 2);
            this.pImagesIron.Name = "pImagesIron";
            this.pImagesIron.Size = new System.Drawing.Size(121, 568);
            this.pImagesIron.TabIndex = 18;
            // 
            // pReciver
            // 
            this.pReciver.Controls.Add(this.picSendPhoto);
            this.pReciver.Controls.Add(this.lblReciverName);
            this.pReciver.Controls.Add(this.label1);
            this.pReciver.Controls.Add(this.picSendMessage);
            this.pReciver.Controls.Add(this.txtTextMessage);
            this.pReciver.Controls.Add(this.pMessage);
            this.pReciver.Location = new System.Drawing.Point(33, 65);
            this.pReciver.Name = "pReciver";
            this.pReciver.Size = new System.Drawing.Size(348, 493);
            this.pReciver.TabIndex = 19;
            // 
            // picSendPhoto
            // 
            this.picSendPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSendPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picSendPhoto.Image")));
            this.picSendPhoto.Location = new System.Drawing.Point(6, 105);
            this.picSendPhoto.Name = "picSendPhoto";
            this.picSendPhoto.Size = new System.Drawing.Size(55, 44);
            this.picSendPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSendPhoto.TabIndex = 14;
            this.picSendPhoto.TabStop = false;
            this.picSendPhoto.Click += new System.EventHandler(this.picSendPhoto_Click);
            // 
            // lblReciverName
            // 
            this.lblReciverName.AutoSize = true;
            this.lblReciverName.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReciverName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReciverName.Location = new System.Drawing.Point(123, 26);
            this.lblReciverName.Name = "lblReciverName";
            this.lblReciverName.Size = new System.Drawing.Size(115, 39);
            this.lblReciverName.TabIndex = 13;
            this.lblReciverName.Text = "Reciver";
            // 
            // lblTitleGradeView
            // 
            this.lblTitleGradeView.AutoSize = true;
            this.lblTitleGradeView.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGradeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitleGradeView.Location = new System.Drawing.Point(808, 9);
            this.lblTitleGradeView.Name = "lblTitleGradeView";
            this.lblTitleGradeView.Size = new System.Drawing.Size(170, 42);
            this.lblTitleGradeView.TabIndex = 12;
            this.lblTitleGradeView.Text = "Messages";
            // 
            // pUpdateMessage
            // 
            this.pUpdateMessage.Controls.Add(this.btnUpdatePhoto);
            this.pUpdateMessage.Controls.Add(this.picCurrentPhoto);
            this.pUpdateMessage.Controls.Add(this.btnUpdateMessage);
            this.pUpdateMessage.Controls.Add(this.txtNewMessage);
            this.pUpdateMessage.Controls.Add(this.lblSetNewMessge);
            this.pUpdateMessage.Controls.Add(this.lblCurrentMessage);
            this.pUpdateMessage.Controls.Add(this.lblTitlePanel);
            this.pUpdateMessage.Location = new System.Drawing.Point(39, 576);
            this.pUpdateMessage.Name = "pUpdateMessage";
            this.pUpdateMessage.Size = new System.Drawing.Size(495, 165);
            this.pUpdateMessage.TabIndex = 20;
            this.pUpdateMessage.Visible = false;
            // 
            // btnUpdatePhoto
            // 
            this.btnUpdatePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePhoto.Location = new System.Drawing.Point(204, 82);
            this.btnUpdatePhoto.Name = "btnUpdatePhoto";
            this.btnUpdatePhoto.Size = new System.Drawing.Size(77, 31);
            this.btnUpdatePhoto.TabIndex = 22;
            this.btnUpdatePhoto.Text = "Change";
            this.btnUpdatePhoto.UseVisualStyleBackColor = true;
            this.btnUpdatePhoto.Visible = false;
            this.btnUpdatePhoto.Click += new System.EventHandler(this.btnUpdatePhoto_Click);
            // 
            // picCurrentPhoto
            // 
            this.picCurrentPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCurrentPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picCurrentPhoto.Image")));
            this.picCurrentPhoto.Location = new System.Drawing.Point(67, 53);
            this.picCurrentPhoto.Name = "picCurrentPhoto";
            this.picCurrentPhoto.Size = new System.Drawing.Size(107, 80);
            this.picCurrentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurrentPhoto.TabIndex = 21;
            this.picCurrentPhoto.TabStop = false;
            // 
            // btnUpdateMessage
            // 
            this.btnUpdateMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnUpdateMessage.Location = new System.Drawing.Point(376, 130);
            this.btnUpdateMessage.Name = "btnUpdateMessage";
            this.btnUpdateMessage.Size = new System.Drawing.Size(116, 32);
            this.btnUpdateMessage.TabIndex = 16;
            this.btnUpdateMessage.Text = "Update";
            this.btnUpdateMessage.UseVisualStyleBackColor = true;
            this.btnUpdateMessage.Click += new System.EventHandler(this.btnUpdateMessage_Click);
            // 
            // txtNewMessage
            // 
            this.txtNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNewMessage.Location = new System.Drawing.Point(204, 88);
            this.txtNewMessage.Multiline = true;
            this.txtNewMessage.Name = "txtNewMessage";
            this.txtNewMessage.ReadOnly = true;
            this.txtNewMessage.Size = new System.Drawing.Size(160, 36);
            this.txtNewMessage.TabIndex = 15;
            this.txtNewMessage.Tag = "?";
            this.txtNewMessage.Text = "New Message";
            this.txtNewMessage.TextChanged += new System.EventHandler(this.txtNewMessage_TextChanged);
            this.txtNewMessage.MouseEnter += new System.EventHandler(this.txtTextMessage_MouseEnter);
            // 
            // lblSetNewMessge
            // 
            this.lblSetNewMessge.AutoSize = true;
            this.lblSetNewMessge.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetNewMessge.Location = new System.Drawing.Point(3, 88);
            this.lblSetNewMessge.Name = "lblSetNewMessge";
            this.lblSetNewMessge.Size = new System.Drawing.Size(204, 25);
            this.lblSetNewMessge.TabIndex = 14;
            this.lblSetNewMessge.Text = "Set New Message : ";
            // 
            // lblCurrentMessage
            // 
            this.lblCurrentMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentMessage.Location = new System.Drawing.Point(196, 9);
            this.lblCurrentMessage.Name = "lblCurrentMessage";
            this.lblCurrentMessage.Size = new System.Drawing.Size(276, 76);
            this.lblCurrentMessage.TabIndex = 13;
            this.lblCurrentMessage.Text = "Current Message : ";
            // 
            // lblTitlePanel
            // 
            this.lblTitlePanel.AutoSize = true;
            this.lblTitlePanel.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePanel.Location = new System.Drawing.Point(9, 9);
            this.lblTitlePanel.Name = "lblTitlePanel";
            this.lblTitlePanel.Size = new System.Drawing.Size(181, 25);
            this.lblTitlePanel.TabIndex = 12;
            this.lblTitlePanel.Text = "Current Message : ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // picPhoto2
            // 
            this.picPhoto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhoto2.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto2.Image")));
            this.picPhoto2.Location = new System.Drawing.Point(564, 2);
            this.picPhoto2.Name = "picPhoto2";
            this.picPhoto2.Size = new System.Drawing.Size(81, 57);
            this.picPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto2.TabIndex = 15;
            this.picPhoto2.TabStop = false;
            this.picPhoto2.Visible = false;
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 753);
            this.Controls.Add(this.picPhoto2);
            this.Controls.Add(this.pUpdateMessage);
            this.Controls.Add(this.lblTitleGradeView);
            this.Controls.Add(this.pImagesIron);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pReciver);
            this.Name = "FrmChat";
            this.Text = "FrmChat";
            this.Load += new System.EventHandler(this.FrmChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSendMessage)).EndInit();
            this.cmsMessage.ResumeLayout(false);
            this.pMessage.ResumeLayout(false);
            this.pMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pImagesIron.ResumeLayout(false);
            this.pReciver.ResumeLayout(false);
            this.pReciver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSendPhoto)).EndInit();
            this.pUpdateMessage.ResumeLayout(false);
            this.pUpdateMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTextMessage;
        private System.Windows.Forms.PictureBox picSendMessage;
        private System.Windows.Forms.ContextMenuStrip cmsMessage;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSenderInfo;
        private System.Windows.Forms.Label lblReciverInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitlePanelMessage;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Panel pImagesIron;
        private System.Windows.Forms.Panel pReciver;
        private System.Windows.Forms.Label lblTitleGradeView;
        private System.Windows.Forms.Panel pUpdateMessage;
        private System.Windows.Forms.Label lblTitlePanel;
        private System.Windows.Forms.Button btnUpdateMessage;
        private System.Windows.Forms.TextBox txtNewMessage;
        private System.Windows.Forms.Label lblSetNewMessge;
        private System.Windows.Forms.Label lblCurrentMessage;
        private System.Windows.Forms.Label lblReciverName;
        private System.Windows.Forms.PictureBox picSendPhoto;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.PictureBox picPhoto2;
        private System.Windows.Forms.PictureBox picCurrentPhoto;
        private System.Windows.Forms.Button btnUpdatePhoto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}