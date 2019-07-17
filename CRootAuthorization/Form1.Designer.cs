namespace CRootAuthorization
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResourceUri = new System.Windows.Forms.TextBox();
            this.txtRedirectUri = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthority = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEmployeeType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbJsonResp = new System.Windows.Forms.RichTextBox();
            this.rtbJwt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResourceUri
            // 
            this.txtResourceUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResourceUri.Location = new System.Drawing.Point(106, 39);
            this.txtResourceUri.Name = "txtResourceUri";
            this.txtResourceUri.Size = new System.Drawing.Size(668, 21);
            this.txtResourceUri.TabIndex = 8;
            // 
            // txtRedirectUri
            // 
            this.txtRedirectUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRedirectUri.Location = new System.Drawing.Point(106, 93);
            this.txtRedirectUri.Name = "txtRedirectUri";
            this.txtRedirectUri.Size = new System.Drawing.Size(668, 21);
            this.txtRedirectUri.TabIndex = 9;
            // 
            // txtClientId
            // 
            this.txtClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientId.Location = new System.Drawing.Point(106, 66);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(668, 21);
            this.txtClientId.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "RedirectUri:";
            // 
            // txtAuthority
            // 
            this.txtAuthority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthority.Location = new System.Drawing.Point(106, 12);
            this.txtAuthority.Name = "txtAuthority";
            this.txtAuthority.Size = new System.Drawing.Size(668, 21);
            this.txtAuthority.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ClientId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "ResourceUri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Authority:";
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuthorize.Location = new System.Drawing.Point(699, 542);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorize.TabIndex = 13;
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "FirstName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "LastName:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(91, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(259, 21);
            this.tbFirstName.TabIndex = 9;
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(91, 30);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(259, 21);
            this.tbLastName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "DisplayName:";
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDisplayName.Location = new System.Drawing.Point(91, 57);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.ReadOnly = true;
            this.tbDisplayName.Size = new System.Drawing.Size(259, 21);
            this.tbDisplayName.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(91, 84);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(259, 21);
            this.tbEmail.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "EmployeeType:";
            // 
            // tbEmployeeType
            // 
            this.tbEmployeeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmployeeType.Location = new System.Drawing.Point(91, 111);
            this.tbEmployeeType.Name = "tbEmployeeType";
            this.tbEmployeeType.ReadOnly = true;
            this.tbEmployeeType.Size = new System.Drawing.Size(259, 21);
            this.tbEmployeeType.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "Roles:";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(15, 120);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tbFirstName);
            this.splitContainer.Panel1.Controls.Add(this.label6);
            this.splitContainer.Panel1.Controls.Add(this.label7);
            this.splitContainer.Panel1.Controls.Add(this.label8);
            this.splitContainer.Panel1.Controls.Add(this.tbEmployeeType);
            this.splitContainer.Panel1.Controls.Add(this.label9);
            this.splitContainer.Panel1.Controls.Add(this.tbEmail);
            this.splitContainer.Panel1.Controls.Add(this.label10);
            this.splitContainer.Panel1.Controls.Add(this.tbDisplayName);
            this.splitContainer.Panel1.Controls.Add(this.tbLastName);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listBoxRoles);
            this.splitContainer.Panel2.Controls.Add(this.label11);
            this.splitContainer.Size = new System.Drawing.Size(765, 141);
            this.splitContainer.SplitterDistance = 364;
            this.splitContainer.TabIndex = 15;
            this.splitContainer.TabStop = false;
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.ItemHeight = 12;
            this.listBoxRoles.Location = new System.Drawing.Point(60, 6);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(330, 124);
            this.listBoxRoles.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(15, 267);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(761, 269);
            this.tabControl.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbJwt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "JSON Web Token";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbJsonResp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AuthorizationInfo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbJsonResp
            // 
            this.rtbJsonResp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbJsonResp.Location = new System.Drawing.Point(3, 3);
            this.rtbJsonResp.Name = "rtbJsonResp";
            this.rtbJsonResp.ReadOnly = true;
            this.rtbJsonResp.Size = new System.Drawing.Size(712, 237);
            this.rtbJsonResp.TabIndex = 15;
            this.rtbJsonResp.Text = "";
            // 
            // rtbJwt
            // 
            this.rtbJwt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbJwt.Location = new System.Drawing.Point(3, 3);
            this.rtbJwt.Name = "rtbJwt";
            this.rtbJwt.ReadOnly = true;
            this.rtbJwt.Size = new System.Drawing.Size(747, 237);
            this.rtbJwt.TabIndex = 16;
            this.rtbJwt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btnAuthorize);
            this.Controls.Add(this.txtResourceUri);
            this.Controls.Add(this.txtRedirectUri);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthority);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Croot Authorization";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResourceUri;
        private System.Windows.Forms.TextBox txtRedirectUri;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEmployeeType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbJwt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbJsonResp;
    }
}

