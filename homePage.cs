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
        public HomePage(string btnTEST)
        {
            InitializeComponent();
            btnTask1.Text = btnTEST;
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
