using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.Models;
using EstateAgency.BaseLogic;

namespace EstateAgency
{
    public partial class FormSentence : Form
    {
        Sentence currSentence = new Sentence();

        public FormSentence()
        {
            InitializeComponent();
        }

        private void FillClients()
        {
            try
            {
                comboBoxClient.DataSource = (from client in ClassGetContext.context.Clients
                                             select new
                                             {
                                                 client.idClient,
                                                 name = client.lastName + " " + client.firstName
                                             }).ToList();

                comboBoxClient.ValueMember = "idClient";
                comboBoxClient.DisplayMember = "name";
            }
            catch
            {
                using (var form = new FormMessage("При заполнении выпадающего списка клиентовы произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void FillAgents()
        {
            try
            {
                comboBoxAgent.DataSource = (from agent in ClassGetContext.context.Agents
                                            select new
                                            {
                                                agent.idAgent,
                                                name = agent.lastName + " " + agent.firstName
                                            }).ToList();

                comboBoxAgent.ValueMember = "idAgent";
                comboBoxAgent.DisplayMember = "name";
            }
            catch
            {
                using (var form = new FormMessage("При заполнении выпадающего списка риелторов произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void FillEstate()
        {
            try
            {
                comboBoxEstate.DataSource = (from estate in ClassGetContext.context.EstateObjects
                                             select new
                                             {
                                                 estate.idEstate,
                                                 name = estate.city + "; " + estate.street + "; Дом: " + estate.house + "; Квартира: " + estate.addressNumber + "."
                                             }).ToList();

                comboBoxEstate.ValueMember = "idEstate";
                comboBoxEstate.DisplayMember = "name";
            }
            catch
            {
                using (var form = new FormMessage("При заполнении выпадающего списка недвижимости произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void FillTable()
        {
            try
            {
                var ctx = ClassGetContext.context;
                var sentences = (from sent in ctx.Sentences
                                 join client in ctx.Clients on sent.idClient equals client.idClient
                                 join agent in ctx.Agents on sent.idAgent equals agent.idAgent
                                 join estate in ctx.EstateObjects on sent.idEstate equals estate.idEstate
                                 select new
                                 {
                                     sent.idSentence,
                                     client.idClient,
                                     nameClient = client.lastName + " " + client.firstName,
                                     agent.idAgent,
                                     nameAgent = agent.lastName + " " + agent.firstName,
                                     estate.idEstate,
                                     objEstate = estate.city + "; " + estate.street + "; Дом: " + estate.house + "; Квартира: " + estate.addressNumber + ".",
                                     estate.typeEstate,
                                     sent.price,
                                 });

                dataGridViewSentences.Rows.Clear();
                foreach (var sent in sentences)
                {
                    dataGridViewSentences.Rows.Add(sent.idSentence, sent.idClient, sent.nameClient, sent.idAgent,
                        sent.nameAgent, sent.idEstate, sent.objEstate, sent.typeEstate, sent.price);
                }
            }
            catch
            {
                using (var form = new FormMessage("При заполнении списка недвижимости произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            Close();
        }

        private void FormSentence_Load(object sender, EventArgs e)
        {
            FillClients();
            FillAgents();
            FillEstate();
            FillTable();
        }

        private void dataGridViewSentences_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewSentences.CurrentRow;
            comboBoxClient.SelectedValue = row.Cells[1].Value;
            comboBoxAgent.SelectedValue = row.Cells[3].Value;
            currSentence.idEstate = Convert.ToInt32(row.Cells[5].Value);
            comboBoxEstate.SelectedValue = row.Cells[5].Value;
            numPrice.Value = Convert.ToDecimal(row.Cells[8].Value);
            buttonChange.Enabled = true;
            buttonDel.Enabled = true;
        }

        private void HidingTracks()
        {
            buttonChange.Enabled = false;
            buttonDel.Enabled = false;
            comboBoxAgent.Text = "";
            comboBoxClient.Text = "";
            comboBoxEstate.Text = "";
            numPrice.Value = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AllValid())
            {
                if (IsUsed(Convert.ToInt32(comboBoxEstate.SelectedValue)))
                {
                    using (var form = new FormMessage("Эта недвижимость уже участвует в предложении", ChangePic.warning))
                        form.ShowDialog();
                }
                else
                {
                    try
                    {
                        currSentence.idAgent = Convert.ToInt32(comboBoxAgent.SelectedValue);
                        currSentence.idClient = Convert.ToInt32(comboBoxClient.SelectedValue);
                        currSentence.idEstate = Convert.ToInt32(comboBoxEstate.SelectedValue);
                        currSentence.price = numPrice.Value;

                        ClassGetContext.context.Sentences.Add(currSentence);
                        ClassGetContext.context.SaveChanges();
                        FillTable();
                        HidingTracks();
                    }
                    catch
                    {
                        using (var form = new FormMessage("При подключении к базе данных во время добавления произошли ошибки", ChangePic.warning))
                            form.ShowDialog();
                    }
                }
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string message = "";
            if (AllValid())
            {
                int idEstate = Convert.ToInt32(comboBoxEstate.SelectedValue);
                if (IsUsed(idEstate) && currSentence.idEstate != idEstate)
                {
                    message = "Эта недвижимость уже участвует в предложении";
                }
                else
                {
                    try
                    {
                        currSentence = ClassGetContext.context.Sentences.Where(st => st.idEstate == currSentence.idEstate).FirstOrDefault();
                        currSentence.idAgent = Convert.ToInt32(comboBoxAgent.SelectedValue);
                        currSentence.idClient = Convert.ToInt32(comboBoxClient.SelectedValue);
                        currSentence.idEstate = Convert.ToInt32(comboBoxEstate.SelectedValue);
                        currSentence.price = numPrice.Value;

                        ClassGetContext.context.SaveChanges();
                        using (var form = new FormMessage("Изменения успешны", ChangePic.success))
                            form.ShowDialog();
                        FillTable();
                        HidingTracks();

                        return;
                    }
                    catch
                    {
                        message = "При подключении к базе данных во время изменения произошли ошибки";
                    }
                }
            }
            using (var form = new FormMessage(message, ChangePic.warning))
                form.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (AllValid())
            {
                try
                {
                    var deal = (from sent in ClassGetContext.context.Deals where sent.idSentence == currSentence.idSentence select sent);
                    if (deal.Any())
                    {
                        using (var form = new FormMessage("Это предложение участвует в сделке", ChangePic.warning))
                            form.ShowDialog();
                    }
                    else
                    {
                        currSentence = ClassGetContext.context.Sentences.Where(st => st.idEstate == currSentence.idEstate).FirstOrDefault();

                        ClassGetContext.context.Sentences.Remove(currSentence);
                        ClassGetContext.context.SaveChanges();
                        using (var form = new FormMessage("Удаление успешно", ChangePic.success))
                            form.ShowDialog();
                        FillTable();
                        HidingTracks();
                    }
                }
                catch
                {
                    using (var form = new FormMessage("При подключении к базе данных во время удаления произошли ошибки", ChangePic.error))
                        form.ShowDialog();
                }
            }
        }

        private bool IsUsed(int selectedId)
        {
            bool result = false;

            try
            {
                var locked = ClassGetContext.context.Sentences.Where(st => st.idEstate == selectedId);
                if(locked.Any())
                {
                    result = true;
                }
            }
            catch
            {
                using (var form = new FormMessage("При подключении к базе данных произошли ошибки", ChangePic.error))
                    form.ShowDialog();

                result = true;
            }

            return result;
        }

        private bool AllValid()
        {
            if(string.IsNullOrWhiteSpace(comboBoxAgent.Text) || 
                string.IsNullOrWhiteSpace(comboBoxClient.Text) ||
                string.IsNullOrWhiteSpace(comboBoxEstate.Text) ||
                numPrice.Value == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        } 
    }
}
