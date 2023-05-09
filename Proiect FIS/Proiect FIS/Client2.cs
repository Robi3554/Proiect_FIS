using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proiect_FIS
{
    public partial class Client2 : Form
    {
        public Client2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = mailTxt.Text;

            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (string.IsNullOrEmpty(mailTxt.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(mailTxt, "Va rog introduceti un e-mail!");
            }
            else if (!string.IsNullOrWhiteSpace(mailTxt.Text))
            {
                if (!(expr.IsMatch(email)))
                {
                    textBox1.Focus();
                    errorProvider1.SetError(mailTxt, "Va rog introduceti un e-mail valid!");
                }
                else
                    this.Close();
            }
            else
            {
                this.Close();
            }


            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
