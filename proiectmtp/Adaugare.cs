using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectmtp
{
    public partial class Adaugare : Form
    {
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPret;
        private TextBox txtCapMotor;
        private TextBox txtModel;
        private TextBox txtMarca;
        private Button btnSalvare;
        private Button button1;
        private ComboBox comboBoxAn;
        private ComboBox comboBoxCategorie;
        private Label label1;

        public Adaugare()
        {
            InitializeComponent();
            InitializeComboBoxAn();
            InitializeCategorieComboBox();
        }
        private void InitializeComboBoxAn()
        {
            for (int year = 1950; year <= 2024; year++)
            {
                comboBoxAn.Items.Add(year);
            }
        }
        private void InitializeCategorieComboBox()
        {
            comboBoxCategorie.Items.AddRange(new string[] { "Sedan", "Break", "SUV", "Monovolum", "Coupe", "SuperCar" });
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtCapMotor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceți o nouă mașină:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Prețul:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Capacitate motor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Categorie: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Anul:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Marca: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Model: ";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(207, 224);
            this.txtPret.Margin = new System.Windows.Forms.Padding(4);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(175, 22);
            this.txtPret.TabIndex = 29;
            // 
            // txtCapMotor
            // 
            this.txtCapMotor.Location = new System.Drawing.Point(207, 314);
            this.txtCapMotor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapMotor.Name = "txtCapMotor";
            this.txtCapMotor.Size = new System.Drawing.Size(175, 22);
            this.txtCapMotor.TabIndex = 28;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(207, 128);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(175, 22);
            this.txtModel.TabIndex = 25;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(207, 84);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(175, 22);
            this.txtMarca.TabIndex = 24;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(52, 363);
            this.btnSalvare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(309, 80);
            this.btnSalvare.TabIndex = 30;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1059, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "Înapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Location = new System.Drawing.Point(207, 178);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(175, 24);
            this.comboBoxAn.TabIndex = 32;
            this.comboBoxAn.SelectedIndexChanged += new System.EventHandler(this.comboBoxAn_SelectedIndexChanged);
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(207, 271);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(175, 24);
            this.comboBoxCategorie.TabIndex = 33;
            // 
            // Adaugare
            // 
            this.ClientSize = new System.Drawing.Size(1184, 510);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.comboBoxAn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtCapMotor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Adaugare";
            this.Load += new System.EventHandler(this.Adaugare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        } //anulare
        private void Adaugare_Load(object sender, EventArgs e)
        {

        } //gol
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please correct the errors before saving.");
                return;
            }

            string connect = "Server=127.0.0.1;Port=3306;Database=mtp;User=root;Password=root;SslMode=Preferred;";
            using (MySqlConnection cnn = new MySqlConnection(connect))
            {
                try
                {
                    cnn.Open();
                    string query = "INSERT INTO masini (marca, model, an, pret, categorie, capmotor) VALUES (@marca, @model, @an, @pret, @categorie, @capmotor)";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@an", comboBoxAn.SelectedItem);
                    cmd.Parameters.AddWithValue("@pret", int.Parse(txtPret.Text));
                    cmd.Parameters.AddWithValue("@categorie", comboBoxCategorie.SelectedItem);
                    cmd.Parameters.AddWithValue("@capmotor", txtCapMotor.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data inserted successfully.");
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
        private bool ValidateInputs()
        {
            bool isValid = true;

            // Validare marca și model
            if (!ValidateMarca(txtMarca.Text))
            {
                isValid = false;
                MessageBox.Show("Marca trebuie să înceapă cu literă mare și să conțină cel puțin 2 caractere (litere sau cifre).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!ValidateModel(txtModel.Text))
            {
                isValid = false;
                MessageBox.Show("Modelul trebuie să înceapă cu literă mare și să conțină cel puțin 3 litere.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Validare pret
            if (!int.TryParse(txtPret.Text, out _))
            {
                isValid = false;
                MessageBox.Show("Prețul trebuie să fie un număr întreg.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Validare capacitate motor
            if (!Regex.IsMatch(txtCapMotor.Text, @"^\d+(\.\d+)?$"))
            {
                isValid = false;
                MessageBox.Show("Capacitatea motorului trebuie să fie un număr valid (ex: 1.0, 2.5).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validare an
            if (comboBoxAn.SelectedItem == null)
            {
                isValid = false;
                MessageBox.Show("Selectați un an.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Validare categorie
            if (comboBoxCategorie.SelectedItem == null)
            {
                isValid = false;
                MessageBox.Show("Selectați o categorie.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return isValid;
        }
        private bool ValidateMarca(string text)
        {
            // Marca trebuie să înceapă cu o literă mare și să conțină cel puțin 2 caractere (litere sau cifre)
            return Regex.IsMatch(text, @"^[A-Z][a-zA-Z0-9]{1,}$");
        }
        private bool ValidateModel(string text)
        {
            // Modelul trebuie să înceapă cu o literă mare și să conțină cel puțin 3 litere
            return Regex.IsMatch(text, @"^[A-Z][a-zA-Z]{2,}$");
        }
        private void comboBoxAn_SelectedIndexChanged(object sender, EventArgs e)
        {
           //aici ...  nu stiu
        }
    }
}
