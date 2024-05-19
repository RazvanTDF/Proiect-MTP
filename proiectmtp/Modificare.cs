using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proiectmtp
{
    public partial class Modificare : Form
    {
        public Modificare()
        {
            InitializeComponent();
            FillYearComboBox();
        }

        private void FillYearComboBox()
        {
            for (int year = 1950; year <= 2024; year++)
            {
                comboBoxAn.Items.Add(year);
            }
        }
        private void InitializeComponent()
        {
            this.labelMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.labelAn = new System.Windows.Forms.Label();
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.labelPret = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.labelCapMotor = new System.Windows.Forms.Label();
            this.txtCapMotor = new System.Windows.Forms.TextBox();
            this.btnCautare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(20, 20);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(45, 16);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(100, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(20, 60);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(45, 16);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(100, 60);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 22);
            this.txtModel.TabIndex = 3;
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Location = new System.Drawing.Point(20, 100);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(23, 16);
            this.labelAn.TabIndex = 4;
            this.labelAn.Text = "An";
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Location = new System.Drawing.Point(100, 100);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(200, 24);
            this.comboBoxAn.TabIndex = 5;
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(20, 140);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(31, 16);
            this.labelPret.TabIndex = 6;
            this.labelPret.Text = "Pret";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(100, 140);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(200, 22);
            this.txtPret.TabIndex = 7;
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Location = new System.Drawing.Point(20, 180);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(66, 16);
            this.labelCategorie.TabIndex = 8;
            this.labelCategorie.Text = "Categorie";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Items.AddRange(new object[] {
            "Sedan",
            "SUV",
            "Break",
            "SuperCar"});
            this.comboBoxCategorie.Location = new System.Drawing.Point(100, 180);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCategorie.TabIndex = 9;
            // 
            // labelCapMotor
            // 
            this.labelCapMotor.AutoSize = true;
            this.labelCapMotor.Location = new System.Drawing.Point(20, 220);
            this.labelCapMotor.Name = "labelCapMotor";
            this.labelCapMotor.Size = new System.Drawing.Size(72, 16);
            this.labelCapMotor.TabIndex = 10;
            this.labelCapMotor.Text = "Cap. Motor";
            // 
            // txtCapMotor
            // 
            this.txtCapMotor.Location = new System.Drawing.Point(100, 220);
            this.txtCapMotor.Name = "txtCapMotor";
            this.txtCapMotor.Size = new System.Drawing.Size(200, 22);
            this.txtCapMotor.TabIndex = 11;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(100, 260);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(200, 30);
            this.btnCautare.TabIndex = 12;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 30);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Actualizare";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(703, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "Înapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modificare
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.txtCapMotor);
            this.Controls.Add(this.labelCapMotor);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.comboBoxAn);
            this.Controls.Add(this.labelAn);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.labelMarca);
            this.Name = "Modificare";
            this.Text = "Formular de Actualizare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string connect = "Server=127.0.0.1;Port=3306;Database=mtp;User=root;Password=root;SslMode=Preferred;";
            using (MySqlConnection cnn = new MySqlConnection(connect))
            {
                try
                {
                    cnn.Open();
                    string query = "SELECT * FROM masini WHERE marca = @marca AND model = @model AND an = @an AND pret = @pret";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@an", comboBoxAn.SelectedItem);
                    cmd.Parameters.AddWithValue("@pret", int.Parse(txtPret.Text));

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați o înregistrare pentru actualizare.");
                return;
            }

            if (!ValidateInputs()) return;

            string connect = "Server=127.0.0.1;Port=3306;Database=mtp;User=root;Password=root;SslMode=Preferred;";
            using (MySqlConnection cnn = new MySqlConnection(connect))
            {
                try
                {
                    cnn.Open();
                    string query = "UPDATE masini SET marca = @marca, model = @model, an = @an, pret = @pret, categorie = @categorie, capmotor = @capmotor WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@an", comboBoxAn.SelectedItem);
                    cmd.Parameters.AddWithValue("@pret", int.Parse(txtPret.Text));
                    cmd.Parameters.AddWithValue("@categorie", comboBoxCategorie.SelectedItem);
                    cmd.Parameters.AddWithValue("@capmotor", double.Parse(txtCapMotor.Text));
                    cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Înregistrarea a fost actualizată cu succes.");
                    }
                    else
                    {
                        MessageBox.Show("Actualizarea a eșuat.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
        }

        private bool ValidateInputs()
        {
            if (txtMarca.Text.Length < 3 || !char.IsUpper(txtMarca.Text[0]) || !Regex.IsMatch(txtMarca.Text, @"^[A-Z][a-zA-Z]*$"))
            {
                MessageBox.Show("Marca trebuie să aibă minim 3 litere, prima literă mare.");
                return false;
            }

            if (txtModel.Text.Length < 2 || !Regex.IsMatch(txtModel.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Modelul trebuie să aibă minim 2 litere și poate conține cifre.");
                return false;
            }

            if (!int.TryParse(comboBoxAn.SelectedItem.ToString(), out int an) || an < 1950 || an > 2024)
            {
                MessageBox.Show("Anul trebuie să fie între 1950 și 2024.");
                return false;
            }

            if (!int.TryParse(txtPret.Text, out int pret) || pret <= 0)
            {
                MessageBox.Show("Prețul trebuie să fie un număr întreg pozitiv.");
                return false;
            }

            if (!double.TryParse(txtCapMotor.Text, out double capMotor) || capMotor <= 0)
            {
                MessageBox.Show("Capacitatea motorului trebuie să fie un număr pozitiv.");
                return false;
            }

            if (comboBoxCategorie.SelectedItem == null)
            {
                MessageBox.Show("Selectați o categorie.");
                return false;
            }

            return true;
        }

        private Label labelMarca;
        private TextBox txtMarca;
        private Label labelModel;
        private TextBox txtModel;
        private Label labelAn;
        private ComboBox comboBoxAn;
        private Label labelPret;
        private TextBox txtPret;
        private Label labelCategorie;
        private ComboBox comboBoxCategorie;
        private Label labelCapMotor;
        private TextBox txtCapMotor;
        private Button btnCautare;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnUpdate;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
