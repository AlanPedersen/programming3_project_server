namespace MessageServer
{
    partial class FormServer
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
            this.gbxServerControls = new System.Windows.Forms.GroupBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.tbPipeName = new System.Windows.Forms.TextBox();
            this.lblPipeName = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lstCurrentUsers = new System.Windows.Forms.ListBox();
            this.gbxUserControls = new System.Windows.Forms.GroupBox();
            this.btnDisconnectUser = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbxMessageArea = new System.Windows.Forms.GroupBox();
            this.btnSendSend = new System.Windows.Forms.Button();
            this.btnSendClear = new System.Windows.Forms.Button();
            this.btnReceivedClear = new System.Windows.Forms.Button();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.lblSendBox = new System.Windows.Forms.Label();
            this.lblMessagesReceived = new System.Windows.Forms.Label();
            this.lstMessagesReceived = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslblErrorMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxServerControls.SuspendLayout();
            this.gbxUserControls.SuspendLayout();
            this.gbxMessageArea.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxServerControls
            // 
            this.gbxServerControls.Controls.Add(this.btnStartServer);
            this.gbxServerControls.Controls.Add(this.tbPipeName);
            this.gbxServerControls.Controls.Add(this.lblPipeName);
            this.gbxServerControls.Location = new System.Drawing.Point(13, 27);
            this.gbxServerControls.Name = "gbxServerControls";
            this.gbxServerControls.Size = new System.Drawing.Size(280, 88);
            this.gbxServerControls.TabIndex = 1;
            this.gbxServerControls.TabStop = false;
            this.gbxServerControls.Text = "server controls";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(184, 43);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 2;
            this.btnStartServer.Text = "start server";
            this.toolTip1.SetToolTip(this.btnStartServer, "start the server running");
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // tbPipeName
            // 
            this.tbPipeName.Enabled = false;
            this.tbPipeName.Location = new System.Drawing.Point(67, 17);
            this.tbPipeName.Name = "tbPipeName";
            this.tbPipeName.Size = new System.Drawing.Size(192, 20);
            this.tbPipeName.TabIndex = 1;
            this.tbPipeName.Text = "\\\\.\\pipe\\namedPipeJmc";
            this.toolTip1.SetToolTip(this.tbPipeName, "the name of the pipe used");
            // 
            // lblPipeName
            // 
            this.lblPipeName.AutoSize = true;
            this.lblPipeName.Location = new System.Drawing.Point(7, 20);
            this.lblPipeName.Name = "lblPipeName";
            this.lblPipeName.Size = new System.Drawing.Size(59, 13);
            this.lblPipeName.TabIndex = 0;
            this.lblPipeName.Text = "pipe name:";
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(184, 223);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(75, 23);
            this.btnLogOff.TabIndex = 7;
            this.btnLogOff.Text = "log out";
            this.toolTip1.SetToolTip(this.btnLogOff, "test log out");
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Enabled = false;
            this.btnNewUser.Location = new System.Drawing.Point(184, 254);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnNewUser.TabIndex = 6;
            this.btnNewUser.Text = "new user";
            this.toolTip1.SetToolTip(this.btnNewUser, "create a new user");
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(184, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "login";
            this.toolTip1.SetToolTip(this.btnLogin, "test login");
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lstCurrentUsers
            // 
            this.lstCurrentUsers.FormattingEnabled = true;
            this.lstCurrentUsers.Location = new System.Drawing.Point(10, 36);
            this.lstCurrentUsers.Name = "lstCurrentUsers";
            this.lstCurrentUsers.Size = new System.Drawing.Size(239, 147);
            this.lstCurrentUsers.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstCurrentUsers, "current users");
            // 
            // gbxUserControls
            // 
            this.gbxUserControls.Controls.Add(this.btnDisconnectUser);
            this.gbxUserControls.Controls.Add(this.btnLogOff);
            this.gbxUserControls.Controls.Add(this.btnNewUser);
            this.gbxUserControls.Controls.Add(this.btnLogin);
            this.gbxUserControls.Controls.Add(this.tbUserName);
            this.gbxUserControls.Controls.Add(this.tbUserPassword);
            this.gbxUserControls.Controls.Add(this.lblUserPassword);
            this.gbxUserControls.Controls.Add(this.lblUserName);
            this.gbxUserControls.Controls.Add(this.lstCurrentUsers);
            this.gbxUserControls.Location = new System.Drawing.Point(13, 130);
            this.gbxUserControls.Name = "gbxUserControls";
            this.gbxUserControls.Size = new System.Drawing.Size(280, 298);
            this.gbxUserControls.TabIndex = 2;
            this.gbxUserControls.TabStop = false;
            this.gbxUserControls.Text = "user controls";
            // 
            // btnDisconnectUser
            // 
            this.btnDisconnectUser.Enabled = false;
            this.btnDisconnectUser.Location = new System.Drawing.Point(71, 254);
            this.btnDisconnectUser.Name = "btnDisconnectUser";
            this.btnDisconnectUser.Size = new System.Drawing.Size(100, 23);
            this.btnDisconnectUser.TabIndex = 8;
            this.btnDisconnectUser.Text = "disconnect";
            this.toolTip1.SetToolTip(this.btnDisconnectUser, "disconnect a user");
            this.btnDisconnectUser.UseVisualStyleBackColor = true;
            this.btnDisconnectUser.Click += new System.EventHandler(this.btnDisconnectUser_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(71, 193);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbUserName, "enter user name");
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(71, 225);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(100, 20);
            this.tbUserPassword.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbUserPassword, "enter password");
            this.tbUserPassword.UseSystemPasswordChar = true;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(10, 228);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(55, 13);
            this.lblUserPassword.TabIndex = 2;
            this.lblUserPassword.Text = "password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(29, 196);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(36, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "name:";
            // 
            // gbxMessageArea
            // 
            this.gbxMessageArea.Controls.Add(this.btnSendSend);
            this.gbxMessageArea.Controls.Add(this.btnSendClear);
            this.gbxMessageArea.Controls.Add(this.btnReceivedClear);
            this.gbxMessageArea.Controls.Add(this.tbSendMessage);
            this.gbxMessageArea.Controls.Add(this.lblSendBox);
            this.gbxMessageArea.Controls.Add(this.lblMessagesReceived);
            this.gbxMessageArea.Controls.Add(this.lstMessagesReceived);
            this.gbxMessageArea.Location = new System.Drawing.Point(310, 27);
            this.gbxMessageArea.Name = "gbxMessageArea";
            this.gbxMessageArea.Size = new System.Drawing.Size(280, 402);
            this.gbxMessageArea.TabIndex = 4;
            this.gbxMessageArea.TabStop = false;
            this.gbxMessageArea.Text = "messages";
            // 
            // btnSendSend
            // 
            this.btnSendSend.Location = new System.Drawing.Point(101, 282);
            this.btnSendSend.Name = "btnSendSend";
            this.btnSendSend.Size = new System.Drawing.Size(75, 23);
            this.btnSendSend.TabIndex = 6;
            this.btnSendSend.Text = "send";
            this.toolTip1.SetToolTip(this.btnSendSend, "send a message");
            this.btnSendSend.UseVisualStyleBackColor = true;
            this.btnSendSend.Click += new System.EventHandler(this.btnSendSend_Click);
            // 
            // btnSendClear
            // 
            this.btnSendClear.Location = new System.Drawing.Point(182, 282);
            this.btnSendClear.Name = "btnSendClear";
            this.btnSendClear.Size = new System.Drawing.Size(75, 23);
            this.btnSendClear.TabIndex = 5;
            this.btnSendClear.Text = "clear";
            this.toolTip1.SetToolTip(this.btnSendClear, "clear send box");
            this.btnSendClear.UseVisualStyleBackColor = true;
            this.btnSendClear.Click += new System.EventHandler(this.btnSendClear_Click);
            // 
            // btnReceivedClear
            // 
            this.btnReceivedClear.Location = new System.Drawing.Point(183, 15);
            this.btnReceivedClear.Name = "btnReceivedClear";
            this.btnReceivedClear.Size = new System.Drawing.Size(75, 23);
            this.btnReceivedClear.TabIndex = 4;
            this.btnReceivedClear.Text = "clear";
            this.toolTip1.SetToolTip(this.btnReceivedClear, "clear received");
            this.btnReceivedClear.UseVisualStyleBackColor = true;
            this.btnReceivedClear.Click += new System.EventHandler(this.btnReceivedClear_Click);
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Location = new System.Drawing.Point(16, 310);
            this.tbSendMessage.Multiline = true;
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(242, 71);
            this.tbSendMessage.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbSendMessage, "message to send");
            // 
            // lblSendBox
            // 
            this.lblSendBox.AutoSize = true;
            this.lblSendBox.Location = new System.Drawing.Point(16, 287);
            this.lblSendBox.Name = "lblSendBox";
            this.lblSendBox.Size = new System.Drawing.Size(53, 13);
            this.lblSendBox.TabIndex = 2;
            this.lblSendBox.Text = "send box:";
            // 
            // lblMessagesReceived
            // 
            this.lblMessagesReceived.AutoSize = true;
            this.lblMessagesReceived.Location = new System.Drawing.Point(16, 20);
            this.lblMessagesReceived.Name = "lblMessagesReceived";
            this.lblMessagesReceived.Size = new System.Drawing.Size(101, 13);
            this.lblMessagesReceived.TabIndex = 1;
            this.lblMessagesReceived.Text = "messages received:";
            // 
            // lstMessagesReceived
            // 
            this.lstMessagesReceived.Enabled = false;
            this.lstMessagesReceived.FormattingEnabled = true;
            this.lstMessagesReceived.Location = new System.Drawing.Point(16, 43);
            this.lstMessagesReceived.Name = "lstMessagesReceived";
            this.lstMessagesReceived.Size = new System.Drawing.Size(242, 225);
            this.lstMessagesReceived.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstMessagesReceived, "messages received");
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(515, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "close";
            this.toolTip1.SetToolTip(this.btnClose, "close the application");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblErrorMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslblErrorMessage
            // 
            this.sslblErrorMessage.Name = "sslblErrorMessage";
            this.sslblErrorMessage.Size = new System.Drawing.Size(23, 17);
            this.sslblErrorMessage.Text = "OK";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxMessageArea);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxUserControls);
            this.Controls.Add(this.gbxServerControls);
            this.Name = "FormServer";
            this.Text = "Server";
            this.gbxServerControls.ResumeLayout(false);
            this.gbxServerControls.PerformLayout();
            this.gbxUserControls.ResumeLayout(false);
            this.gbxUserControls.PerformLayout();
            this.gbxMessageArea.ResumeLayout(false);
            this.gbxMessageArea.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxServerControls;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox tbPipeName;
        private System.Windows.Forms.Label lblPipeName;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListBox lstCurrentUsers;
        private System.Windows.Forms.GroupBox gbxUserControls;
        private System.Windows.Forms.Button btnDisconnectUser;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbxMessageArea;
        private System.Windows.Forms.Button btnSendSend;
        private System.Windows.Forms.Button btnSendClear;
        private System.Windows.Forms.Button btnReceivedClear;
        private System.Windows.Forms.TextBox tbSendMessage;
        private System.Windows.Forms.Label lblSendBox;
        private System.Windows.Forms.Label lblMessagesReceived;
        private System.Windows.Forms.ListBox lstMessagesReceived;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslblErrorMessage;
    }
}

