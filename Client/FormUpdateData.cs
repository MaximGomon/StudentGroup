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
    public partial class FormUpdateData : Form
    {
        public FormUpdateData()
        {
            InitializeComponent();
            GetStudent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetStudent()
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                List<string> list = new List<string>();
                var all = from t in client.GetStudent() where t.Name.Length > 0 select t;
                
                foreach(var i in all)
                {
                    comboBox.Items.Add(i.Name);
                }
                client.Close();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                if(comboBox.Text != "")
                {
                    var all = from t in client.GetStudent() where t.Name.Length > 0 select t;

                    foreach (var i in all)
                    {
                        if(i.Name == comboBox.Text)
                        {
                            dateTimePicker1.Value = i.Date;
                        }
                    }
                }
                client.Close();
            }
        }
    }
}
