using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectmtp
{
    public partial class Cautare : Form
    {
        private TextBox txtCautat;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;

        public Cautare()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnCautare;
            this.label1 = new System.Windows.Forms.Label();
            this.txtCautat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            btnCautare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCautare
            // 
            btnCautare.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCautare.Location = new System.Drawing.Point(933, 39);
            btnCautare.Margin = new System.Windows.Forms.Padding(4);
            btnCautare.Name = "btnCautare";
            btnCautare.Size = new System.Drawing.Size(208, 59);
            btnCautare.TabIndex = 3;
            btnCautare.Text = "Căutare";
            btnCautare.UseVisualStyleBackColor = true;
            btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceți modelul dupa care doriti sa căutați:";
            // 
            // txtCautat
            // 
            this.txtCautat.BackColor = System.Drawing.Color.LightGray;
            this.txtCautat.Location = new System.Drawing.Point(482, 61);
            this.txtCautat.Margin = new System.Windows.Forms.Padding(4);
            this.txtCautat.Name = "txtCautat";
            this.txtCautat.Size = new System.Drawing.Size(435, 22);
            this.txtCautat.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1032, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Înapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 265);
            this.dataGridView1.TabIndex = 6;
            // 
            // Cautare
            // 
            this.ClientSize = new System.Drawing.Size(1154, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(btnCautare);
            this.Controls.Add(this.txtCautat);
            this.Controls.Add(this.label1);
            this.Name = "Cautare";
            this.Load += new System.EventHandler(this.Cautare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cautare_Load(object sender, EventArgs e)
        {
      
        }
        private void btnCautare_Click(object sender, EventArgs e)
        {
            string connect = "Server=127.0.0.1;Port=3306;Database=mtp;User=root;Password=root;SslMode=Preferred;";
            using (MySqlConnection cnn = new MySqlConnection(connect))
            {
                try
                {
                    cnn.Open();
                    string query = "SELECT * FROM masini WHERE model LIKE @model";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@model", "%" + txtCautat.Text + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }

                    MessageBox.Show("Datele au fost găsite cu succes.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
        }

    }
}
