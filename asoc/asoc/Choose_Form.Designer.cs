namespace asoc
{
    partial class Choose_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Form));
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.Black;
            this.button_Add.Image = ((System.Drawing.Image)(resources.GetObject("button_Add.Image")));
            this.button_Add.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Add.Location = new System.Drawing.Point(0, 0);
            this.button_Add.Margin = new System.Windows.Forms.Padding(0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(120, 120);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add User";
            this.button_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Modify.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modify.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modify.ForeColor = System.Drawing.Color.Black;
            this.button_Modify.Image = ((System.Drawing.Image)(resources.GetObject("button_Modify.Image")));
            this.button_Modify.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Modify.Location = new System.Drawing.Point(360, 0);
            this.button_Modify.Margin = new System.Windows.Forms.Padding(0);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(120, 120);
            this.button_Modify.TabIndex = 1;
            this.button_Modify.Text = "Modify";
            this.button_Modify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Modify.UseVisualStyleBackColor = false;
            this.button_Modify.Click += new System.EventHandler(this.Button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.Black;
            this.button_Delete.Image = ((System.Drawing.Image)(resources.GetObject("button_Delete.Image")));
            this.button_Delete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Delete.Location = new System.Drawing.Point(120, 0);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 120);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete User";
            this.button_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // button_Show
            // 
            this.button_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.button_Show.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.ForeColor = System.Drawing.Color.Black;
            this.button_Show.Image = ((System.Drawing.Image)(resources.GetObject("button_Show.Image")));
            this.button_Show.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Show.Location = new System.Drawing.Point(240, 0);
            this.button_Show.Margin = new System.Windows.Forms.Padding(0);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(120, 120);
            this.button_Show.TabIndex = 3;
            this.button_Show.Text = "Show Users";
            this.button_Show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Show.UseVisualStyleBackColor = false;
            this.button_Show.Click += new System.EventHandler(this.Button_Show_Click);
            // 
            // Choose_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(480, 120);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.button_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Choose_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Show;
    }
}