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
    public partial class AddNewTask : Form
    {
        public AddNewTask()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            returnToHomePage();
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            returnToHomePage();
        }


        private void returnToHomePage()
        {
            //moving from AddNewTask form back to the HomePage
            TaskDetails newForm = new TaskDetails(txtTaskName.Text, txtDueDate.Text, txtPriority.Text, txtSubject.Text, txtSummary.Text, txtXDetails.Text);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
