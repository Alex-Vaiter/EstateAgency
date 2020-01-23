using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            FormClients form = new FormClients();
            form.Show();
            Hide();
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            FormAgents form = new FormAgents();
            form.Show();
            Hide();
        }

        private void buttonEstate_Click(object sender, EventArgs e)
        {
            FormEstateObject form = new FormEstateObject();
            form.Show();
            Hide();
        }

        private void buttonSentence_Click(object sender, EventArgs e)
        {
            FormSentence form = new FormSentence();
            form.Show();
            Hide();
        }
    }
}
