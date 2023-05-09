using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_FIS
{
    public partial class AngajatLogin : Form
    {
        public AngajatLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userBox.Text))
            {
                userBox.Focus();
                errorProvider1.SetError(userBox, "Va rog introduceti un username valid!");

            }
            else if (string.IsNullOrEmpty(passBox.Text))
            {
                passBox.Focus();
                errorProvider2.SetError(passBox, "Va rog introduceti o parola valida!");
                errorProvider1.Clear();
            }
            else
            {
                Form form = new Angajat();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
