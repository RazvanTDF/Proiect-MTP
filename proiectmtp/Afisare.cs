using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace proiectmtp
{
    public partial class Afisare : Form
    {
        private DataGridView dataGridView1;

        public Afisare()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 484);
            this.dataGridView1.TabIndex = 1;
            // 
            // Afisare
            // 
            this.ClientSize = new System.Drawing.Size(1141, 528);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Afisare";
            this.Load += new System.EventHandler(this.Afisare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Afisare_Load(object sender, EventArgs e)
        {
            // String de conexiune pentru MySQL
            string connect = "Server=127.0.0.1;Port=3306;Database=mtp;User=root;Password=root;SslMode=Preferred;";

            // Creează o conexiune la baza de date
            using (MySqlConnection cnn = new MySqlConnection(connect))
            {
                try
                {
                    // Deschide conexiunea
                    cnn.Open();

                    // Creează scriptul de interogare pentru a obține datele din tabelul masini
                    string query = "SELECT * FROM masini";

                    // Creează un MySqlDataAdapter pentru a executa interogarea și a umple DataSet-ul
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, cnn);

                    // Creează un DataSet pentru a ține datele
                    DataSet dataSet = new DataSet();

                    // Umple DataSet-ul cu datele obținute din interogare
                    adapter.Fill(dataSet, "masini");

                    // Setează sursa de date a DataGridView-ului
                    dataGridView1.DataSource = dataSet.Tables["masini"].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Închide conexiunea
                    cnn.Close();
                }
            }
        }
    }
}