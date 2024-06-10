
namespace agam.Forms
{
    partial class frmlogin
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
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.joinUs = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(186, 477);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 29);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(186, 532);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(110, 29);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // joinUs
            // 
            this.joinUs.AutoSize = true;
            this.joinUs.BackColor = System.Drawing.Color.Transparent;
            this.joinUs.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joinUs.Location = new System.Drawing.Point(798, 465);
            this.joinUs.Name = "joinUs";
            this.joinUs.Size = new System.Drawing.Size(241, 29);
            this.joinUs.TabIndex = 3;
            this.joinUs.Text = "dont have an account?";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.Location = new System.Drawing.Point(310, 478);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(134, 26);
            this.usernameTxt.TabIndex = 4;
            this.usernameTxt.Text = "Lia Cohen";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.Location = new System.Drawing.Point(310, 534);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(134, 26);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.Text = "27bsb2";
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(476, 495);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(152, 69);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.SignUpbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpbtn.Location = new System.Drawing.Point(849, 497);
            this.SignUpbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(162, 68);
            this.SignUpbtn.TabIndex = 7;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::agam.Properties.Resources.netflix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 643);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.joinUs);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label joinUs;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button SignUpbtn;
    }
}