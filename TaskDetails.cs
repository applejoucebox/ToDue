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
    public partial class TaskDetails : Form
    {
        private ToDue.Models.Task t = new Models.Task();
        private ToDue.Models.TaskList tasks = new Models.TaskList();
        public TaskDetails(ToDue.Models.Task passedIn, ToDue.Models.TaskList tasksPassedIn)
        {
            InitializeComponent();
            t = passedIn;
            tasks = tasksPassedIn;
            loadInformation();
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            t.IsComplete = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saves changes before returning back to HomePage
            //for now can only see that the name has changed
            updateInformation();
            returnToHomePage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //returns to HomePage without saving any changes
            returnToHomePage();
        }

        private void loadInformation()
        {
            txtTaskName.Text = t.TaskName;
            txtDueDate.Text = t.DueDate;
            txtPriority.Text = t.Priority;
            txtSubject.Text = t.Subject;
            txtSummary.Text = t.Summary;
            txtXDetails.Text = t.XDetails;
        }
        private void updateInformation()
        {
            t.TaskName = txtTaskName.Text;
            t.DueDate = txtDueDate.Text;
            t.Priority = txtPriority.Text;
            t.Subject = txtSubject.Text;
            t.Summary = txtSummary.Text;
            t.XDetails = txtXDetails.Text;
        }
        private void returnToHomePage()
        {
            //moving from AddNewTask back to the HomePage 
            HomePage newForm = new HomePage(tasks);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        
    }
}
