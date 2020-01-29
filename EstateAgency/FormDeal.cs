using EstateAgency.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
                             estate.typeEstate,
                             shareSeller = agentSent.dealShare,
                             shareBuyer = agentDem.dealShare,
                         });

            foreach (var row in table)
            {
                dataGridViewDeals.Rows.Add(row.idDeal, row.idDemand, row.idSentence, row.address,
                    row.price, row.nameCD, row.nameAD, row.nameCS, row.nameAS, row.typeEstate, row.shareSeller, row.shareBuyer);
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

                                               address = "Тип: " + estate.typeEstate +
                                               "; Г: " + estate.city +
                                               ((estate.street == null || estate.street == "") ? "" : "; Ул: " + estate.street) +
                                               ((estate.house == null || estate.house == "0" || estate.house == "") ? "" : "; Д: " + estate.house) +
                                               ((estate.addressNumber == null || estate.addressNumber == "0" || estate.addressNumber == "") ? "" : "; Кв: " + estate.addressNumber) +
                                               ((estate.rooms == null || estate.rooms == 0) ? "" : "; Кол-во комнат: " + estate.rooms) +
                                               ((estate.totalArea == null || estate.totalArea == 0) ? "" : "; Площадь: " + estate.totalArea) +
                                               ((estate.totalFloors == null || estate.totalFloors == 0) ? "" : "; Всего этажей: " + estate.totalFloors) +
                                               ((estate.floor == null || estate.floor == 0) ? "" : "; Этаж: " + estate.floor) +
                                               "; Цена: " + sent.price
                                           }).Where(est => ctx.Deals.Where(dl => dl.idSentence == est.idSent).Count() == 0).ToList();

            comboBoxSentence.DisplayMember = "address";
            comboBoxSentence.ValueMember = "idSent";
        }

        private void FillDemand()
        {
            var ctx = ClassGetContext.context;

            comboBoxDemand.DataSource = (from demand in ctx.Demands
                                         select new
                                         {
                                             idDem = demand.idDemand,
                                             address = "Тип: " + demand.typeEstate +
                                             "; Г: " + demand.city +
                                             ((demand.street == null || demand.street == "") ? "" : "; Ул: " + demand.street) +
                                             ((demand.house == null || demand.house == "0" || demand.house == "") ? "" : "; Д: " + demand.house) +
                                             ((demand.apartment == null || demand.apartment == "0" || demand.apartment == "") ? "" : "; Кв: " + demand.apartment) +
                                             ((demand.minArea == null || demand.minArea == 0) ? "" : "; Мин.площадь: " + demand.minArea) +
                                             ((demand.maxArea == null || demand.maxArea == 0) ? "" : "; Макс.площадь: " + demand.maxArea) +
                                             ((demand.minTotalFloors == null || demand.minTotalFloors == 0) ? "" : "; Мин.кол-во этажей: " + demand.minTotalFloors) +
                                             ((demand.maxTotalFloors == null || demand.maxTotalFloors == 0) ? "" : "; Макс.кол-во этажей: " + demand.maxTotalFloors) +
                                             ((demand.minTotalRooms == null || demand.minTotalRooms == 0) ? "" : "; Мин.кол-во комнат: " + demand.minTotalRooms) +
                                             ((demand.maxTotalRooms == null || demand.maxTotalRooms == 0) ? "" : "; Макс.кол-во комнат: " + demand.maxTotalRooms) +
                                             ((demand.minPrice == null || demand.minPrice == 0) ? "" : "; Мин.цена: " + demand.minPrice) +
                                             ((demand.maxPrice == null || demand.maxPrice == 0) ? "" : "; Макс.цена: " + demand.maxPrice)

                                         }).Where(est => ctx.Deals.Where(dl => dl.idDemand == est.idDem).Count() == 0).ToList();

            comboBoxDemand.DisplayMember = "address";
            comboBoxDemand.ValueMember = "idDem";
        }

        private void FormDeal_Load(object sender, EventArgs e)
        {
            FillTable();
            FillSentence();
            FillDemand();
        }

        private double CostServiceForClientSeller(int costEstate, string typeEstate)
        {
            double result = 0;

            switch (typeEstate)
            {
                case "Квартира": result = 36000 + costEstate * 0.01; break;
                case "Дом": result = 30000 + costEstate * 0.01; break;
                case "Земля": result = 30000 + costEstate * 0.02; break;
            }

            return result;
        }

        private double CostServiceForClientBuyer(int costEstate)
        {
            return costEstate * 0.03;
        }

        /// <summary>
        /// Возвращает долю риелтора и долю компании
        /// </summary>
        /// <returns>(доля риелтора, доля компании)</returns>
        private (double, double) Comission(double summPay, int dealShare = 45)
        {
            double companyPiece = 0, agentPiece = 0;

            agentPiece = summPay / 100 * dealShare;
            companyPiece = summPay - agentPiece;

            return (agentPiece, companyPiece);
        }

        private void dataGridViewDeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewDeals.CurrentRow;

            int priceEstate = Convert.ToInt32(row.Cells[4].Value);
            string typeEstate = row.Cells[9].Value.ToString();

            double summPay = CostServiceForClientSeller(priceEstate, typeEstate);
            textBoxClientSent.Text = summPay.ToString();

            (double, double) comiss = (0, 0);
            if (row.Cells[10].Value != null)
            {
                var comissAgentSeller = Convert.ToInt32(row.Cells[10].Value);
                comiss = Comission(summPay, comissAgentSeller);
            }
            else
            {
                comiss = Comission(summPay);
            }

            textBoxAgentSent.Text = comiss.Item1.ToString();
            double summForCompany = comiss.Item2;

            summPay = CostServiceForClientBuyer(priceEstate);
            textBoxClientDem.Text = summPay.ToString();

            if (row.Cells[11].Value != null)
            {
                var comissAgentBuyer = Convert.ToInt32(row.Cells[11].Value);
                comiss = Comission(summPay, comissAgentBuyer);
            }
            else
            {
                comiss = Comission(summPay);
            }

            textBoxAgentDem.Text = comiss.Item1.ToString();
            summForCompany += comiss.Item2;

            textBoxCompany.Text = summForCompany.ToString();
        }

        private bool Compare(Demand demand, EstateObject estate, int priceEstate)
        {
            if (demand.typeEstate != estate.typeEstate)
            {
                return false;
            }

            if (!string.IsNullOrWhiteSpace(demand.city))
            {
                if (!string.IsNullOrWhiteSpace(estate.city))
                {
                    if (demand.city != estate.city)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(demand.street))
            {
                if (!string.IsNullOrWhiteSpace(estate.street))
                {
                    if (demand.street != estate.street)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(demand.house))
            {
                if (!string.IsNullOrWhiteSpace(estate.house))
                {
                    if (demand.house != estate.house)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(demand.apartment))
            {
                if (!string.IsNullOrWhiteSpace(estate.addressNumber))
                {
                    if (demand.apartment != estate.addressNumber)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (demand.latitude != null)
            {
                if (estate.latitude != null)
                {
                    if (demand.latitude != estate.latitude)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (demand.longitude != null)
            {
                if (estate.longitude != null)
                {
                    if (demand.longitude != estate.longitude)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            #region Проверка цены
            if (demand.minPrice == null)
                demand.minPrice = 0;

            if (demand.maxPrice == null)
                demand.maxPrice = priceEstate;

            if (demand.minPrice > priceEstate || demand.maxPrice < priceEstate)
                return false;
            #endregion

            #region Проверка площади
            if (estate.totalArea == null)
                estate.totalArea = 0;

            if (demand.minArea == null)
                demand.minArea = 0;

            if (demand.maxArea == null)
                demand.maxArea = estate.totalArea;

            if (demand.minArea > estate.totalArea || demand.maxArea < estate.totalArea)
                return false;
            #endregion

            switch (estate.typeEstate)
            {
                case "Квартира":
                    {
                        if(estate.floor == null)
                            estate.floor = 0;

                        if (demand.minFloor == null)
                            demand.minFloor = 0;

                        if (demand.maxFloor == null)
                            demand.maxFloor = estate.floor;

                        if (demand.minFloor > estate.floor || demand.maxFloor < estate.floor)
                            return false;

                        if (estate.rooms == null)
                            estate.rooms = 1;

                        if (demand.minTotalRooms == null)
                            demand.minTotalRooms = 1;

                        if (demand.maxTotalRooms == null)
                            demand.maxTotalFloors = estate.floor;

                        if (demand.minTotalRooms > estate.rooms || demand.maxTotalRooms < estate.rooms)
                            return false;

                        break;
                    }
                case "Дом":
                    {
                        if (estate.totalFloors == null)
                            estate.totalFloors = 0;

                        if (demand.minTotalFloors == null)
                            demand.minTotalFloors = 0;

                        if (demand.maxTotalFloors == null)
                            demand.maxTotalFloors = estate.floor;

                        if (demand.minTotalFloors > estate.rooms || demand.maxTotalFloors < estate.rooms)
                            return false;

                        if (estate.rooms == null)
                            estate.rooms = 1;

                        if (demand.minTotalRooms == null)
                            demand.minTotalRooms = 1;

                        if (demand.maxTotalRooms == null)
                            demand.maxTotalFloors = estate.floor;

                        if (demand.minTotalRooms > estate.rooms || demand.maxTotalRooms < estate.rooms)
                            return false;

                        break;
                    }
            }

            return true;
        }

        private void comboBoxSentence_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ctx = ClassGetContext.context;

            int idSent = Convert.ToInt32(comboBoxSentence.SelectedValue);
            int idDem = Convert.ToInt32(comboBoxDemand.SelectedValue);

            var needObj = (from sent in ctx.Sentences
                           join estate in ctx.EstateObjects on sent.idEstate equals estate.idEstate
                           where sent.idSentence == idSent
                           select new
                           {
                               estate,
                               sent.price
                           }).FirstOrDefault();

            var demand = ctx.Demands.Where(dm => dm.idDemand == idDem).FirstOrDefault();

            MessageBox.Show(Compare(demand, needObj.estate, needObj.price).ToString());
        }
    }
}
