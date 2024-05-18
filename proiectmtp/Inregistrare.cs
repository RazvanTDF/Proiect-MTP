using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectmtp
{
    public partial class Inregistrare : Form
    {
        private Button button2;

        public Inregistrare()
        {
           InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(956, 391);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Inregistrare
            // 
            this.ClientSize = new System.Drawing.Size(1052, 448);
            this.Controls.Add(this.button2);
            this.Name = "Inregistrare";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            this.ResumeLayout(false);

        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {

        }
    }
}
