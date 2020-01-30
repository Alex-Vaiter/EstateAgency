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
    public partial class FormDemand : Form
    {
        Demand currDemand = new Demand();

        public FormDemand()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDemand_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
        }

        private void FormDemand_Load(object sender, EventArgs e)
        {
            FillAgents();
            FillClients();
            FillTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            currDemand.idClient =       (int)comboBoxClient.SelectedValue;
            currDemand.idAgent =        (int)comboBoxAgent.SelectedValue;
            currDemand.typeEstate =     comboBoxType.Text;
            currDemand.city =           textBoxCity.Text;
            currDemand.street =         textBoxStreet.Text;
            currDemand.house =          textBoxHouse.Text;
            currDemand.apartment =      textBoxApart.Text;
            currDemand.latitude =       numLatit.Value;
            currDemand.longitude =      numLongit.Value;
            currDemand.minPrice =       IntToNull(numMinPrice.Value);
            currDemand.maxPrice =       IntToNull(numMaxPrice.Value);
            currDemand.minArea =        DecimalToNull(numMinArea.Value);
            currDemand.maxArea =        DecimalToNull(numMaxArea.Value);
            currDemand.minTotalFloors = IntToNull(numMinTotalFloors.Value);
            currDemand.maxTotalFloors = IntToNull(numMaxTotalFloors.Value);
            currDemand.minFloor =       IntToNull(numMinFloor.Value);
            currDemand.maxFloor =       IntToNull(numMaxFloor.Value);
            currDemand.minTotalRooms =  IntToNull(numMinTotalRooms.Value);
            currDemand.maxTotalRooms =  IntToNull(numMaxTotalRooms.Value);

            try
            {
                ClassGetContext.context.Demands.Add(currDemand);
                ClassGetContext.context.SaveChanges();

                FillTable();
                HidingTracks();
            }
            catch
            {
                using (var form = new FormMessage("При добавлении данных произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void HidingTracks()
        {
            comboBoxClient.Text =     default;
            comboBoxAgent.Text =      default;
            comboBoxType.Text =       default;
            textBoxCity.Text =        default;
            textBoxStreet.Text =      default;
            textBoxHouse.Text =       default;
            textBoxApart.Text =       default;
            numLatit.Value =          default;
            numLongit.Value =         default;
            numMinPrice.Value =       default;
            numMaxPrice.Value =       default;
            numMinArea.Value =        default;
            numMaxArea.Value =        default;
            numMinTotalFloors.Value = default;
            numMaxTotalFloors.Value = default;
            numMinFloor.Value =       default;
            numMaxFloor.Value =       default;
            numMinTotalRooms.Value =  default;
            numMaxTotalRooms.Value =  default;

            buttonChange.Enabled = false;
            buttonDel.Enabled = false;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            currDemand.idClient =       (int)comboBoxClient.SelectedValue;
            currDemand.idAgent =        (int)comboBoxAgent.SelectedValue;
            currDemand.typeEstate =     comboBoxType.Text;
            currDemand.city =           textBoxCity.Text;
            currDemand.street =         textBoxStreet.Text;
            currDemand.house =          textBoxHouse.Text;
            currDemand.apartment =      textBoxApart.Text;
            currDemand.latitude =       numLatit.Value;
            currDemand.longitude =      numLongit.Value;
            currDemand.minPrice =       IntToNull(numMinPrice.Value);
            currDemand.maxPrice =       IntToNull(numMaxPrice.Value);
            currDemand.minArea =        DecimalToNull(numMinArea.Value);
            currDemand.maxArea =        DecimalToNull(numMaxArea.Value);
            currDemand.minTotalFloors = IntToNull(numMinTotalFloors.Value);
            currDemand.maxTotalFloors = IntToNull(numMaxTotalFloors.Value);
            currDemand.minFloor =       IntToNull(numMinFloor.Value);
            currDemand.maxFloor =       IntToNull(numMaxFloor.Value);
            currDemand.minTotalRooms =  IntToNull(numMinTotalRooms.Value);
            currDemand.maxTotalRooms =  IntToNull(numMaxTotalRooms.Value);

            try
            {
                ClassGetContext.context.SaveChanges();

                FillTable();
                HidingTracks();
            }
            catch
            {
                using (var form = new FormMessage("При изменении данных произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                ClassGetContext.context.Demands.Remove(currDemand);
                ClassGetContext.context.SaveChanges();
                FillTable();
                HidingTracks();
            }
            catch
            {
                using (var form = new FormMessage("При удалении данных произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
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

        private void FillTable()
        {
            try
            {
                var table = (from demand in ClassGetContext.context.Demands
                             join client in ClassGetContext.context.Clients on demand.idClient equals client.idClient
                             join agent in ClassGetContext.context.Agents on demand.idAgent equals agent.idAgent
                             select new
                             {
                                 demand.idDemand,
                                 client.idClient,
                                 nameClient = client.lastName + " " + client.firstName,
                                 agent.idAgent,
                                 nameAgent = agent.lastName + " " + agent.firstName,
                                 demand.typeEstate,
                                 demand.city,
                                 demand.street,
                                 demand.minPrice,
                                 demand.maxPrice
                             });

                dataGridViewDemands.Rows.Clear();
                foreach (var item in table)
                {
                    dataGridViewDemands.Rows.Add(item.idDemand, item.idClient, item.nameClient, item.idAgent,
                        item.nameAgent, item.typeEstate, item.city, item.street, item.minPrice, item.maxPrice);
                }
            }
            catch
            {
                using (var form = new FormMessage("При заполнении списка потребностей возникли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private void FieldVision(bool city = true, bool street = true, bool house = true,
            bool apartment = true, bool floor = true, bool area = true, bool totalFloors = true, bool totalRooms = true,
            bool latit = true, bool longit = true)
        {
            textBoxCity.Enabled = city;
            textBoxCity.Clear();
            textBoxStreet.Enabled = street;
            textBoxStreet.Clear();
            textBoxHouse.Enabled = house;
            textBoxHouse.Clear();
            textBoxApart.Enabled = apartment;
            textBoxApart.Clear();
            numLatit.Enabled = latit;
            numLatit.Value = 0;
            numLongit.Enabled = longit;
            numLongit.Value = 0;
        }

        private void dataGridViewDemands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewDemands.CurrentRow;

            try
            {
                int idDem = Convert.ToInt32(dataGridViewDemands.CurrentRow.Cells[0].Value);
                currDemand = ClassGetContext.context.Demands.Where(dm => dm.idDemand == idDem).FirstOrDefault();

                comboBoxClient.SelectedValue = currDemand.idClient;
                comboBoxAgent.SelectedValue =  currDemand.idAgent;
                comboBoxType.Text =            currDemand.typeEstate;
                textBoxCity.Text =             currDemand.city;
                textBoxStreet.Text =           currDemand.street;
                textBoxHouse.Text =            currDemand.house;
                textBoxApart.Text =            currDemand.apartment;
                numLatit.Value =               IsNull(currDemand.latitude);
                numLongit.Value =              IsNull(currDemand.longitude);
                numMinPrice.Value =            IsNull(currDemand.minPrice);
                numMaxPrice.Value =            IsNull(currDemand.maxPrice);
                numMinArea.Value =             IsNull(currDemand.minArea);
                numMaxArea.Value =             IsNull(currDemand.maxArea);
                numMinTotalFloors.Value =      IsNull(currDemand.minTotalFloors);
                numMaxTotalFloors.Value =      IsNull(currDemand.maxTotalFloors);
                numMinFloor.Value =            IsNull(currDemand.minFloor);
                numMaxFloor.Value =            IsNull(currDemand.maxFloor);
                numMinTotalRooms.Value =       IsNull(currDemand.minTotalRooms);
                numMaxTotalRooms.Value =       IsNull(currDemand.maxTotalRooms);

                buttonChange.Enabled = true;
                buttonDel.Enabled = true;
            }
            catch
            {
                using (var form = new FormMessage("При соединении с базой данных произошли ошибки", ChangePic.error))
                    form.ShowDialog();
            }
        }

        private decimal IsNull(decimal? item)
        {
            if (item == null)
                return 0;
            else
                return Convert.ToDecimal(item);
        }

        private int? IntToNull(decimal item)
        {
            if (item == 0)
                return null;
            else
                return Convert.ToInt32(item);
        }

        private decimal? DecimalToNull(decimal item)
        {
            if (item == 0)
                return null;
            else
                return Convert.ToDecimal(item);
        }

    }
}
