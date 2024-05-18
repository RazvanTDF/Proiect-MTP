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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.ClientSize = new System.Drawing.Size(1089, 486);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Afisare";
            this.Load += new System.EventHandler(this.Afisare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Afisare_Load(object sender, EventArgs e)
        {
            string connect = "Server=127.0.0.1;Port=3306;Database=mtp;User=root;Password=root;SslMode=Preferred;";
            using (MySqlConnection cnn = new MySqlConnection(connect))
            {
                try
                {
                    cnn.Open();
                    string query = "SELECT * FROM masini";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, cnn);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "masini");
                    dataGridView1.DataSource = dataSet.Tables["masini"].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }
    }
}