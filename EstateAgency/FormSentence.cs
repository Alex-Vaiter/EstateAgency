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
        public FormSentence()
        {
            InitializeComponent();
        }

        private void FillClients()
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

        private void FillAgents()
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

        private void FillEstate()
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
                using (var form = new FormMessage("Что-то пошло не так", ChangePic.error))
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
            comboBoxAgent.SelectedValue = row.Cells[3].Value;
            comboBoxClient.SelectedValue = row.Cells[1].Value;
            comboBoxEstate.SelectedValue = row.Cells[5].Value;
            numPrice.Value = Convert.ToDecimal(row.Cells[8].Value);
        }
    }
}
