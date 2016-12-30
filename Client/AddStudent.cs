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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                client.AddStudent(textBox_name.Text, date_birthday.Value);
                client.Close();
            }
            UpdateDataGrid();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void UpdateDataGrid()
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                var list = client.GetStudent();
                int count = 0;
                Main.dataGridView_student.Rows.Clear();
                foreach (var stud in list)
                {
                    Main.dataGridView_student.Rows.Add();
                    Main.dataGridView_student.Rows[count].Cells[0].Value = stud.Id;
                    Main.dataGridView_student.Rows[count].Cells[1].Value = stud.Name;
                    Main.dataGridView_student.Rows[count].Cells[2].Value = stud.Date;
                    count++;
                }
                client.Close();
            }
        }
    }
}
