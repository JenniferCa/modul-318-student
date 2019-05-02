namespace TimeTable
{
    partial class Email
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpSendEmail = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.grpMyEmail = new System.Windows.Forms.GroupBox();
            this.btnCloseEmail = new System.Windows.Forms.Button();
            this.grpSendEmail.SuspendLayout();
            this.grpMyEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(319, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // grpSendEmail
            // 
            this.grpSendEmail.BackColor = System.Drawing.SystemColors.Control;
            this.grpSendEmail.Controls.Add(this.btnSend);
            this.grpSendEmail.Controls.Add(this.lblMessage);
            this.grpSendEmail.Controls.Add(this.rtbMessage);
            this.grpSendEmail.Controls.Add(this.txtReceiver);
            this.grpSendEmail.Controls.Add(this.txtSubject);
            this.grpSendEmail.Controls.Add(this.lblReceiver);
            this.grpSendEmail.Controls.Add(this.lblSubject);
            this.grpSendEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSendEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpSendEmail.Location = new System.Drawing.Point(25, 157);
            this.grpSendEmail.Name = "grpSendEmail";
            this.grpSendEmail.Size = new System.Drawing.Size(452, 461);
            this.grpSendEmail.TabIndex = 8;
            this.grpSendEmail.TabStop = false;
            this.grpSendEmail.Text = "Send Email";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(170, 395);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 39);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 108);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(82, 20);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message:";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(16, 131);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(417, 235);
            this.rtbMessage.TabIndex = 4;
            this.rtbMessage.Text = "";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(114, 33);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(319, 27);
            this.txtReceiver.TabIndex = 2;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(114, 66);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(319, 27);
            this.txtSubject.TabIndex = 3;
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Location = new System.Drawing.Point(12, 36);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(80, 20);
            this.lblReceiver.TabIndex = 0;
            this.lblReceiver.Text = "Receiver:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 69);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(70, 20);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject:";
            // 
            // grpMyEmail
            // 
            this.grpMyEmail.BackColor = System.Drawing.SystemColors.Control;
            this.grpMyEmail.Controls.Add(this.txtEmail);
            this.grpMyEmail.Controls.Add(this.txtPassword);
            this.grpMyEmail.Controls.Add(this.lblEmail);
            this.grpMyEmail.Controls.Add(this.lblPassword);
            this.grpMyEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpMyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMyEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpMyEmail.Location = new System.Drawing.Point(25, 27);
            this.grpMyEmail.Name = "grpMyEmail";
            this.grpMyEmail.Size = new System.Drawing.Size(452, 124);
            this.grpMyEmail.TabIndex = 7;
            this.grpMyEmail.TabStop = false;
            this.grpMyEmail.Text = "My Email Account";
            // 
            // btnCloseEmail
            // 
            this.btnCloseEmail.Location = new System.Drawing.Point(361, 637);
            this.btnCloseEmail.Name = "btnCloseEmail";
            this.btnCloseEmail.Size = new System.Drawing.Size(116, 44);
            this.btnCloseEmail.TabIndex = 9;
            this.btnCloseEmail.Text = "Close";
            this.btnCloseEmail.UseVisualStyleBackColor = true;
            this.btnCloseEmail.Click += new System.EventHandler(this.btnCloseEmail_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(506, 701);
            this.Controls.Add(this.grpSendEmail);
            this.Controls.Add(this.grpMyEmail);
            this.Controls.Add(this.btnCloseEmail);
            this.Name = "Email";
            this.Text = "Email";
            this.grpSendEmail.ResumeLayout(false);
            this.grpSendEmail.PerformLayout();
            this.grpMyEmail.ResumeLayout(false);
            this.grpMyEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox grpSendEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.GroupBox grpMyEmail;
        private System.Windows.Forms.Button btnCloseEmail;
    }
}