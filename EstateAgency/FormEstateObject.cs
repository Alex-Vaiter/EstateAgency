using System;
using System.Collections;
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
    public partial class FormEstateObject : Form
    {
        EstateObject estateObject = new EstateObject();

        public FormEstateObject()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            Close();
        }

        private void FormEstateObject_Load(object sender, EventArgs e)
        {
            FillComboBox();

            comboBoxEstateType.SelectedIndex = 0;
            BoxesVision(false, false, false, false, false, false, false, false, false, false);
        }

        private void FillTable(List<EstateObject> collections)
        {
            dataGridViewEstates.Rows.Clear();
            foreach(EstateObject estate in collections)
            {
                dataGridViewEstates.Rows.Add(estate.idEstate, estate.city, estate.street, estate.house, estate.addressNumber,
                    estate.latitude, estate.longitude, estate.totalFloors, estate.totalArea, estate.rooms, estate.floor, estate.typeEstate);
            }
        }

        private void FillComboBox()
        {
            comboBoxCity.Items.Clear();
            comboBoxCity.Items.Add("(нет)");

            foreach(var item in ClassGetContext.context.EstateObjects.Select(es => es.city).Distinct())
            {
                comboBoxCity.Items.Add(item);
            }
        }

        private void comboBoxEstateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBoxEstateType.Text;
            comboBoxCity.SelectedIndex = 0;
            dataGridViewEstates.Rows.Clear();

            IQueryable<EstateObject> output = ClassGetContext.context.EstateObjects;
            ColumnVision();

            if (type != "(нет)")
            {
                output = (from estate in ClassGetContext.context.EstateObjects
                               where estate.typeEstate == type
                               select estate);
                
                switch (type)
                {
                    case "Квартира": ColumnVision(totalFloors: false, typeEstate:false);break;
                    case "Дом":      ColumnVision(apartment:false, floor:false, typeEstate:false); break;
                    case "Земля": ColumnVision(house:false, apartment:false, totalFloors:false, totalRooms:false, floor:false, typeEstate:false); break;
                }
            }

            FillTable(output.ToList());
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = comboBoxCity.Text;
            comboBoxEstateType.SelectedIndex = 0;
            dataGridViewEstates.Rows.Clear();

            IQueryable<EstateObject> output = ClassGetContext.context.EstateObjects;
            bool colCity = true;

            if (city != "(нет)")
            {
                output = (from estate in ClassGetContext.context.EstateObjects
                          where estate.city == city
                          select estate);
                colCity = false;
            }

            FillTable(output.ToList());
            ColumnVision(city: colCity);
        }

        private void ColumnVision(bool city = true, bool house = true, bool apartment = true, 
            bool totalFloors = true, bool totalRooms = true, bool floor = true, bool typeEstate = true)
        {
            var grid = dataGridViewEstates;

            grid.Columns[1].Visible = city;
            grid.Columns[3].Visible = house;
            grid.Columns[4].Visible = apartment;
            grid.Columns[7].Visible = totalFloors;
            grid.Columns[9].Visible = totalRooms;
            grid.Columns[10].Visible = floor;
            grid.Columns[11].Visible = typeEstate;
        }

        private void BoxesVision(bool city = true, bool street = true, bool house = true,
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
            textBoxFloor.Enabled = floor;
            textBoxFloor.Clear();
            numArea.Enabled = area;
            numArea.Value = 0;
            numTotalFloor.Enabled = totalFloors;
            numTotalFloor.Value = 0;
            numTotalRooms.Enabled = totalRooms;
            numTotalRooms.Value = 0;
            numLatit.Enabled = latit;
            numLatit.Value = 0;
            numLongit.Enabled = longit;
            numLongit.Value = 0;
        }

        private void dataGridViewEstates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewEstates.CurrentRow;
            comboBoxEstateEdit.Text = row.Cells[11].Value.ToString();

            estateObject.idEstate =   Convert.ToInt32(row.Cells[0].Value);
            textBoxCity.Text =        row.Cells[1].Value.ToString();
            textBoxStreet.Text =      row.Cells[2].Value.ToString();
            textBoxHouse.Text =       row.Cells[3].Value.ToString();
            textBoxApart.Text =       row.Cells[4].Value.ToString();
            numLatit.Value =          Convert.ToDecimal(row.Cells[5].Value);
            numLongit.Value =         Convert.ToDecimal(row.Cells[6].Value);
            numTotalFloor.Value =     Convert.ToDecimal(row.Cells[7].Value);
            numArea.Value =           Convert.ToDecimal(row.Cells[8].Value);
            numTotalRooms.Value =     Convert.ToDecimal(row.Cells[9].Value);
            textBoxFloor.Text =       row.Cells[10].Value.ToString();
        }

        private void comboBoxTypeEstateAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEstateEdit.Text)
            {
                case "Квартира": BoxesVision(totalFloors: false); break;
                case "Дом": BoxesVision(apartment:false, floor:false); break;
                case "Земля": BoxesVision(house:false, apartment: false, floor: false, totalFloors:false, totalRooms:false); break;
            }
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var result = (from estate in ClassGetContext.context.EstateObjects select estate).ToList();

            result = result.Where(est => 
                            Levenchtein.Length(est.city, textBoxCitySearch.Text) <= 3 && 
                            Levenchtein.Length(est.street, textBoxStreetSearch.Text) <= 3 &&
                            Levenchtein.Length(est.house, textBoxHouseSearch.Text) <= 1 &&
                            Levenchtein.Length(est.addressNumber, numApartSearch.Value.ToString()) <= 1)
                           .Select(es => es)
                           .ToList();

            FillTable(result);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCitySearch.Clear();
            textBoxStreetSearch.Clear();
            textBoxHouseSearch.Clear();
            numApartSearch.Value = 0;

            FillTable(ClassGetContext.context.EstateObjects.ToList());
        }
    }
}
