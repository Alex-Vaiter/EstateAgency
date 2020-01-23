using EstateAgency.BaseLogic;
using EstateAgency.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EstateAgency
{
    public partial class FormClients : Form
    {
        Client currClient = new Client();
        public FormClients()
        {
            InitializeComponent();
        }

        private void FormClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var ctx = ClassGetContext.context;
            var isLock = (from client in ctx.Clients
                          join sentence in ctx.Sentences on client.idClient equals sentence.idClient
                          where client.idClient == currClient.idClient
                          select client);

            if (isLock.Any())
            {
                FormMessage form = new FormMessage("Данный клиент не может быть удален, так как участвует в Предложении", ChangePic.error);
                form.ShowDialog();
            }
            else
            {
                var del = ctx.Clients.Where(x => x.idClient == currClient.idClient).FirstOrDefault();
                ctx.Clients.Remove(del);
                ctx.SaveChanges();

                FillTable();
            }
            HidingTracks();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AllValid())
            {
                currClient.firstName = textBoxFirstN.Text;
                currClient.middleName = textBoxMiddleN.Text;
                currClient.lastName = textBoxLastN.Text;
                currClient.email = textBoxMail.Text;
                currClient.phone = textBoxPhone.Text;

                ClassGetContext.context.Clients.Add(currClient);
                ClassGetContext.context.SaveChanges();

                FillTable();
                HidingTracks();
            }
            else
            {
                FormMessage form = new FormMessage("Проверьте введенные данные", ChangePic.warning);
                form.ShowDialog();
            }

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (AllValid())
            {
                var middleClient = ClassGetContext.context.Clients.Where(x => x.idClient == currClient.idClient).FirstOrDefault();
                middleClient.firstName = textBoxFirstN.Text;
                middleClient.middleName = textBoxMiddleN.Text;
                middleClient.lastName = textBoxLastN.Text;
                middleClient.email = textBoxMail.Text;
                middleClient.phone = textBoxPhone.Text;

                ClassGetContext.context.SaveChanges();

                FormMessage form = new FormMessage("Изменения применены успешно", ChangePic.success);
                form.ShowDialog();

                FillTable();
                HidingTracks();
            }
            else
            {
                FormMessage form = new FormMessage("Проверьте введенные данные", ChangePic.warning);
                form.ShowDialog();
            }
        }
        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewClients.CurrentRow;
            currClient.idClient = Convert.ToInt32(row.Cells[0].Value);
            textBoxFirstN.Text = row.Cells[2].Value.ToString();
            textBoxMiddleN.Text = row.Cells[3].Value.ToString();
            textBoxLastN.Text = row.Cells[1].Value.ToString();
            textBoxPhone.Text = row.Cells[4].Value.ToString();
            textBoxMail.Text = row.Cells[5].Value.ToString();
            buttonChange.Enabled = true;
            buttonDel.Enabled = true;
        }

        private void FillTable()
        {
            dataGridViewClients.Rows.Clear();

            foreach (Client item in ClassGetContext.context.Clients)
            {
                dataGridViewClients.Rows.Add(item.idClient, item.lastName, item.firstName, item.middleName, item.phone, item.email);
            }
        }

        private void HidingTracks()
        {
            textBoxFirstN.Clear();
            textBoxMiddleN.Clear();
            textBoxLastN.Clear();
            textBoxPhone.Clear();
            textBoxMail.Clear();

            buttonChange.Enabled = false;
            buttonDel.Enabled = false;
        }

        private bool AllValid()
        {
            if (!string.IsNullOrWhiteSpace(textBoxPhone.Text) || textBoxMail.Text.Contains("@"))
            {
                return true;
            }

            return false;
        }
    }
}
