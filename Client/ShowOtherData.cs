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
    public partial class ShowOtherData : Form
    {
        public ShowOtherData()
        {
            InitializeComponent();
            SetDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDataGrid()
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                var list = client.GetOtherInfo();
                int count = 1;
                dataGridView1.Rows.Clear();
                foreach (var stud in list)
                {
                    dataGridView1.Rows.Add();
                    //dataGridView1.Rows[count - 1].Cells[0].Value = count;
                    dataGridView1.Rows[count - 1].Cells[0].Value = stud.Gender;
                    dataGridView1.Rows[count - 1].Cells[1].Value = stud.Telephone;
                    dataGridView1.Rows[count - 1].Cells[2].Value = stud.Street;
                    dataGridView1.Rows[count - 1].Cells[3].Value = stud.NumberSdudentTickets;
                    dataGridView1.Rows[count - 1].Cells[4].Value = float.Parse(stud.MiddleMark.ToString());
                    count++;
                }
                client.Close();
            }
        }
    }
}
