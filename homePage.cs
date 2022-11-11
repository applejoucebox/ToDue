using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDue
{
    public partial class HomePage : Form
    {
        //will eventually want to pass in a TaskList to the HomePage
        //public HomePage(ToDue.Models.TaskList tList)
        //for now just testing with a singular task

        public HomePage(ToDue.Models.Task testTask)
        {
            InitializeComponent();
            btnTask1.Text = testTask.TaskName;
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            goToAddNewTask();
        }

        private void cboxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void goToAddNewTask()
        {
            //moving from HomePage to the AddNewTask form
            AddNewTask newForm = new AddNewTask();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
