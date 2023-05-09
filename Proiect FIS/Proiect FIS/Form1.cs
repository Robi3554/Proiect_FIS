using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void COMPbut_Click(object sender, EventArgs e)
        {
            Form form = new AirlineWindow();
            form.ShowDialog();
        }

        private void ANGbut_Click(object sender, EventArgs e)
        {
            Form form = new AngajatLogin();
            form.ShowDialog();
        }

        private void CLIbut_Click(object sender, EventArgs e)
        {
            Form form = new Client1();
            form.ShowDialog();
        }
    }
}
