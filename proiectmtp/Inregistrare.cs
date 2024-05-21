using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectmtp
{
    public partial class Inregistrare : Form
    {
        private TextBox txtUtilizator;
        private Label label1;
        private Label label2;
        private TextBox txtParola;
        private Button button1;
        private Button button2;

        public Inregistrare()
        {
            InitializeComponent();
        } 

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(130, 138);
            this.txtUtilizator.Margin = new System.Windows.Forms.Padding(4);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(274, 22);
            this.txtUtilizator.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Utilizator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parolă:";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(130, 189);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(274, 22);
            this.txtParola.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(627, 73);
            this.button1.TabIndex = 13;
            this.button1.Text = "Creare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Inregistrare
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inregistrare";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } //componente

        private void Inregistrare_Load(object sender, EventArgs e)
        {

        } //gol
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } //close

        private void button1_Click_1(object sender, EventArgs e)
        {
            string utilizator = txtUtilizator.Text;
            string parola = txtParola.Text;

            if (!ValidareText(utilizator))
            {
                MessageBox.Show("Numele de utilizator nu poate conține cifre, virgule sau alte caractere speciale.");
                return;
            }

            if (parola.Length < 3)
            {
                MessageBox.Show("Parola trebuie să conțină cel puțin 3 caractere.");
                return;
            }

           
            string[] lines = File.ReadAllLines("utilizatori.txt");

          
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == utilizator && parts[1] == parola)
                {
                    MessageBox.Show("Utilizatorul și parola există deja.");
                    return;
                }
            }

            using (System.IO.StreamWriter w = File.AppendText("utilizatori.txt"))
            {
                w.WriteLine($"{utilizator},{parola}");
            }

            MessageBox.Show("Înregistrare realizată cu succes!");
        } //inregistrare buton

        private bool ValidareText(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
