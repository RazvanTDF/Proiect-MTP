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
            this.SuspendLayout();
            // 
            // btnAnulare
            // 
            this.btnAnulare.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulare.Location = new System.Drawing.Point(954, 445);
            this.btnAnulare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(117, 43);
            this.btnAnulare.TabIndex = 5;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            // 
            // Meniu
            // 
            this.ClientSize = new System.Drawing.Size(1084, 501);
            this.Controls.Add(this.btnAnulare);
            this.Name = "Meniu";
            this.Load += new System.EventHandler(this.Meniu_Load_1);
            this.ResumeLayout(false);

        }

        private void Meniu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
