namespace asoc
{
    partial class AddAngajati_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAngajati_Form));
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddOk = new System.Windows.Forms.Button();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.listBox_SelectPropritate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Close.Image")));
            this.button_Close.Location = new System.Drawing.Point(176, 275);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(185, 86);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "Close";
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.Button_AddClose_Click);
            // 
            // button_AddOk
            // 
            this.button_AddOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button_AddOk.FlatAppearance.BorderSize = 0;
            this.button_AddOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOk.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_AddOk.Image = ((System.Drawing.Image)(resources.GetObject("button_AddOk.Image")));
            this.button_AddOk.Location = new System.Drawing.Point(-7, 275);
            this.button_AddOk.Name = "button_AddOk";
            this.button_AddOk.Size = new System.Drawing.Size(191, 86);
            this.button_AddOk.TabIndex = 8;
            this.button_AddOk.Text = "Add";
            this.button_AddOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AddOk.UseVisualStyleBackColor = false;
            this.button_AddOk.Click += new System.EventHandler(this.Button_AddOk_Click);
            // 
            // textBox_Data
            // 
            this.textBox_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.textBox_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Data.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(215)))), ((int)(((byte)(199)))));
            this.textBox_Data.Location = new System.Drawing.Point(102, 198);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(154, 28);
            this.textBox_Data.TabIndex = 7;
            // 
            // listBox_SelectPropritate
            // 
            this.listBox_SelectPropritate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.listBox_SelectPropritate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_SelectPropritate.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_SelectPropritate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(215)))), ((int)(((byte)(199)))));
            this.listBox_SelectPropritate.FormattingEnabled = true;
            this.listBox_SelectPropritate.ItemHeight = 20;
            this.listBox_SelectPropritate.Items.AddRange(new object[] {
            "Nume",
            "Prenume",
            "Numar Telefon",
            "Email",
            "Functie",
            "Data Inscrierii"});
            this.listBox_SelectPropritate.Location = new System.Drawing.Point(102, 27);
            this.listBox_SelectPropritate.Name = "listBox_SelectPropritate";
            this.listBox_SelectPropritate.Size = new System.Drawing.Size(154, 142);
            this.listBox_SelectPropritate.TabIndex = 6;
            this.listBox_SelectPropritate.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectPropritate_SelectedIndexChanged);
            // 
            // AddAngajati_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(169)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_AddOk);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.listBox_SelectPropritate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAngajati_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFurnizor_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddOk;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.ListBox listBox_SelectPropritate;
    }
}