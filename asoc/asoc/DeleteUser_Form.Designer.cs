namespace asoc
{
    partial class DeleteUser_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser_Form));
            this.button_AddClose = new System.Windows.Forms.Button();
            this.button_AddOk = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_AddClose
            // 
            this.button_AddClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button_AddClose.FlatAppearance.BorderSize = 0;
            this.button_AddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddClose.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_AddClose.Image = ((System.Drawing.Image)(resources.GetObject("button_AddClose.Image")));
            this.button_AddClose.Location = new System.Drawing.Point(180, 275);
            this.button_AddClose.Name = "button_AddClose";
            this.button_AddClose.Size = new System.Drawing.Size(185, 86);
            this.button_AddClose.TabIndex = 7;
            this.button_AddClose.Text = "Close";
            this.button_AddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AddClose.UseVisualStyleBackColor = false;
            this.button_AddClose.Click += new System.EventHandler(this.Button_AddClose_Click);
            // 
            // button_AddOk
            // 
            this.button_AddOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button_AddOk.FlatAppearance.BorderSize = 0;
            this.button_AddOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOk.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_AddOk.Image = ((System.Drawing.Image)(resources.GetObject("button_AddOk.Image")));
            this.button_AddOk.Location = new System.Drawing.Point(-1, 275);
            this.button_AddOk.Name = "button_AddOk";
            this.button_AddOk.Size = new System.Drawing.Size(191, 86);
            this.button_AddOk.TabIndex = 6;
            this.button_AddOk.Text = "Delete";
            this.button_AddOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AddOk.UseVisualStyleBackColor = false;
            this.button_AddOk.Click += new System.EventHandler(this.Button_AddOk_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.label_ID.Location = new System.Drawing.Point(124, 104);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(99, 20);
            this.label_ID.TabIndex = 10;
            this.label_ID.Text = "Delete ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(215)))), ((int)(((byte)(199)))));
            this.textBox_ID.Location = new System.Drawing.Point(103, 127);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(143, 28);
            this.textBox_ID.TabIndex = 9;
            // 
            // DeleteUser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(169)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_AddClose);
            this.Controls.Add(this.button_AddOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteUser_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteUser_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddClose;
        private System.Windows.Forms.Button button_AddOk;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
    }
}