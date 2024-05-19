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
    public partial class Stergere : Form
    {
        private Label label1;
        private TextBox txtBox;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button btnInapoi;

        public Stergere()
        {
            InitializeComponent();
         
        }

        private void InitializeComponent()
        {
            this.btnInapoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInapoi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInapoi.Location = new System.Drawing.Point(1132, 441);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(112, 42);
            this.btnInapoi.TabIndex = 4;
            this.btnInapoi.Text = "Înapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Introduceți modelul și categoria mașinii pe care vreți să o ștergeți: ";
            // 
            // txtBox
            // 
            this.txtBox.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.txtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(321, 109);
            this.txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(316, 32);
            this.txtBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelul:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(708, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 74);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ștergere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(592, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 91);
            this.button2.TabIndex = 35;
            this.button2.Text = "Afișare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Stergere
            // 
            this.ClientSize = new System.Drawing.Size(1257, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInapoi);
            this.Name = "Stergere";
            this.Load += new System.EventHandler(this.Stergere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Stergere_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string connectionString = "Server=127.0.0.1;Port=3306;Database=mtp;User=root;Password=root;SslMode=Preferred;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string model = txtBox.Text;
                        string query = "DELETE FROM masini WHERE model = @model";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@model", model);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datele au fost șterse cu succes!");
                        }
                        else
                        {
                            MessageBox.Show("Nu s-au găsit înregistrări de șters.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message);
                    }
                }
            //intentionam sa adaug un modificator pentru resetarea autoincrementului dar nu am reusit

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Afisare formAfisare = new Afisare();
            formAfisare.Show();
        }
        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
