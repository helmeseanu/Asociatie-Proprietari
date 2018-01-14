namespace asoc
{
    partial class Factura_Form
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
            this.total_label = new System.Windows.Forms.Label();
            this.suma_label = new System.Windows.Forms.Label();
            this.data_emitere_label = new System.Windows.Forms.Label();
            this.data_scadenta_label = new System.Windows.Forms.Label();
            this.perioada_facturare_label = new System.Windows.Forms.Label();
            this.factura_buton = new System.Windows.Forms.Button();
            this.lipsa_facturi_panel = new System.Windows.Forms.Panel();
            this.fara_facturi_label = new System.Windows.Forms.Label();
            this.Servicii_contor_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lipsa_facturi_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Servicii_contor_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.total_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.total_label.Location = new System.Drawing.Point(38, 335);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(53, 17);
            this.total_label.TabIndex = 13;
            this.total_label.Text = "Total:";
            // 
            // suma_label
            // 
            this.suma_label.AutoSize = true;
            this.suma_label.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.suma_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.suma_label.Location = new System.Drawing.Point(525, 335);
            this.suma_label.Name = "suma_label";
            this.suma_label.Size = new System.Drawing.Size(0, 17);
            this.suma_label.TabIndex = 14;
            // 
            // data_emitere_label
            // 
            this.data_emitere_label.AutoSize = true;
            this.data_emitere_label.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.data_emitere_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.data_emitere_label.Location = new System.Drawing.Point(525, 63);
            this.data_emitere_label.Name = "data_emitere_label";
            this.data_emitere_label.Size = new System.Drawing.Size(112, 17);
            this.data_emitere_label.TabIndex = 15;
            this.data_emitere_label.Text = "Data emitere:";
            // 
            // data_scadenta_label
            // 
            this.data_scadenta_label.AutoSize = true;
            this.data_scadenta_label.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.data_scadenta_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.data_scadenta_label.Location = new System.Drawing.Point(525, 97);
            this.data_scadenta_label.Name = "data_scadenta_label";
            this.data_scadenta_label.Size = new System.Drawing.Size(123, 17);
            this.data_scadenta_label.TabIndex = 16;
            this.data_scadenta_label.Text = "Data scadenta:";
            // 
            // perioada_facturare_label
            // 
            this.perioada_facturare_label.AutoSize = true;
            this.perioada_facturare_label.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.perioada_facturare_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.perioada_facturare_label.Location = new System.Drawing.Point(525, 131);
            this.perioada_facturare_label.Name = "perioada_facturare_label";
            this.perioada_facturare_label.Size = new System.Drawing.Size(128, 17);
            this.perioada_facturare_label.TabIndex = 17;
            this.perioada_facturare_label.Text = "Luna facturare:";
            // 
            // factura_buton
            // 
            this.factura_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.factura_buton.FlatAppearance.BorderSize = 0;
            this.factura_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factura_buton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factura_buton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.factura_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.factura_buton.Location = new System.Drawing.Point(619, 394);
            this.factura_buton.Name = "factura_buton";
            this.factura_buton.Size = new System.Drawing.Size(203, 53);
            this.factura_buton.TabIndex = 18;
            this.factura_buton.Text = "Plateste";
            this.factura_buton.UseVisualStyleBackColor = false;
            this.factura_buton.Click += new System.EventHandler(this.factura_buton_Click);
            // 
            // lipsa_facturi_panel
            // 
            this.lipsa_facturi_panel.Controls.Add(this.fara_facturi_label);
            this.lipsa_facturi_panel.Location = new System.Drawing.Point(12, 8);
            this.lipsa_facturi_panel.Name = "lipsa_facturi_panel";
            this.lipsa_facturi_panel.Size = new System.Drawing.Size(928, 439);
            this.lipsa_facturi_panel.TabIndex = 19;
            this.lipsa_facturi_panel.Visible = false;
            this.lipsa_facturi_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.lipsa_facturi_panel_Paint);
            // 
            // fara_facturi_label
            // 
            this.fara_facturi_label.AutoSize = true;
            this.fara_facturi_label.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.fara_facturi_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.fara_facturi_label.Location = new System.Drawing.Point(274, 201);
            this.fara_facturi_label.Name = "fara_facturi_label";
            this.fara_facturi_label.Size = new System.Drawing.Size(430, 31);
            this.fara_facturi_label.TabIndex = 3;
            this.fara_facturi_label.Text = "Nu s-a eliberat nici o factura!";
            // 
            // Servicii_contor_dataGridView
            // 
            this.Servicii_contor_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Servicii_contor_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Servicii_contor_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Servicii_contor_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Servicii_contor_dataGridView.Location = new System.Drawing.Point(41, 22);
            this.Servicii_contor_dataGridView.Name = "Servicii_contor_dataGridView";
            this.Servicii_contor_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Servicii_contor_dataGridView.RowTemplate.Height = 24;
            this.Servicii_contor_dataGridView.Size = new System.Drawing.Size(435, 126);
            this.Servicii_contor_dataGridView.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.dataGridView1.Location = new System.Drawing.Point(41, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(213, 126);
            this.dataGridView1.TabIndex = 21;
            // 
            // Factura_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(937, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Servicii_contor_dataGridView);
            this.Controls.Add(this.lipsa_facturi_panel);
            this.Controls.Add(this.factura_buton);
            this.Controls.Add(this.perioada_facturare_label);
            this.Controls.Add(this.data_scadenta_label);
            this.Controls.Add(this.data_emitere_label);
            this.Controls.Add(this.suma_label);
            this.Controls.Add(this.total_label);
            this.Name = "Factura_Form";
            this.Text = "Factura_Form";
            this.Load += new System.EventHandler(this.Factura_Form_Load);
            this.lipsa_facturi_panel.ResumeLayout(false);
            this.lipsa_facturi_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Servicii_contor_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label suma_label;
        private System.Windows.Forms.Label data_emitere_label;
        private System.Windows.Forms.Label data_scadenta_label;
        private System.Windows.Forms.Label perioada_facturare_label;
        private System.Windows.Forms.Button factura_buton;
        private System.Windows.Forms.Panel lipsa_facturi_panel;
        private System.Windows.Forms.Label fara_facturi_label;
        private System.Windows.Forms.DataGridView Servicii_contor_dataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}