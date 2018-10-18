using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Förlåt om det står lätt tungvikt istället för halv tungvikt har inte orket att ändra på det (; Det är säker flera andra jag har skrivit andra namn på.
        //tror det var för att dem inte skulle behöva flyttas runt utan kan localisera sig vid tungvikt.





        //Ta inte bort den nedanför!!!
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flyttaAllaTextboxar();

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a belt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select your gender!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxdamer.SelectedIndex == -1 && cbxherrar.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select your weight!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("You need to insert you first and last name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                label5.Location = new Point(8,218);

                switch (cbxdamer.SelectedIndex)
                {
                    case 0: tungvikt.Location = new Point(292,218);
                        break;
                    case 1:  Ltungvikt.Location = new Point(295,218);
                        break;
                    case 2:  Mellanvikt.Location = new Point(295, 218);
                        break;
                    case 3:  Hmellanvikt.Location = new Point(295, 218);
                        break;
                    case 4:  Lättvikt.Location = new Point(295, 218);
                        break;
                    case 5:  hlättvikt.Location = new Point(295, 218);
                        break;
                    case 6:  extralättvikt.Location = new Point(295, 218);
                        break;

                }
                switch (cbxherrar.SelectedIndex)
                {
                    case 0:
                        tungvikt.Location = new Point(292, 218);
                        break;
                    case 1:
                        Ltungvikt.Location = new Point(295, 218);
                        break;
                    case 2:
                        Mellanvikt.Location = new Point(295, 218);
                        break;
                    case 3:
                        Hmellanvikt.Location = new Point(295, 218);
                        break;
                    case 4:
                        Lättvikt.Location = new Point(295, 218);
                        break;
                    case 5:
                        hlättvikt.Location = new Point(295, 218);
                        break;
                    case 6:
                        extralättvikt.Location = new Point(295, 218);
                        break;
                }
            }
            comboBox3.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                cbxherrar.Location = new Point(151, 172);
                cbxdamer.Location = new Point(-1000, -1000);
            }
            else if (comboBox3.SelectedIndex ==  1)
            {
                cbxdamer.Location = new Point(151, 172);
                cbxherrar.Location = new Point(-1000, -1000);
            }
        }

        private void flyttaAllaTextboxar()
        {
            Lättvikt.Location = new Point(-1000, -1000);
            Mellanvikt.Location = new Point(-1000, -1000);
            tungvikt.Location = new Point(-1000, -1000);
            Ltungvikt.Location = new Point(-1000, -1000);
            Hmellanvikt.Location = new Point(-1000, -1000);
            hlättvikt.Location = new Point(-1000, -1000);
            extralättvikt.Location = new Point(-1000, -1000);
        }
    }
}
