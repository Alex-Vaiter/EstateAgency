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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDeal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        private void FillTable()
        {
            var ctx = ClassGetContext.context;

            var table = (from deal in ctx.Deals
                         join sent in ctx.Sentences on deal.idSentence equals sent.idSentence
                         join demand in ctx.Demands on deal.idDemand equals demand.idDemand
                         join agentSent in ctx.Agents on sent.idAgent equals agentSent.idAgent
                         join clientSent in ctx.Clients on sent.idClient equals clientSent.idClient
                         join agentDem in ctx.Agents on demand.idAgent equals agentDem.idAgent
                         join clientDem in ctx.Clients on demand.idClient equals clientDem.idClient
                         join estate in ctx.EstateObjects on sent.idEstate equals estate.idEstate
                         select new
                         {
                             deal.idDeal,
                             deal.idDemand,
                             deal.idSentence,
                             address = estate.city + " " + estate.street + " " + estate.house,
                             sent.price,
                             nameAS = agentSent.lastName + " " + agentSent.firstName,
                             nameCS = clientSent.lastName + " " + clientSent.firstName,
                             nameAD = agentDem.lastName + " " + agentDem.firstName,
                             nameCD = clientDem.lastName + " " + clientDem.firstName,
                         });

            foreach(var row in table)
            {
                dataGridViewDeals.Rows.Add(row.idDeal, row.idDemand, row.idSentence, row.address, 
                    row.price, row.nameCD, row.nameAD, row.nameCS, row.nameAS);
            }
        }

        private void FillSentence()
        {
            var ctx = ClassGetContext.context;

            comboBoxSentence.DataSource = (from sent in ctx.Sentences
                                           join estate in ctx.EstateObjects on sent.idEstate equals estate.idEstate
                                           select new
                                           {
                                               idSent = sent.idSentence,
                                               address = "Город: " + estate.city +
                                               ((estate.street == null || estate.street == "") ? "" : "; Улица: " + estate.street) +
                                               ((estate.house == null || estate.house == "0" || estate.house == "") ? "" : "; Дом: " + estate.house) +
                                               ((estate.addressNumber == null || estate.addressNumber == "0" || estate.addressNumber == "") ? "" : "; Квартира: " + estate.addressNumber) +
                                               ((estate.rooms == null || estate.rooms == 0) ? "" : "; Кол-во комнат: " + estate.rooms) +
                                               ((estate.totalArea == null || estate.totalArea == 0) ? "" : "; Площадь: " + estate.totalArea) +
                                               ((estate.totalFloors == null || estate.totalFloors == 0) ? "" : "; Всего этажей: " + estate.totalFloors) +
                                               ((estate.floor == null || estate.floor == 0) ? "" : "; Этаж: " + estate.floor) +
                                               "; Тип: " + estate.typeEstate +
                                               "; Цена: " + sent.price
                                           }).Where(est => ctx.Deals.Where(dl => dl.idSentence == est.idSent).Count() == 0).ToList();

            comboBoxSentence.DisplayMember = "address";
            comboBoxSentence.ValueMember = "idSent";
        }

        private void FillDemand()
        {

        }

        private void FormDeal_Load(object sender, EventArgs e)
        {
            FillTable();
            FillSentence();
            FillDemand();
        }
    }
}
