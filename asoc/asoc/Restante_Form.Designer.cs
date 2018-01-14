namespace asoc
{
    partial class Restante_Form
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
            this.restante_buton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restante_facturi_panel = new System.Windows.Forms.Panel();
            this.fara_facturi_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.restante_facturi_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // restante_buton
            // 
            this.restante_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.restante_buton.FlatAppearance.BorderSize = 0;
            this.restante_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restante_buton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restante_buton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.restante_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restante_buton.Location = new System.Drawing.Point(753, 275);
            this.restante_buton.Name = "restante_buton";
            this.restante_buton.Size = new System.Drawing.Size(203, 53);
            this.restante_buton.TabIndex = 10;
            this.restante_buton.Text = "Plateste";
            this.restante_buton.UseVisualStyleBackColor = false;
            this.restante_buton.Click += new System.EventHandler(this.restante_buton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 173);
            this.dataGridView1.TabIndex = 11;
            // 
            // restante_facturi_panel
            // 
            this.restante_facturi_panel.Controls.Add(this.fara_facturi_label);
            this.restante_facturi_panel.Location = new System.Drawing.Point(1, 1);
            this.restante_facturi_panel.Name = "restante_facturi_panel";
            this.restante_facturi_panel.Size = new System.Drawing.Size(981, 349);
            this.restante_facturi_panel.TabIndex = 20;
            this.restante_facturi_panel.Visible = false;
            // 
            // fara_facturi_label
            // 
            this.fara_facturi_label.AutoSize = true;
            this.fara_facturi_label.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.fara_facturi_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.fara_facturi_label.Location = new System.Drawing.Point(281, 170);
            this.fara_facturi_label.Name = "fara_facturi_label";
            this.fara_facturi_label.Size = new System.Drawing.Size(425, 31);
            this.fara_facturi_label.TabIndex = 3;
            this.fara_facturi_label.Text = "Nu exista restante de palata!";
            // 
            // Restante_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(977, 351);
            this.Controls.Add(this.restante_facturi_panel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.restante_buton);
            this.Name = "Restante_Form";
            this.Text = "Restante_Form";
            this.Load += new System.EventHandler(this.Restante_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.restante_facturi_panel.ResumeLayout(false);
            this.restante_facturi_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restante_buton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel restante_facturi_panel;
        private System.Windows.Forms.Label fara_facturi_label;
    }
}