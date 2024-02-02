using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modernUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mdiProp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(228, 228, 228);

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        bool isExpand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isExpand == false)
            {
                repContainer.Height += 10;
                if (repContainer.Height >= repContainer.MaximumSize.Height) {
                    isExpand = true;
                    timer1.Stop();

                }
            }
            else {
                repContainer.Height -= 10;
                if (repContainer.Height <= repContainer.MinimumSize.Height)
                {
                    isExpand = false;
                    timer1.Stop();

                }
            }
        }

        private void mnReports_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void mnReports_MouseHover(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void mnReports_MouseLeave(object sender, EventArgs e)
        {
            //timer1.Start();
        }
    }
}
