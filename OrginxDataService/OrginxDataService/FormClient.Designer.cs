namespace clientExample
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupConnect = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.Location = new System.Drawing.Point(6, 100);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(203, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Login";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
            // 
            // textBoxIp
            // 
            this.textBoxIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIp.Location = new System.Drawing.Point(98, 19);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(203, 20);
            this.textBoxIp.TabIndex = 1;
            this.textBoxIp.Text = "127.0.0.1";
            this.textBoxIp.TextChanged += new System.EventHandler(this.TextBoxIpTextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(98, 42);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(203, 20);
            this.textBoxEmail.TabIndex = 0;
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(11, 22);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(54, 13);
            this.labelIp.TabIndex = 3;
            this.labelIp.Text = "Server IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(98, 68);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(203, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangePass.Location = new System.Drawing.Point(40, 158);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(102, 69);
            this.buttonChangePass.TabIndex = 14;
            this.buttonChangePass.Text = "Edit Password";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.ButtonChangePassClick);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Location = new System.Drawing.Point(189, 166);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(102, 53);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogoutClick);
            // 
            // groupConnect
            // 
            this.groupConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConnect.Controls.Add(this.buttonCreate);
            this.groupConnect.Controls.Add(this.textBoxPassword);
            this.groupConnect.Controls.Add(this.textBoxIp);
            this.groupConnect.Controls.Add(this.buttonConnect);
            this.groupConnect.Controls.Add(this.label2);
            this.groupConnect.Controls.Add(this.textBoxEmail);
            this.groupConnect.Controls.Add(this.labelIp);
            this.groupConnect.Controls.Add(this.label1);
            this.groupConnect.Location = new System.Drawing.Point(12, 12);
            this.groupConnect.Name = "groupConnect";
            this.groupConnect.Size = new System.Drawing.Size(311, 127);
            this.groupConnect.TabIndex = 12;
            this.groupConnect.TabStop = false;
            this.groupConnect.Text = "Connection Detail";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(215, 100);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(90, 23);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreateClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(334, 494);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.groupConnect);
            this.Controls.Add(this.buttonLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "WeOnline";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupConnect.ResumeLayout(false);
            this.groupConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupConnect;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonChangePass;

    }
}

