using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference;

namespace Client
{
    public partial class UpdateOtherData : Form
    {
        public UpdateOtherData()
        {
            InitializeComponent();
            setAllField();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                var all = from t in client.GetStudent() where t.Id == Main.ReturnId select t;
                MessageBox.Show(Main.ReturnId.ToString());
                foreach (var i in all)
                {
                    if (i.Id == Main.ReturnId)
                    {
                        client.AddOtherData(Main.ReturnId, comboBox_mender.Text, textBox_address.Text, textBox_telephone.Text, textBox_tickets.Text, float.Parse(textBox_middle.Text));
                    }
                }
                client.Close();
            }
        }

        private void setAllField()
        {
            comboBox_mender.Items.Add("Man");
            comboBox_mender.Items.Add("Woman");
            comboBox_mender.SelectedItem = "Man";
        }
    }
}
