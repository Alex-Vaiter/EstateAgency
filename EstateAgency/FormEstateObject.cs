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

namespace EstateAgency
{
    public partial class FormEstateObject : Form
    {
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

        }

        private void FillTable()
        {
            foreach(EstateObject estate in ClassGetContext.context.EstateObjects)
            {
                dataGridViewEstates.Rows.Add(estate.idEstate, estate.city, estate.street, estate.house, estate.addressNumber,
                    estate.latitude, estate.longitude, estate.totalFloors, estate.totalArea, estate.rooms, estate.floor, estate.typeEstate);
            }
        }

        private void FillComboBox()
        {
            foreach(var item in ClassGetContext.context.EstateObjects.Select(es => es.city).Distinct())
            {
                comboBoxCity.Items.Add(item);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
