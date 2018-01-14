using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace asoc
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Button_Utilitati_Click(object sender, EventArgs e)
        {
            if (label_ListaUtilitati.Visible == false)
            {
                panel_Listare.Visible = true;
                label_ListaUtilitati.Visible = true;
                listBox_Utilitati.Visible = true;
                dataGridView_Afisare.Visible = true;
                button_XML.Visible = true;
                button_PDF.Visible = true;
                button_CSV.Visible = true;
            }
            else if (label_ListaUtilitati.Visible == true)
            {
                button_XML.Visible = false;
                button_PDF.Visible = false;
                button_CSV.Visible = false;
                dataGridView_Afisare.Visible = false;
                label_ListaUtilitati.Visible = false;
                listBox_Utilitati.Visible = false;
                panel_Listare.Visible = false;
            }
        }

        private void Button_Administrare_Useri_Click(object sender, EventArgs e)
        {
            if (label_ListaUtilitati.Visible == true)
            {
                button_XML.Visible = false;
                button_PDF.Visible = false;
                button_CSV.Visible = false;
                panel_Listare.Visible = false;
                label_ListaUtilitati.Visible = false;
                listBox_Utilitati.Visible = false;
                dataGridView_Afisare.Visible = false;
            }

            Choose_Form choose_form = new Choose_Form();
            choose_form.ShowDialog();
        }

        private void ListBox_Utilitati_Click(object sender, EventArgs e)
        {
            try
            {
                string curItem = listBox_Utilitati.SelectedItem.ToString();

                int index = listBox_Utilitati.FindString(curItem);

                switch (curItem)
                {
                    case "Agent Termic":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.Agent_Termic
                                          select new
                                          { row.Index, row.IdApartament, row.Suma_de_plata, row.Data_emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Suma_de_plata, item.Data_emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Apa Calda":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.ApaCalda
                                          select new
                                          { row.Index, row.IdApartament, row.Index_Vechi, row.Index_Nou, row.Consum, row.Pret_m_cub, row.Suma_de_Plata, row.Data_emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Index_Vechi");
                            table.Columns.Add("Index_Nou");
                            table.Columns.Add("Consum");
                            table.Columns.Add("Pret_m_cub");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Index_Vechi, item.Index_Nou, item.Consum, item.Pret_m_cub, item.Suma_de_Plata, item.Data_emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Apa Rece":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.ApaRece
                                          select new
                                          { row.Index, row.IdApartament, row.Index_Vechi, row.Index_Nou, row.Consum, row.Pret_m_cub, row.Suma_de_plata, row.Data_emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Index_Vechi");
                            table.Columns.Add("Index_Nou");
                            table.Columns.Add("Consum");
                            table.Columns.Add("Pret_m_cub");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Index_Vechi, item.Index_Nou, item.Consum, item.Pret_m_cub, item.Suma_de_plata, item.Data_emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Canalizare":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.Canalizare
                                          select new
                                          { row.Index, row.IdApartament, row.Suma_de_plata, row.Data_emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Suma_de_plata, item.Data_emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Curatenie":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.Curatenie
                                          select new
                                          { row.Index, row.IdApartament, row.Suma_de_plata, row.Data_emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Suma_de_plata, item.Data_emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Energie Electrica":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.EnergieElectrica
                                          select new
                                          { row.Index, row.IdApartament, row.Index_Vechi, row.Index_Nou, row.Consum, row.Pret_Kw, row.Suma_de_plata, row.Data_emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Index_Vechi");
                            table.Columns.Add("Index_Nou");
                            table.Columns.Add("Consum");
                            table.Columns.Add("Pret_Kw");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_Emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Index_Vechi, item.Index_Nou, item.Consum, item.Pret_Kw, item.Suma_de_plata, item.Data_emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Gaz":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.Gaz
                                          select new
                                          { row.Index, row.IdApartament, row.Index_Vechi, row.Index_Nou, row.Consum, row.Pret_m_cub, row.Suma_de_plata, row.Data_Emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Index_Vechi");
                            table.Columns.Add("Index_Nou");
                            table.Columns.Add("Consum");
                            table.Columns.Add("Pret_m_cub");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_Emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Index_Vechi, item.Index_Nou, item.Consum, item.Pret_m_cub, item.Suma_de_plata, item.Data_Emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Lift":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.Lift
                                          select new
                                          { row.Index, row.IdApartament, row.Suma_de_plata, row.Data_emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Suma_de_plata, item.Data_emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Salubritate":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.Salubritate
                                          select new
                                          { row.Index, row.IdApartament, row.Suma_de_plata, row.Data_emitere };

                            table.Columns.Add("Index");
                            table.Columns.Add("IdApartament");
                            table.Columns.Add("Suma_de_plata");
                            table.Columns.Add("Data_emitere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.Index, item.IdApartament, item.Suma_de_plata, item.Data_emitere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    case "Membri Asociatie":
                        {
                            Asociatie_ProprietariEntities context = new Asociatie_ProprietariEntities();
                            DataTable table = new DataTable();

                            var results = from row in context.Membri_Asociatie
                                          select new
                                          { row.ID, row.Nume, row.Prenume, row.Numar_telefon, row.Emai, row.Functie, row.Data_Inscriere };

                            table.Columns.Add("ID");
                            table.Columns.Add("Nume");
                            table.Columns.Add("Prenume");
                            table.Columns.Add("Numar_telefon");
                            table.Columns.Add("Emai");
                            table.Columns.Add("Functie");
                            table.Columns.Add("Data_Inscriere");

                            foreach (var item in results)
                            {
                                table.Rows.Add(new object[] { item.ID, item.Nume, item.Prenume, item.Numar_telefon, item.Emai, item.Functie, item.Data_Inscriere });
                            }

                            dataGridView_Afisare.DataSource = table;

                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Error!");
                            break;
                        }
                }
            }
            catch
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void Button_LogOFF_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Adm_Apartamente_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Adm_Furnizori_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Adm_Angajati_Click(object sender, EventArgs e)
        {
            if (label_ListaUtilitati.Visible == true)
            {
                button_XML.Visible = false;
                button_PDF.Visible = false;
                button_CSV.Visible = false;
                panel_Listare.Visible = false;
                label_ListaUtilitati.Visible = false;
                listBox_Utilitati.Visible = false;
                dataGridView_Afisare.Visible = false;
            }

            Choose_Angajati choose_form = new Choose_Angajati();
            choose_form.ShowDialog();
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dataTable = new DataTable();
            int j = 0;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dataTable.Columns.Add();
                    dataTable.Columns[j].ColumnName = dgv.Columns[j].HeaderText;                   
                    j++;
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];

            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }

                dataTable.Rows.Add(cellValues);
            }
            return dataTable;
        }

        private void Button_XML_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetDataTableFromDGV(dataGridView_Afisare);
            DataSet dataSet = new DataSet();

            dataSet.Tables.Add(dataTable);
            dataSet.WriteXml(File.OpenWrite(@"C:\Users\Cotenghiu-PC\Desktop\xml.xml"));
        }

        private void Button_PDF_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetDataTableFromDGV(dataGridView_Afisare);
            CreatePDF(dataTable, @"C:\Users\Cotenghiu-PC\Desktop\ex.pdf");
        }

        public void CreatePDF(DataTable dataTable, string destinationPath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationPath, FileMode.Create));

            document.Open();

            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            table.WidthPercentage = 100;

            for (int k = 0; k < dataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                table.AddCell(cell);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataTable.Rows[i][j].ToString()));

                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Close();
        }

        private void button_CSV_Click(object sender, EventArgs e)
        {
            string csv = string.Empty;

            foreach (DataGridViewColumn column in dataGridView_Afisare.Columns)
            {
                csv += column.HeaderText + ',';
            }

            csv += "\r\n";

            foreach (DataGridViewRow row in dataGridView_Afisare.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

                csv += "\r\n";
            }

            string folderPath = "C:\\Users\\Cotenghiu-PC\\Desktop\\";
            File.WriteAllText(folderPath + "DataGridViewExport.csv", csv);
        }
    }  
}
