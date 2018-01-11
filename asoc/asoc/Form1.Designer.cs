namespace asoc
{
    partial class AsociatieProprietari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsociatieProprietari));
            this.password_textbox = new System.Windows.Forms.MaskedTextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.user_textbox = new System.Windows.Forms.MaskedTextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(142, 124);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(233, 20);
            this.password_textbox.TabIndex = 2;
            this.password_textbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.password_textbox_MaskInputRejected);
            // 
            // user_label
            // 
            this.user_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_label.Location = new System.Drawing.Point(51, 82);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(57, 20);
            this.user_label.TabIndex = 3;
            this.user_label.Text = "User";
            this.user_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_label.Click += new System.EventHandler(this.User_Click);
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.password_label.Location = new System.Drawing.Point(51, 124);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(57, 20);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(300, 170);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 28);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // user_textbox
            // 
            this.user_textbox.Location = new System.Drawing.Point(142, 82);
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(233, 20);
            this.user_textbox.TabIndex = 6;
            this.user_textbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.user_textbox_MaskInputRejected);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(142, 170);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 28);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // AsociatieProprietari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(479, 267);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.user_textbox);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.password_textbox);
            this.MaximumSize = new System.Drawing.Size(495, 306);
            this.MinimumSize = new System.Drawing.Size(495, 306);
            this.Name = "AsociatieProprietari";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Asociatie Proprietari";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox password_textbox;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.MaskedTextBox user_textbox;
        private System.Windows.Forms.Button login_button;
    }
}

