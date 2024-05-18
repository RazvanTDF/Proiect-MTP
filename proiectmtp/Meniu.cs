using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectmtp
{
    public partial class Meniu: Form
    {
        private Button btnAdaugare;
        private Button button1;
        private Button btnCautare;
        private Button btnStergere;
        private Button btnAnulare;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRtight, int nBottom, int nWidtEllipse, int nHeightEllipse);

        public Meniu()
        {
            InitializeComponent();
        }
        

        private void Meniu_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.btnAnulare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnulare
            // 
            this.btnAnulare.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulare.Location = new System.Drawing.Point(470, 426);
            this.btnAnulare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(117, 43);
            this.btnAnulare.TabIndex = 5;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.Transparent;
            this.btnAdaugare.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(91, 66);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(181, 86);
            this.btnAdaugare.TabIndex = 6;
            this.btnAdaugare.Text = "Adăugare Mașină";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(809, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 86);
            this.button1.TabIndex = 7;
            this.button1.Text = "Afișare mașini";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCautare
            // 
            this.btnCautare.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautare.Location = new System.Drawing.Point(91, 265);
            this.btnCautare.Margin = new System.Windows.Forms.Padding(4);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(181, 86);
            this.btnCautare.TabIndex = 8;
            this.btnCautare.Text = "Căutare ";
            this.btnCautare.UseVisualStyleBackColor = true;
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(809, 265);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(4);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(181, 86);
            this.btnStergere.TabIndex = 9;
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            // 
            // Meniu
            // 
            this.ClientSize = new System.Drawing.Size(1084, 501);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btnAnulare);
            this.Name = "Meniu";
            this.Load += new System.EventHandler(this.Meniu_Load_1);
            this.ResumeLayout(false);

        }

        private void Meniu_Load_1(object sender, EventArgs e)
        {

        }
        private void btnAnulare_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afisare f = new Afisare();
            f.ShowDialog();
        }
    }
}
