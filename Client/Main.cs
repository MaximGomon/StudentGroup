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
    public partial class Main : Form
    {
        private static int id_stud;
        public Main()
        {
            InitializeComponent();

            SetDataGrid();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.ShowDialog();
        }

        public static void SetDataGrid()
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                var list = client.GetStudent();
                int count = list.Length;
                dataGridView_student.Rows.Clear();
                client.SetNewId();
                foreach (var stud in list)
                {
                    dataGridView_student.Rows.Add();
                    dataGridView_student.Rows[count].Cells[0].Value = count;
                    dataGridView_student.Rows[count].Cells[1].Value = stud.Name;
                    dataGridView_student.Rows[count].Cells[2].Value = stud.Date;
                }
                client.Close();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                for (int i = 0; i < dataGridView_student.RowCount; i++)
                {
                    var list = client.GetStudent();
                    if (i == dataGridView_student.CurrentRow.Index)
                    {
                        client.RemoveStudent(list[i].Id, list[i].Name, list[i].Date);
                    }
                }
                AddStudent.UpdateDataGrid();
                client.Close();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SetDataGrid();
        }

        private void button_data_Click(object sender, EventArgs e)
        {
            FormUpdateData update = new FormUpdateData();
            update.ShowDialog();
        }

        private void button_update_other_data_Click(object sender, EventArgs e)
        {
            UpdateOtherData update = new UpdateOtherData();
            update.ShowDialog();
        }

        public static int ReturnId { get { return id_stud = dataGridView_student.CurrentRow.Index; } }
    }     
}
