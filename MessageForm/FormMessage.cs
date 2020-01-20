using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstateAgency.BaseLogic;

namespace EstateAgency
{
    public partial class FormMessage : Form
    {
        private ClassChangePic Pic;
        public FormMessage(string message, ClassChangePic pic)
        {
            InitializeComponent();
            labelMessage.Text = message;
            Pic = pic;
            
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            string path = "";
            switch (Pic)
            {
                case ClassChangePic.warning: path = "pics/warning.svg";break;
                case ClassChangePic.error: path = "pics/danger.svg";break;
                default: path = "pics/success.svg";break;
            }

            if(string.IsNullOrEmpty(path))
            {
                return;
            }
            else
            {
                var svg = SvgDocument.Open(path);
                pictureBoxInfo.Image = svg.Draw(58, 58);
            }
        }
    }
}
