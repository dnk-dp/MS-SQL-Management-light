using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_Management_light
{
    public partial class FormInfo : Form
    {
        bool isDK1activ = false, isAK1activ = false;
        public FormInfo()
        {
            InitializeComponent();

            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            string About = string.Format(CultureInfo.InvariantCulture, @"v {0}.{1}.{2}", v.Major, v.Minor, v.Build);

            labelVersion.Text = About;// "v" + Application.ProductVersion;//System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            labelDK1.BackColor = Color.Transparent;
            labelDK2.BackColor = Color.Transparent;
            labelAK1.BackColor = Color.Transparent;
            labelAK2.BackColor = Color.Transparent;
        }

        private void labelAlfatraining_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.alfatraining.de/gefoerderte-weiterbildung/");
        }

        private void labelEntwickler_Click(object sender, EventArgs e)
        {
            HideImage();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            isDK1activ = true;
        }

        private void HideImage()
        {
            isDK1activ = false;
            pictureBoxDK.Location = new Point(-200, 219);
            pictureBoxDK.Visible = false;

            isAK1activ = false;
            pictureBoxAK.Location = new Point(-200, 219);
            pictureBoxAK.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (isDK1activ)
            {
                pictureBoxDK.Location = new Point(82, 219);
                pictureBoxDK.Visible = true;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            HideImage();
        }

        private void labelAK1_Click(object sender, EventArgs e)
        {
            isAK1activ = true;
        }

        private void labelAK2_Click(object sender, EventArgs e)
        {
            if (isAK1activ)
            {
                pictureBoxAK.Location = new Point(16, 219);
                pictureBoxAK.Visible = true;
            }
        }
    }
}
