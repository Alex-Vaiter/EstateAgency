using EstateAgency.BaseLogic;
using Svg;
using System;
using System.Windows.Forms;

namespace EstateAgency
{
    public partial class FormMessage : Form
    {
        private ChangePic Pic;
        public FormMessage(string message, ChangePic pic)
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
                case ChangePic.warning: path = "pics/warning.svg"; break;
                case ChangePic.error: path = "pics/danger.svg"; break;
                default: path = "pics/success.svg"; break;
            }

            if (string.IsNullOrEmpty(path))
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
