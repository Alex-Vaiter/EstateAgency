using EstateAgency.BaseLogic;
using EstateAgency.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EstateAgency
{
    public partial class FormAgents : Form
    {
        Agent currAgent = new Agent();

        public FormAgents()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (AllValid())
                {
                    currAgent.firstName = textBoxFirstN.Text;
                    currAgent.middleName = textBoxMiddleN.Text;
                    currAgent.lastName = textBoxLastN.Text;
                    currAgent.dealShare = (int)numDealShare.Value;

                    ClassGetContext.context.Agents.Add(currAgent);
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
            catch
            {
                using (var form = new FormMessage("При подключении к базе данных во время добавления произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (AllValid())
                {
                    currAgent = ClassGetContext.context.Agents.Where(x => x.idAgent == currAgent.idAgent).FirstOrDefault();
                    currAgent.firstName = textBoxFirstN.Text;
                    currAgent.middleName = textBoxMiddleN.Text;
                    currAgent.lastName = textBoxLastN.Text;
                    currAgent.dealShare = (int)numDealShare.Value;

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
            catch
            {
                using (var form = new FormMessage("При подключении к базе данных во время изменения произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                var ctx = ClassGetContext.context;
                var isLock = (from agent in ctx.Agents
                              join sentence in ctx.Sentences on agent.idAgent equals sentence.idAgent
                              where agent.idAgent == currAgent.idAgent
                              select agent);

                if (isLock.Any())
                {
                    FormMessage form = new FormMessage("Данный агент не может быть удален, так как участвует в Предложении", ChangePic.error);
                    form.ShowDialog();
                }
                else
                {
                    var del = ctx.Agents.Where(x => x.idAgent == currAgent.idAgent).FirstOrDefault();
                    ctx.Agents.Remove(del);
                    ctx.SaveChanges();

                    FillTable();
                }
                HidingTracks();
            }
            catch
            {
                using (var form = new FormMessage("При подключении к базе данных во время удаления произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewAgents.CurrentRow;

            currAgent.idAgent = Convert.ToInt32(row.Cells[0].Value);
            textBoxFirstN.Text = row.Cells[2].Value.ToString();
            textBoxMiddleN.Text = row.Cells[3].Value.ToString();
            textBoxLastN.Text = row.Cells[1].Value.ToString();
            numDealShare.Value = Convert.ToInt32(row.Cells[4].Value);

            buttonChange.Enabled = true;
            buttonDel.Enabled = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAgents_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            dataGridViewAgents.Rows.Clear();
            try
            {
                foreach (Agent item in ClassGetContext.context.Agents)
                {
                    dataGridViewAgents.Rows.Add(item.idAgent, item.lastName, item.firstName, item.middleName, item.dealShare);
                }
            }
            catch
            {
                using (var form = new FormMessage("При заполнении списка агентов произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void HidingTracks()
        {
            textBoxFirstN.Clear();
            textBoxMiddleN.Clear();
            textBoxLastN.Clear();
            numDealShare.Value = 0;

            buttonChange.Enabled = false;
            buttonDel.Enabled = false;
        }

        private bool AllValid()
        {
            if (!string.IsNullOrWhiteSpace(textBoxFirstN.Text) && !string.IsNullOrWhiteSpace(textBoxMiddleN.Text)
                && !string.IsNullOrWhiteSpace(textBoxLastN.Text))
            {
                return true;
            }

            return false;
        }

        private void FormAgents_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
        }
    }
}
